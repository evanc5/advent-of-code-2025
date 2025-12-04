Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllLines("input.txt").Select(line => line.ToArray()).ToArray();
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    int total = 0;

    for (int row = 0; row < input.Length; row++)
    {
        for (int col = 0; col < input[row].Length; col++)
        {
            char current = input[row][col];
            if (current != '@')
            {
                continue;
            }

            int currentCount = 0;

            for (int r = row - 1; r <= row + 1; r++)
            {
                for (int c = col - 1; c <= col + 1; c++)
                {
                    if (r < 0 || r >= input.Length || c < 0 || c >= input[row].Length)
                        continue;
                    if (r == row && c == col)
                        continue;

                    char neighbor = input[r][c];
                    if (neighbor == '@')
                    {
                        currentCount++;
                    }
                }
            }
            if (currentCount < 4)
            {
                total++;
            }
        }
    }

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 1: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 1: {elapsedTime}");
}

static void Part2()
{
    var input = File.ReadAllLines("input.txt").Select(line => line.ToArray()).ToArray();
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    int total = 0;

    var elapsedTime = System.Diagnostics.Stopwatch.GetElapsedTime(startTime);
    Console.WriteLine($"Part 2: {total}");
    System.Diagnostics.Debug.WriteLine($"Part 2: {elapsedTime}");
}
