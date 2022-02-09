using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using UNOUI.Helpers.Interfaces;

namespace UNOUI.Helpers
{
    internal static class AFacHelper
    {
        public static IContainer Container { get; private set; }
        public static void Registrar()
        {
            var builder = new ContainerBuilder();
            Registracion(builder);
            Container = builder.Build();
        }

        private static void Registracion(ContainerBuilder builder)
        {
            builder.RegisterType<ApiService>()
                .As<IApiService>()
                .InstancePerDependency();
        }
    }
}
