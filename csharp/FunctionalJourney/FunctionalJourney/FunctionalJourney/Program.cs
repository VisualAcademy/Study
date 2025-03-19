// C# 3.0 var keyword
int[] array = { 3, 9, 5, 13, 12, 30 };
var query = Filter(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    List<T> dst = new List<T>();
    foreach (T value in src) { if (p(value)) dst.Add(value); }
    return dst.ToArray();
}

delegate bool Predicate<T>(T i);
