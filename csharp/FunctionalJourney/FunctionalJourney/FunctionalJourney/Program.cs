int[] array = { 3, 9, 5, 13, 12, 30 };
var query = array.AsQueryable().Where(i => i > 5).Where(i => i % 2 == 0);
foreach (int value in query) { WriteLine(value); }

static class MyExtensions
{
    public static IEnumerable<T> Where<T>(this IEnumerable<T> src, Predicate<T> p)
    {
        foreach (T value in src) { if (p(value)) yield return value; }
    }
}
