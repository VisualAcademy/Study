int[] array = { 3, 9, 5, 13, 12, 30 };

await ExecuteQueryAsync(array);

// C# 7.0 기능: 패턴 매칭 (Pattern Matching) 적용
async Task ExecuteQueryAsync(object input, bool printMessage = true)
{
    if (input is int[] array) // C# 7.0: 패턴 매칭 적용
        await (printMessage
            ? Task.WhenAll(array.AsQueryable()
                .Where(i => i > 5 && i % 2 == 0)
                .Select(i => Task.Run(() => WriteLine(i))))
            : Task.CompletedTask);
}
