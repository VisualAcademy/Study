int[] array = { 3, 9, 5, 13, 12, 30 };

var query = FilterAndProcess(array);

foreach (int value in query) { WriteLine(value); }

static IEnumerable<int> FilterAndProcess(params IEnumerable<int>[] numbers)
{
    return numbers.SelectMany(n => n).Where(i => i > 5).Where(i => i % 2 == 0);
}
