using Codeizi.Dependency.Injection;

namespace Codeizi.DI.Functional.Test.Injectables.Transient
{
    [Injectable(typeof(ITransientContract),
        typeof(TransientService),
        InstanceContext.Transient)]
    public class TransientService : ITransientContract
    {
    }
}