using Codeizi.DI.Helper.Anotations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Codeizi.DI.AspNetCore
{
    internal class InjectionManager
    {
        public static void AddInjectables(
            IServiceCollection services,
            IEnumerable<Type> types)
        {
            foreach (var item in types)
            {
                if (item.GetCustomAttribute(typeof(InjectableAttribute), false) is InjectableAttribute attribute)
                {
                    var injector = InjectionFabric.Get(attribute.Context);
                    injector.AddService(services, attribute, item);
                }
            }
        }
    }
}