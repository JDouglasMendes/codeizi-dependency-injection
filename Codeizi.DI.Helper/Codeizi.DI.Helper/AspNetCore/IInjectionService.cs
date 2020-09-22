using Codeizi.DI.Anotations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Codeizi.DI.AspNetCore
{
    internal interface IInjectionService
    {
        void AddService(
            IServiceCollection services,
            InjectableAttribute injectableAttribute,
            Type type);
    }
}