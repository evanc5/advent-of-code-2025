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

    long total = 0;

    var freshLines = input.Where(line => line.Contains('-'));

    var ranges = new List<(long Start, long End)>();

    foreach (var freshLine in freshLines)
    {
        var split = freshLine.Split('-');
        var start = long.Parse(split[0]);
        var end = long.Parse(split[1]);

        ranges.Add((start, end));
    }

    var matchFound = true;
    while (matchFound)
    {
        matchFound = false;
        for (int i = 0; i < ranges.Count; i++)
        {
            for (int j = i + 1; j < ranges.Count; j++)
            {
                var rangeA = ranges[i];
                var rangeB = ranges[j];

                if (rangeA.Start <= rangeB.End && rangeB.Start <= rangeA.End)
                {
                    var newStart = Math.Min(rangeA.Start, rangeB.Start);
                    var newEnd = Math.Max(rangeA.End, rangeB.End);
                    ranges[i] = (newStart, newEnd);
                    ranges.RemoveAt(j);
                    matchFound = true;
                    break;
                }
            }
            if (matchFound)
            {
                break;
            }
        }
    }

    foreach (var range in ranges)
    {
        total += (int)(range.End - range.Start + 1);
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 2: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 2: {elapsedTime}");
}