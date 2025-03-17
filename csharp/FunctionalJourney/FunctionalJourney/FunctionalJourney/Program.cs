int[] array = { 3, 9, 5, 13, 12, 30 };
IEnumerable<int> query = Filter(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

IEnumerable<int> Filter(IEnumerable<int> src, Predicate p)
{
    List<int> dst = new List<int>();
    foreach (int value in src) { if (p(value)) dst.Add(value); }
    return dst.ToArray();
}

delegate bool Predicate(int i);
