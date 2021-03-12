using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codeizi.Dependency.Injection
{
    public class ScopedInjector : IInjectionService
    {
        public void AddService(
            IServiceCollection services,
            InjectableAttribute injectableAttribute,
            Type type)
        {
            if (injectableAttribute.IsInterface())
            {
                services.AddScoped(
                    injectableAttribute.Contract,
                    injectableAttribute.ImplementationType);
            }
            else
            {
                services.AddScoped(type);
            }
        }
    }
}