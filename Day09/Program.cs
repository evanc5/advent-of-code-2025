Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllLines("input.txt").Select(line => line.Split(',').Select(long.Parse).ToArray()).ToArray();
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    var maxArea = long.MinValue;
    for (int i = 0; i < input.Length; i++)
    {
        for (int j = i + 1; j < input.Length; j++)
        {
            var area = Area(input[i], input[j]);
            if (area > maxArea)
            {
                maxArea = area;
            }
        }
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 1: {maxArea}");
    System.Diagnostics.Debug.WriteLine($"Part 1: {elapsedTime}");
}

static void Part2()
{
    var input = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    int total = 0;

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 2: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 2: {elapsedTime}");
}

static long Area(long[] p1, long[] p2)
{
    return (Math.Abs(p1[0] - p2[0]) + 1) * (Math.Abs(p1[1] - p2[1]) + 1);
}
