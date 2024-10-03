

int n =int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

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

foreach (var (student,grades) in studentGrades)
{
    string[] mappedGrades = grades.Select(grade => $"{grade:f2}").ToArray();

    Console.WriteLine($"{student} -> {string.Join(" ", mappedGrades)} (avg: {grades.Average():f2})");
}