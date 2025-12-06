Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllLines("input.txt").Select(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)).ToArray();
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    long total = 0;
    for (int i = 0; i < input[0].Length; i++)
    {
        var op = input[4][i];
        switch (op)
        {
            case "+":
                total += long.Parse(input[0][i]) + long.Parse(input[1][i]) + long.Parse(input[2][i]) + long.Parse(input[3][i]);
                break;
            case "*":
                total += long.Parse(input[0][i]) * long.Parse(input[1][i]) * long.Parse(input[2][i]) * long.Parse(input[3][i]);
                break;
        }
    }

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