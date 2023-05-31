
List<string> studentNames = new List<string>();
List<int> studentAges = new List<int>();
List<float> studentScores = new List<float>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter Student Name:");
    studentNames.Add(Console.ReadLine());

    Console.WriteLine("Enter Student Age:");
    studentAges.Add(int.Parse(Console.ReadLine()));

    Console.WriteLine("Enter Student Score:");
    studentScores.Add(float.Parse(Console.ReadLine()));
}

for (int i = 0; i < studentNames.Count; i++)
{
    Console.WriteLine($"{studentNames[i]} ({studentAges[i]}) - {studentScores[i]}");
}