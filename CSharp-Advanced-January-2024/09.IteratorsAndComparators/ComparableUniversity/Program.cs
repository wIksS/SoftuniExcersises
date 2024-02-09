
University softUni = new University()
{
    AverageScore = 6.5,
    Students = new List<string>() { "1", "2", "3" },
    Name="SoftUni"
};

University MIT = new University()
{
    AverageScore=4.5,
    Students = new List<string>() { "1"},
    Name = "MIT"
};


University stanford = new University()
{
    AverageScore = 3.5,
    Students = new List<string>() { "1" },
    Name = "Stanford"
};
List<University> universities = new List<University>();

universities.Add(MIT);
universities.Add(softUni);
universities.Add(stanford);

universities = universities.OrderBy(u => u).ToList();


foreach (var university in universities)
{
    Console.WriteLine($"{university.Name} - {university.AverageScore}");
}

bool isBetterThan6 = softUni.CompareTo(6)==1 ? true : false;
Console.WriteLine($"SoftUni is better than 6: {isBetterThan6}");


class University : IComparable<University>, IComparable<int>
{
    public string Name { get; set; }

    public List<string> Students { get; set; }

    public double AverageScore { get; set; }

    public int CompareTo(University? other)
    {
        Console.WriteLine($"Comparing: {Name} with {other.Name}");
        return AverageScore.CompareTo(other.AverageScore) * -1;
    }

    public int CompareTo(int other)
    {
        return AverageScore.CompareTo(other);
    }
}