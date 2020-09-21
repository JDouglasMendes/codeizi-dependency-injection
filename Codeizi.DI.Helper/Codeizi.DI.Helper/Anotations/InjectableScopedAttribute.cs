using Codeizi.DI.Helper.Anotations;
using System;

namespace Codeizi.DI.Anotations
{
    public sealed class InjectableScopedAttribute : InjectableAttribute
    {
        public InjectableScopedAttribute()
            : base(InstanceContext.Scoped) { }

        public InjectableScopedAttribute(
            Type contract,
            Type implementation) :
            base(contract, implementation, InstanceContext.Scoped)
        { }
    }
}