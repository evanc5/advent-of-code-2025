Part1();
Part2();

static void Part1()
{
    var lines = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    long total = 0;
    const int batteryCount = 2;

    foreach (var line in lines)
    {
        total += ProcessLine(line, batteryCount);
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 1: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 1: {elapsedTime}");
}

static void Part2()
{
    var lines = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    long total = 0;
    const int batteryCount = 12;

    foreach (var line in lines)
    {
        total += ProcessLine(line, batteryCount);
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 2: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 2: {elapsedTime}");
}

static long ProcessLine(string line, int batteryCount)
{
    var digits = line.Select(c => int.Parse(c.ToString())).ToArray();
    int[] selectedDigits = new int[batteryCount];

    int digitsFound = 0;
    int nextIndex = 0;

    while (digitsFound < batteryCount)
    {
        var searchSpace = digits[nextIndex..^(batteryCount - digitsFound - 1)];
        var max = searchSpace.Max();
        nextIndex = searchSpace.IndexOf(max) + nextIndex + 1;
        selectedDigits[digitsFound] = max;
        digitsFound++;
    }

    return long.Parse(string.Concat(selectedDigits));
}
