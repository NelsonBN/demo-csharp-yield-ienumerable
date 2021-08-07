# Demo .NET Yield and IEnumerable
Demo of the use of yield return and IEnumerable on C#



## DEMO

The `04.Demo.Enumerable.FullImplementation` is an equivalent implementation to using the `03.Demo.Yield`;

```csharp
foreach(var item in results)
{
    Console.WriteLine(item);
}
```
**Equivalent**
```csharp
using(var iterator = results.GetEnumerator())
{
    while(iterator.MoveNext())
    {
        Console.WriteLine(iterator.Current);
    }
}
```



## Some mistakes

### Projecting data before iteration
Avoid using projecting operations like "ToList()" before iterations. It is going to completely resolve the enumerator generation and does not benefit from the yield operator.

```csharp
public static void Main(string[] _)
{
    var response = _getResults();

    var results = response.ToList(); // Avoid using "ToList" before "foreach"

    foreach(var item in results)
    {
        Console.WriteLine(item);
    }
}
private static IEnumerable<int> _getResults()
{
    for(var count = 0; count < 10; count++)
    {
        yield return count;
    }
}
```



## Reference links

- [Yield official documentation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield)
- [IEnumerable official documentation](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-5.0)



## Contribution

*Help me to help others*



## LICENSE

[MIT](https://github.com/NelsonBN/demo-csharp-yield-ienumerable/blob/main/LICENSE)