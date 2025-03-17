int[] array = { 3, 9, 5, 13, 12, 30 };
var query = Filter(Filter(array, i => i > 5), i => i % 2 == 0); // pipeline
foreach (int value in query) { WriteLine(value); }

IEnumerable<T> Filter<T>(IEnumerable<T> src, Predicate<T> p)
{
    foreach (T value in src) { if (p(value)) yield return value; } 
}
