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
                var (start1, end1) = ranges[i];
                var (start2, end2) = ranges[j];

                if (start1 <= end2 && start2 <= end1 ||
                    start1 == end2 + 1 || start2 == end1 + 1)
                {
                    var newStart = Math.Min(start1, start2);
                    var newEnd = Math.Max(end1, end2);
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

    foreach (var (start, end) in ranges)
    {
        total += (int)(end - start + 1);
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 2: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 2: {elapsedTime}");
}
