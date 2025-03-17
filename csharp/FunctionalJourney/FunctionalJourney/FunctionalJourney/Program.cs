// https://youtu.be/abPa5AagcwY
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        int[] array = { 3, 9, 5, 13, 12, 30 };
        int[] query = Filter(array, GreaterThanFive);
        foreach (int value in query) { Console.WriteLine(value); }
    }

    static bool GreaterThanFive(int i) { return i > 5; }

    static int[] Filter(int[] src, Predicate p)
    {
        ArrayList dst = new ArrayList();
        foreach (int value in src) { if (p(value)) dst.Add(value); }
        int[] result = new int[dst.Count];
        for (int i = 0; i < result.Length; i++) { result[i] = (int)dst[i]; }
        return result;
    }

    delegate bool Predicate(int i);
}
