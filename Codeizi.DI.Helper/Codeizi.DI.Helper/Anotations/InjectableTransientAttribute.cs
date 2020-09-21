using Codeizi.DI.Helper.Anotations;
using System;

namespace Codeizi.DI.Anotations
{
    public sealed class InjectableTransientAttribute : InjectableAttribute
    {
        public InjectableTransientAttribute()
            : base(InstanceContext.Transient)
        { }

        public InjectableTransientAttribute(
            Type contract,
            Type implementation)
            : base (contract, implementation, InstanceContext.Transient)
        { }
    }
}