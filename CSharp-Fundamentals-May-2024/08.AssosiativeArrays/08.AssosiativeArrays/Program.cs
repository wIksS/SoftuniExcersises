// student ages
Dictionary<string, int> studentAges = new Dictionary<string, int>();

studentAges.Add("Goshko", 15);

studentAges.Add("Mitio", 23);
if (!studentAges.ContainsKey("Mitio"))
{
    studentAges.Add("Mitio", 2);
}

studentAges.Add("Dimitrichko", 34);

Console.WriteLine(studentAges["Goshko"]);

Console.WriteLine(studentAges["Dimitrichko"]);

foreach ( var studentAge in studentAges)
{
    Console.WriteLine($"{studentAge.Key} -> {studentAge.Value}");
}