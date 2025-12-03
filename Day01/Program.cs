Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllLines("input.txt");

    int pos = 50;
    int count = 0;

    const int minPos = 0;
    const int maxPos = 99;

    foreach (var line in input)
    {
        var dir = line[0];
        var distance = int.Parse(line.Substring(1));

        if (dir == 'L')
        {
            pos -= distance;
        }
        else if (dir == 'R')
        {
            pos += distance;
        }

        while (pos < minPos)
        {
            pos += maxPos + 1;
        }
        while (pos > maxPos)
        {
            pos -= maxPos + 1;
        }

        if (pos == 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Part 1 {count}");
}

static void Part2()
{
    var input = File.ReadAllLines("input.txt");

    int pos = 50;
    int count = 0;

    const int minPos = 0;
    const int maxPos = 99;

    foreach (var line in input)
    {
        Console.WriteLine($"start {pos} turn {line} count {count}");

        var dir = line[0];
        var distance = int.Parse(line.Substring(1));

        if (dir == 'L')
        {
            if (pos == 0)
            {
                count--;
            }
            pos -= distance;
        }
        else if (dir == 'R')
        {
            pos += distance;
        }

        while (pos < minPos)
        {
            pos += maxPos + 1;
            if (pos != 0)
            {
                count++;
            }
        }
        while (pos > maxPos)
        {
            pos -= maxPos + 1;
            if (pos != 0)
            {
                count++;
            }
        }

        if (pos == 0)
        {
            count++;
        }
        Console.WriteLine($"end {pos} count {count}");
    }

    Console.WriteLine($"Part 2 {count}");
}
