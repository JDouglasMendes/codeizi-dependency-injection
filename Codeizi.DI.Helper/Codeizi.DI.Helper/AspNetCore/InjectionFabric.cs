using Codeizi.DI.Helper.Anotations;
using System;

namespace Codeizi.DI.AspNetCore
{
    internal static class InjectionFabric
    {
        public static IInjectionService Get(InstanceContext context)
        => context switch
        {
            InstanceContext.Scoped => new ScopedInjector(),
            InstanceContext.Transient => new TransientInjector(),
            InstanceContext.Singleton => new SingletonInjector(),
            _ => throw new ArgumentException(nameof(context)),
        };

    }
}