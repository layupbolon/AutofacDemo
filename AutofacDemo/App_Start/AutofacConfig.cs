using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.IService;
using Autofac.Lib;
using Autofac.Service;

namespace AutofacDemo
{
    public class AutofacConfig
    {
        public static void Bootstrapper()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<CacheProvider>()
                .WithParameter("name","这是通过Autofac注入到构造函数")
                .As<ICacheProvider>()
                .SingleInstance();

            //注入服务层
            Assembly[] AsmSvr = new Assembly[2];
            AsmSvr[0] = Assembly.Load("Autofac.Service");
            AsmSvr[1] = Assembly.Load("Autofac.IService");
            builder.RegisterAssemblyTypes(AsmSvr)
                .Where(t => t.Name.ToLower().EndsWith("service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope()
                .PropertiesAutowired(PropertyWiringOptions.AllowCircularDependencies);

            //builder.RegisterType<TestService>()
            //    .As<ITestService>()
            //    .InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}