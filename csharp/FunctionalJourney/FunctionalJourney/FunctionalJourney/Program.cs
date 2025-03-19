// 무명 메서드(Anonymous Method)
int[] array = { 3, 9, 5, 13, 12, 30 };
IEnumerable<int> query = Filter(array, delegate (int i) { return i > 5; });
foreach (int value in query) { WriteLine(value); }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    foreach (T value in src) { if (p(value)) yield return value; }
}

delegate bool Predicate<T>(T i);
