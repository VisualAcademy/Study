int[] array = { 3, 9, 5, 13, 12, 30 };

await ExecuteQueryAsync(array);

// C# 6.0 기능: Expression-bodied method 적용
async Task ExecuteQueryAsync(int[] array, bool printMessage = true) =>
    await (printMessage ? Task.WhenAll(array.AsQueryable()
        .Where(i => i > 5 && i % 2 == 0)
        .Select(i => Task.Run(() => WriteLine(i)))) : Task.CompletedTask);
