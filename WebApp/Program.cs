using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.Entities.UserEntities.Concrete;
using DataAccess.Context.ApplicationContext;
using DataAccess.Context.IdentityContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebApp.Autofac;

var builder = WebApplication.CreateBuilder(args);


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    });

var entityConnection = builder.Configuration.GetConnectionString("EntityConnection");
var identityConnection = builder.Configuration.GetConnectionString("IdentityConnection");

var result = builder.Services.AddDbContext<AppDbContext>(opt => 
{
    opt.UseNpgsql(entityConnection);
});

builder.Services.AddDbContext<AppIdentityDbContext>(opt => 
{
    opt.UseNpgsql(identityConnection);
});

builder.Services.AddIdentity<AppUser, IdentityRole<Guid>>(x=> 
{
    x.SignIn.RequireConfirmedPhoneNumber = false;
    x.SignIn.RequireConfirmedEmail = false;
    x.SignIn.RequireConfirmedAccount = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 3;
    x.Password.RequiredUniqueChars = 0;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequireUppercase = false;
    x.Password.RequireLowercase = false;
})
    .AddEntityFrameworkStores<AppIdentityDbContext>()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
