using System.Xml.Linq;

Dictionary<string, string> contestsPasswords = new Dictionary<string, string>();

Dictionary<string, Dictionary<string, int>> studentContests = new Dictionary<string, Dictionary<string, int>>();

Dictionary<string, int> studentTotalScore = new Dictionary<string, int>();

string input = Console.ReadLine();

while (input != "end of contests")
{
    string[] split = input.Split(":");

    string name = split[0];
    string password = split[1];

    if (!contestsPasswords.ContainsKey(name))
    {
        contestsPasswords.Add(name, password);
    }

    input = Console.ReadLine();
}


input = Console.ReadLine();
//C# Fundamentals=>fundPass=>Tanya=>350
while (input != "end of submissions")
{
    string[] split = input.Split("=>");
    string contestName = split[0];
    string contestPassword = split[1];
    string studentName = split[2];
    int studentScore = int.Parse(split[3]);

    if (contestsPasswords.ContainsKey(contestName))
    {
        if (contestsPasswords[contestName] == contestPassword)
        {
            {
                if (!studentContests.ContainsKey(studentName))
                {
                    studentContests.Add(studentName, new Dictionary<string, int>());
                    studentTotalScore.Add(studentName, 0);
                }

                if (!studentContests[studentName].ContainsKey(contestName))
                {
                    studentContests[studentName].Add(contestName, 0);
                }
            }

            if (studentContests[studentName][contestName] < studentScore)
            {
                studentContests[studentName][contestName] = studentScore;
            }

        }
    }

    input = Console.ReadLine();
}

foreach (var (student, contests) in studentContests)
{
    foreach (var (contest, score) in contests)
    {
        studentTotalScore[student] += score;
    }
}

string maxStudentName = "";
int maxStudentScore = 0;

foreach (var (student, score) in studentTotalScore)
{
    if (score > maxStudentScore)
    {
        maxStudentScore = score;
        maxStudentName = student;
    }
}

Console.WriteLine($"Best candidate is {maxStudentName} with total {maxStudentScore} points.");
//Ranking:
//Nikola
//#  C# Fundamentals -> 200

studentContests = studentContests.OrderBy(s => s.Key)
    .ToDictionary(s => s.Key, s => s.Value);

Console.WriteLine($"Ranking:");
foreach (var (student, contests) in studentContests)
{
    Console.WriteLine($"{student}");
    Dictionary<string, int> sortedContests = contests.OrderByDescending(c => c.Value)
        .ToDictionary(c => c.Key, c => c.Value);

    foreach (var (contestName, score) in sortedContests)
    {
        Console.WriteLine($"#  {contestName} -> {score}");
    }
}