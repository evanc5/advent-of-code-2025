Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllText("input.txt").Split(',');
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    long total = 0;

    foreach (var item in input)
    {
        var split = item.Split('-');
        var start = long.Parse(split[0]);
        var end = long.Parse(split[1]);

        for (long i = start; i <= end; i++)
        {
            var number = i.ToString();
            var firstHalf = number[..(number.Length / 2)];
            var secondHalf = number[(number.Length / 2)..];
            if (firstHalf == secondHalf)
            {
                total += i;
            }
        }
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 1: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 1: {elapsedTime}");
}

static void Part2()
{
    var input = File.ReadAllText("input.txt").Split(',');
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    long total = 0;
    bool mismatch = false;

    foreach (var item in input)
    {
        var split = item.Split('-');
        var start = long.Parse(split[0]);
        var end = long.Parse(split[1]);

        for (long i = start; i <= end; i++)
        {
            var number = i.ToString();
            for (int len = 1; len <= number.Length / 2; len++)
            {
                if (number.Length % len != 0)
                {
                    continue;
                }
                var firstPart = number[..len];
                foreach (var j in Enumerable.Range(1, number.Length / len - 1))
                {
                    var part = number[(j * len)..(j * len + len)];
                    if (part != firstPart)
                    {
                        mismatch = true;
                        break;
                    }
                }
                if (!mismatch)
                {
                    total += i;
                    break;
                }
                mismatch = false;
            }
        }
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 2: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 1: {elapsedTime}");
}
