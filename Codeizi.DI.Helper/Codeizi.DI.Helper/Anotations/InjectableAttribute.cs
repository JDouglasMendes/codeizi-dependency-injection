using System;

namespace Codeizi.DI.Helper.Anotations
{
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