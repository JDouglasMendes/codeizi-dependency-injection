using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codeizi.Dependency.Injection
{
    public class SingletonInjector : IInjectionService
    {
        public void AddService(
            IServiceCollection services,
            InjectableAttribute injectableAttribute,
            Type type)
        {
            if (injectableAttribute.IsInterface())
            {
                services.AddSingleton(
                    injectableAttribute.Contract,
                    injectableAttribute.ImplementationType);
            }
            else
            {
                services.AddSingleton(type);
            }
        }
    }
}