

Dictionary<string, double> studentScores = new Dictionary<string, double>();

studentScores.Add("Goshkoa", 6);
studentScores.Add("Dimitrichka", 3);
studentScores.Add("Anushkaa", 6);
studentScores.Add("Peshoa", 6);

studentScores = studentScores.OrderByDescending(s => s.Value)
    .ThenBy(s=> s.Key[s.Key.Length-1])
    .ThenBy(s => s.Key[0])
    .ToDictionary(s=> s.Key, s => s.Value);

foreach (var student in studentScores)
{
    Console.WriteLine($"{student.Key} - {student.Value}");
}
