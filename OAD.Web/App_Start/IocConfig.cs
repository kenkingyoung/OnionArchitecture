using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using OAD.Data;
using OAD.Repo;
using OAD.Service;

namespace OAD.Web
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // RegisterType 对非泛型类进行注册
            builder.RegisterType<SampleDataEntities>().InstancePerLifetimeScope();
            // RegisterGeneric 对泛型类进行注册
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerDependency();
            builder.RegisterType<OrderService>().As<IOrderService>().InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}