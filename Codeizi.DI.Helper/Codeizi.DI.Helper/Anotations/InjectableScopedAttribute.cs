using System;

namespace Codeizi.DI.Anotations
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
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