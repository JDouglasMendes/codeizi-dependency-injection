using Codeizi.DI.Anotations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codeizi.DI.AspNetCore
{
    public class TransientInjector : IInjectionService
    {
        public void AddService(
            IServiceCollection services,
            InjectableAttribute injectableAttribute,
            Type type)
        {
            if (injectableAttribute.IsInterface())
            {
                services.AddTransient(
                    injectableAttribute.Contract,
                    injectableAttribute.ImplementationType);
            }
            else
            {
                services.AddTransient(type);
            }
        }
    }
}