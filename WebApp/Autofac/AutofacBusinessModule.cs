using Autofac;
using DataAccess.Services.Concrete;
using DataAccess.Services.Interfaces;

namespace WebApp.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(BaseRepository<>).Assembly).AsClosedTypesOf(typeof(IBaseRepository<>)).InstancePerLifetimeScope();



            base.Load(builder);
        }
    }
}
