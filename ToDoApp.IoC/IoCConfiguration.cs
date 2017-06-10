using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.IoC
{
    public static class IoCConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            Configure(services, Data.IoC.Module.GetType());
            Configure(services, DomainServices.IoC.Module.GetType());
            Configure(services, AppServices.IoC.Module.GetType());
        }

        private static void Configure(IServiceCollection services, Dictionary<Type,Type> types)
        {
            foreach (var type in types)
            {
                services.AddScoped(type.Key, type.Value);
            }
        }
    }
}
