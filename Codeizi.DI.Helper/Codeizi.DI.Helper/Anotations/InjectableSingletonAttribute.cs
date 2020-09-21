using Codeizi.DI.Helper.Anotations;
using System;

namespace Codeizi.DI.Anotations
{
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