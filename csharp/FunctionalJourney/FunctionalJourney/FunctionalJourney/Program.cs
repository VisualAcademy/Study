int[] array = { 3, 9, 5, 13, 12, 30 };
int[] query = Filter(array, GreaterThanFive);
foreach (int value in query) { WriteLine(value); }

bool GreaterThanFive(int i) { return i > 5; }

int[] Filter(int[] src, Predicate p)
{
    List<int> dst = new List<int>();
    foreach (int value in src) { if (p(value)) dst.Add(value); }
    int[] result = new int[dst.Count];
    for (int i = 0; i < result.Length; i++) { result[i] = dst[i]; }
    return result;
}

delegate bool Predicate(int i);
