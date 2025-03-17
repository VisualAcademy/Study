int[] array = { 3, 9, 5, 13, 12, 30 };
var query = Filter(array, i => i > 5);
foreach (int value in query) { WriteLine(value); }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    foreach (T value in src) { if (p(value)) yield return value; } // C# 2.0 yield
}

delegate bool Predicate<T>(T i);
