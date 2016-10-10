using Autofac;
using Autofac.Integration.Mvc;
using Cintera.DAL;
using System.Reflection;
using System.Web.Mvc;

namespace Cintera.Web
{
    public class AutofacConfig
    {
        public static IContainer RegisterAll()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacWebTypesModule());
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<DatabaseContext>().As<IDatabaseContext>().SingleInstance();

            /*builder.RegisterType<AppServices>().As<IAppServices>().InstancePerRequest();
            builder.RegisterType<AuthService>().As<IAuthService>().InstancePerRequest();
            builder.RegisterType<CookieService>().As<ICookieService>().InstancePerRequest();
            builder.RegisterType<RaygunLogger>().As<IErrorLogger>().SingleInstance();
            builder.RegisterType<DataContextFactory>().As<IDataContextFactory>().SingleInstance();
            builder.RegisterType<RequestService>().As<IRequestService>();

            builder.Register(GetAppSettings).SingleInstance();
            builder.Register(GetStorageService).SingleInstance();
            builder.Register(GetMessageService).SingleInstance();
            builder.Register(GetCacheService).SingleInstance();*/

            return Container(builder);
        }

        private static IContainer Container(ContainerBuilder builder)
        {
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }
    }
}