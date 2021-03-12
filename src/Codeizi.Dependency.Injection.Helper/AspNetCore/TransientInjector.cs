
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codeizi.Dependency.Injection
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