
Dictionary<string, float> studentGrades = new Dictionary<string, float>();

studentGrades.Add("Pesho Nikolov", 2);
studentGrades.Add("Pesho Angelov", 2); 
studentGrades.Add("Pesho Dimitrov", 3);

studentGrades.Add("Niki", 3);
studentGrades.Add("Agi", 3);

studentGrades = studentGrades.OrderBy(x => x.Value)
    .ThenByDescending(x => x.Key)
    .ToDictionary(x => x.Key, x => x.Value);

foreach (var student in studentGrades)
{
    Console.WriteLine($"{student.Key} - {student.Value}");
}