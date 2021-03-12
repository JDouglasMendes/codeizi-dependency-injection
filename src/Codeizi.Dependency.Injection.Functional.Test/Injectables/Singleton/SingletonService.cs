using Codeizi.Dependency.Injection;

namespace Codeizi.DI.Functional.Test.Injectables.Singleton
{
    [Injectable(typeof(ISingletonContract),
        typeof(SingletonService),
        InstanceContext.Singleton)]
    public class SingletonService : ISingletonContract
    {
    }
}