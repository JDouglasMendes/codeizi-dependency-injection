using Codeizi.DI.Anotations;

namespace Codeizi.DI.Functional.Test.Injectables.Transient
{
    [Injectable(typeof(ITransientContract),
        typeof(TransientService),
        InstanceContext.Transient)]
    public class TransientService : ITransientContract
    {
    }
}