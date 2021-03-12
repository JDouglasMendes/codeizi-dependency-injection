using System;

namespace Codeizi.Dependency.Injection
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class InjectableAttribute : Attribute
    {
        internal InstanceContext Context { get; }
        internal Type Contract { get; }
        internal Type ImplementationType { get; }

        public InjectableAttribute(
            InstanceContext context = InstanceContext.Scoped)
            => Context = context;

        public InjectableAttribute(
            Type contract,
            Type implementation,
            InstanceContext context = InstanceContext.Scoped)
            => (Context, Contract, ImplementationType) =
            (context, contract, implementation);

        public bool IsInterface()
            => ImplementationType != null &&
             Contract != null;
    }
}