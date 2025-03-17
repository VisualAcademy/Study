int[] array = { 3, 9, 5, 13, 12, 30 };

await ExecuteQueryAsync(array);

async Task ExecuteQueryAsync(int[] array, bool printMessage = true)
{
    var query = array.AsQueryable().Where(i => i > 5 && i % 2 == 0);

    if (printMessage)
        foreach (int value in query)
            await Task.Run(() => WriteLine(value));
}
