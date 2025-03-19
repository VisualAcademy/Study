int[] array = { 3, 9, 5, 13, 12, 30 };

// C# 11.0: List Patterns 사용
var query = Filter(array, i => i > 5);
foreach (int value in query) { Console.WriteLine(value); }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    foreach (T value in src)
    {
        if (p(value))
            yield return value;
    }
}

// C# 11.0: List Pattern 적용
bool ContainsPattern(int[] numbers)
{
    return numbers is [3, _, 5, .., 30]; // 3과 5가 특정 위치에 있고, 마지막이 30이면 true
}

Console.WriteLine(ContainsPattern(array)); // true
