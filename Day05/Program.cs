Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    int count = 0;

    var freshLines = input.Where(line => line.Contains('-'));
    var availableIngredients = input.Where(line => !string.IsNullOrWhiteSpace(line) && !line.Contains('-')).Select(long.Parse);

    foreach (var availableIngredient in availableIngredients)
    {
        foreach (var freshLine in freshLines)
        {
            var split = freshLine.Split('-');
            var start = long.Parse(split[0]);
            var end = long.Parse(split[1]);

            if (availableIngredient >= start && availableIngredient <= end)
            {
                count++;
                break;
            }
        }
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 1: {count}");
    System.Diagnostics.Debug.WriteLine($"Part 1: {elapsedTime}");
}

static void Part2()
{
    var input = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    int total = 0;

    var freshLines = input.Where(line => line.Contains('-'));

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 2: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 2: {elapsedTime}");
}