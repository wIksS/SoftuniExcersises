
Dictionary<string, float> averageGrades = new Dictionary<string, float>();

averageGrades.Add("Gogi", 6);
averageGrades.Add("Dimitrichko", 4.33f);

foreach (var grade in averageGrades)
{
    Console.WriteLine($"{grade.Key} {grade.Value}");
}

if (averageGrades.ContainsKey("key"))
{

}
Console.WriteLine(averageGrades["Gogiiiiii"]);