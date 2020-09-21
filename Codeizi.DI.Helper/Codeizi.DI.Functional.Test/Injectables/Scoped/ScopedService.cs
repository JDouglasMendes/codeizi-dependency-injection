using Codeizi.DI.Helper.Anotations;

namespace Codeizi.DI.Functional.Test.Injectables
{
    [Injectable(typeof(IContract),typeof(ScopedService))]
    public class ScopedService : IContract
    {
    }
}