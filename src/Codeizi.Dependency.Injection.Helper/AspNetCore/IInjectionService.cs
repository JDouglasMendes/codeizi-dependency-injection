using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codeizi.Dependency.Injection
{
    internal interface IInjectionService
    {
        void AddService(
            IServiceCollection services,
            InjectableAttribute injectableAttribute,
            Type type);
    }
}