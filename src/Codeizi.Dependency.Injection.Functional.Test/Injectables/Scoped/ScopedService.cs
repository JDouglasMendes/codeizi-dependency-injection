using Codeizi.DI.Anotations;

namespace Codeizi.DI.Functional.Test.Injectables.Scoped
{
    [Injectable(typeof(IContract), typeof(ScopedService))]
    public class ScopedService : IContract
    {
    }
}