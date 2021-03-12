using System;

namespace Codeizi.Dependency.Injection
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class InjectableTransientAttribute : InjectableAttribute
    {
        public InjectableTransientAttribute()
            : base(InstanceContext.Transient)
        { }

        public InjectableTransientAttribute(
            Type contract,
            Type implementation)
            : base(contract, implementation, InstanceContext.Transient)
        { }
    }
}