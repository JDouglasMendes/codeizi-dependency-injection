# Codeizi Dependency Injection (DI)

### Instalation



### Usage

```C#
[Injectable()]
public class ScopedIndividualService
```
Case your class implements interface, can indicate as folows:

```C#
[Injectable(typeof(IContract),typeof(ScopedService))]
public class ScopedService : IContract
```

#### Parameters

Context   | Instance Context                   | Service Add
----------|------------------------------------|----------------------
Scoped    |Default Or InstanceContext.Scoped   | `services.AddScoped`
Transient |InstanceContext.Transient           | `services.AddTransient`
Singleton |InstanceContext.Singleton           | `services.AddSingleton`


```C#
 [Injectable(InstanceContext.Singleton)] 
```
Or

```C#
[Injectable(typeof(ISingletonContract),
    typeof(SingletonService),
    InstanceContext.Singleton)]
```


### In Startup.cs

```C#
 services.AddInjectables(this.GetType().Assembly);
```

### Future Features

- Add multiples attributes in unique class.
