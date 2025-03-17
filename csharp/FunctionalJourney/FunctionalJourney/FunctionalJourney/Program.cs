int[] array = { 3, 9, 5, 13, 12, 30 };
var query = Filter(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    foreach (T value in src) { if (p(value)) yield return value; } // C# 2.0 yield
}

delegate bool Predicate<T>(T i);
