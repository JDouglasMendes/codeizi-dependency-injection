using System;

namespace Codeizi.Dependency.Injection
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class InjectableSingletonAttribute : InjectableAttribute
    {
        public InjectableSingletonAttribute() :
            base(InstanceContext.Singleton)
        { }

        public InjectableSingletonAttribute(
            Type contract,
            Type implementation) :
            base(contract, implementation, InstanceContext.Singleton)
        { }
    }
}