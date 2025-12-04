Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    var total = 0;

    foreach (var line in input)
    {
        var digits = line.Select(c => int.Parse(c.ToString())).ToArray();

        var firstMax = digits[..^1].Max();
        var firstMaxIndex = digits.IndexOf(firstMax);
        var secondMax = digits[(firstMaxIndex + 1)..].Max();

        total += int.Parse($"{firstMax}{secondMax}");
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 1: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 1: {elapsedTime}");
}

static void Part2()
{
    var input = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    long total = 0;
    const int batteryCount = 12;

    foreach (var line in input)
    {
        var digits = line.Select(c => int.Parse(c.ToString())).ToArray();

        int digitsFound = 0;
        int nextIndex = 0;
        int[] selectedDigits = new int[batteryCount];
        while (digitsFound < batteryCount)
        {
            var searchSpace = digits[nextIndex..^(batteryCount - digitsFound - 1)];
            var max = searchSpace.Max();
            nextIndex = searchSpace.IndexOf(max) + nextIndex + 1;
            selectedDigits[digitsFound] = max;
            digitsFound++;
        }
        total += long.Parse(string.Concat(selectedDigits));
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 2: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 2: {elapsedTime}");
}