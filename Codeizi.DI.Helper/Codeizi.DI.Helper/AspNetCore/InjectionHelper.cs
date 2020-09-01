using Codeizi.DI.Helper.Anotations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace Codeizi.DI.AspNetCore
{
    public static class InjectionHelper
    {
        public static IServiceCollection AddInjectables(
            this IServiceCollection services,
            Type start)
            => AddInjectables(services, start.Assembly);

        public static IServiceCollection AddInjectables(
            this IServiceCollection services,
            Assembly assembly)
        {
            var queryTypes = assembly
                            .GetTypes()
                            .Where(type => type.GetCustomAttribute(typeof(InjectableAttribute), false) != null);

            InjectionManager.AddInjectables(services, queryTypes);

            return services;
        }
    }
}