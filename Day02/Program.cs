Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllText("input.txt").Split(',');

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

    Console.WriteLine($"Part 1 {total}");
}

static void Part2()
{
    var input = File.ReadAllText("input.txt").Split(',');

    long total = 0;

    foreach (var item in input)
    {
        var split = item.Split('-');
        var start = long.Parse(split[0]);
        var end = long.Parse(split[1]);

        for (long i = start; i <= end; i++)
        {
            var number = i.ToString();
            // add to total if the number contains a sequence of digits that appear at least twice, e.g. 123123123, 55555, etc
        }
    }

    Console.WriteLine($"Part 2 ");
}