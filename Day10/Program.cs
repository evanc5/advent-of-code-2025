Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    int total = 0;

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 1: {total}");
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
