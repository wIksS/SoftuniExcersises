
int n = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();


for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    if (grades.ContainsKey(input[0]) == false)
    {
        grades.Add(input[0], new List<decimal>());
    }

    grades[input[0]].Add(decimal.Parse(input[1]));
}


foreach (var student in grades)
{
    Console.Write($"{student.Key} -> ");

    foreach (var grade in student.Value)
    {
        Console.Write($"{grade:f2} ");
    }

    Console.WriteLine($"(avg: {student.Value.Average():f2})");
}