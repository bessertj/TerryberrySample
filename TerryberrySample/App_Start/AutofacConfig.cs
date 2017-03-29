using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TerryberrySample.Sample.Abstract;
using TerryberrySample.Sample.Infrastructure;

namespace TerryberrySample
{
    public class AutofacConfig
    {
        public static IContainer Container { get; private set; }

        public static void Config()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<HelloWorldRepository>().As<IHelloWorldRepository>();

            Container = builder.Build();
        }
    }
}