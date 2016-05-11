using System.Diagnostics;
using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Configuration;
using Autofac.Integration.Mvc;
using Autofac.Lib;

namespace AutofacDemo
{
    public class AutofacConfig
    {
        public static void Bootstrapper()
        {
            ContainerBuilder builder = new ContainerBuilder();

            //添加这段代码可以实现controller构造函数注入
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //构造函数
            builder.RegisterType<CacheProvider>()
                .WithParameter("name","这是通过Autofac注入到构造函数")
                .As<ICacheProvider>()
                .SingleInstance();

            ////反射
            //Assembly[] AsmSvr = new Assembly[2];
            //AsmSvr[0] = Assembly.Load("Autofac.Service");
            //AsmSvr[1] = Assembly.Load("Autofac.IService");
            //builder.RegisterAssemblyTypes(AsmSvr)
            //    .Where(t => t.Name.ToLower().EndsWith("service"))
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope()
            //    .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            //普通
            //builder.RegisterType<TestService>()
            //    .As<ITestService>()
            //    .InstancePerRequest();

            //读取配置文件
            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}