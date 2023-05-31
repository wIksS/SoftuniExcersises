Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!studentGrades.ContainsKey(name))
    {
        studentGrades.Add(name, new List<decimal>());
    }

    studentGrades[name].Add(grade);
}

foreach (var student in studentGrades)
{
    Console.Write($"{student.Key} -> ");

    foreach (var grade in student.Value)
    {
        Console.Write($"{grade:f2} ");
    }

    Console.WriteLine($"(avg: {student.Value.Average():f2})");
}

//Console.WriteLine(new List<int>().Average());