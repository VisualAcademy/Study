int[] array = { 3, 9, 5, 13, 12, 30 };
var query = from i in array.AsQueryable()
            where i > 5
            where i % 2 == 0
            select i;
foreach (int value in query) { WriteLine(value); }
