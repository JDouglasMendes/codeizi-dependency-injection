using Codeizi.Dependency.Injection;

namespace Codeizi.DI.Functional.Test.Injectables.Scoped
{
    [Injectable(typeof(IContract), typeof(ScopedService))]
    public class ScopedService : IContract
    {
    }
}