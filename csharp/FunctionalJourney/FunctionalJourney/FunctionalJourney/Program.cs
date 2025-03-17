int[] array = { 3, 9, 5, 13, 12, 30 };

var input = new QueryInput { Data = array };

var modifiedInput = input with { Data = array.Where(i => i % 2 == 0).ToArray() };

await ExecuteQueryAsync(modifiedInput);

async Task ExecuteQueryAsync(object input, bool printMessage = true) =>
    await (input switch
    {
        QueryInput { Data: int[] array } when printMessage
            => Task.WhenAll(array.AsQueryable()
                .Where(i => i > 5 && i % 2 == 0)
                .Select(i => Task.Run(() => WriteLine(i)))),

        QueryInput => Task.CompletedTask,

        _ => throw new ArgumentException("Invalid input type")
    });

record QueryInput
{
    public int[] Data { get; init; } = Array.Empty<int>();
}
