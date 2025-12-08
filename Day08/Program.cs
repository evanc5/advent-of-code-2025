Part1();
Part2();

static void Part1()
{
    var input = File.ReadAllLines("input.txt");
    var startTime = System.Diagnostics.Stopwatch.GetTimestamp();

    int total = 0;
    var points = new List<(int x, int y, int z)>();
    foreach (var line in input)
    {
        var split = line.Split(',');
        var x = int.Parse(split[0]);
        var y = int.Parse(split[1]);
        var z = int.Parse(split[2]);
        points.Add((x, y, z));
    }

    var circuits = new List<List<(int x, int y, int z)>>();

    for (int i = 0; i < points.Count; i++)
    {
        double shortestDistance = double.MaxValue;
        int closestPointIndex = -1;
        for (int j = 0; j < points.Count; j++)
        {
            if (i == j) continue;
            var distance = Distance(points[i], points[j]);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                closestPointIndex = j;
            }
        }

        if (circuits.Any(c => c.Contains(points[closestPointIndex])))
        {
            var circuit = circuits.First(c => c.Contains(points[closestPointIndex]));
            // if (!circuit.Contains(points[i]))
            // {
            circuit.Add(points[i]);
            //}
        }
        else if (circuits.Any(c => c.Contains(points[i])))
        {
            var circuit = circuits.First(c => c.Contains(points[i]));
            //if (!circuit.Contains(points[closestPointIndex]))
            //{
            circuit.Add(points[closestPointIndex]);
            //}
        }
        else
        {
            circuits.Add([points[i], points[closestPointIndex]]);
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

static double Distance((int x, int y, int z) a, (int x, int y, int z) b)
{
    return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2) + Math.Pow(a.z - b.z, 2));
}
