int[] array = { 3, 9, 5, 13, 12, 30 };

await ExecuteQueryAsync(array);

// C# 7.0 패턴 매칭 적용 + C# 8.0 switch 식 추가
async Task ExecuteQueryAsync(object input, bool printMessage = true) =>
    await (input switch
    {
        int[] array when printMessage => Task.WhenAll(array.AsQueryable()
            .Where(i => i > 5 && i % 2 == 0)
            .Select(i => Task.Run(() => WriteLine(i)))),

        int[] array => Task.CompletedTask, // printMessage가 false일 때

        _ => throw new ArgumentException("Invalid input type") // 다른 타입이 들어오면 예외 발생
    });
