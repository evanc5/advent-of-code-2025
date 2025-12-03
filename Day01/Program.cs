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
        var distance = int.Parse(line[1..]);

        if (distance >= (maxPos + 1))
        {
            distance %= maxPos + 1;
        }

        if (dir == 'L')
        {
            pos -= distance;
            if (pos < minPos)
            {
                pos += maxPos + 1;
            }
        }
        else if (dir == 'R')
        {
            pos += distance;
            if (pos > maxPos)
            {
                pos %= maxPos + 1;
            }
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
    int newPos;
    int count = 0;

    const int minPos = 0;
    const int maxPos = 99;

    foreach (var line in input)
    {
        var dir = line[0];
        var distance = int.Parse(line[1..]);

        if (distance >= (maxPos + 1))
        {
            count += distance / (maxPos + 1);
            distance %= maxPos + 1;
        }

        if (dir == 'L')
        {
            newPos = pos - distance;
            if (newPos < minPos)
            {
                if (pos > minPos)
                {
                    count++;
                }
                newPos += maxPos + 1;
            }
            pos = newPos;
        }
        else if (dir == 'R')
        {
            newPos = pos + distance;
            if (newPos > maxPos)
            {
                if (newPos != maxPos + 1)
                {
                    count++;
                }
                newPos %= maxPos + 1;
            }
            pos = newPos;
        }

        if (pos == 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Part 2 {count}");
}
