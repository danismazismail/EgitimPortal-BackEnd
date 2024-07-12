using Core.Entities.UserEntities.Concrete;
using DataAccess.Context.ApplicationContext;
using DataAccess.SeedData.IdentitySeedData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context.IdentityContext
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser , IdentityRole<Guid>, Guid>
    {
        //Npgsql'nin tarih ve saat verilerini ele alış biçimini eski sürümlerle uyumlu hale getirmek için yazılmıştır.
        static AppIdentityDbContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior",isEnabled: true);
        }

        public AppIdentityDbContext()
        {
        }

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> context) : base(context)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserSeedData());
            builder.ApplyConfiguration(new RoleSeedData());
            builder.ApplyConfiguration(new UserRoleSeedData());

            base.OnModelCreating(builder);
        }
    }
}