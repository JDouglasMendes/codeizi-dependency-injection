using Codeizi.DI.Helper.Anotations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codeizi.DI.AspNetCore
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