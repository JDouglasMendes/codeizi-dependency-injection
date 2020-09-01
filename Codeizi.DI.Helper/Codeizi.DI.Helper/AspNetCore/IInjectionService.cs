using Codeizi.DI.Helper.Anotations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

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
