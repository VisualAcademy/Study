int[] array = { 3, 9, 5, 13, 12, 30 };

var processor = new QueryProcessor(array);
var query = processor.Filter(i => i > 5);

foreach (int value in query) { Console.WriteLine(value); }

// C# 12.0: Primary Constructor 적용
public class QueryProcessor(int[] data)
{
    public IEnumerable<int> Filter(Func<int, bool> predicate)
    {
        foreach (var value in data)
        {
            if (predicate(value))
                yield return value;
        }
    }
}
