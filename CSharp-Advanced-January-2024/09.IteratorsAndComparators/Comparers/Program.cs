

University softUni = new University()
{
    AverageScore = 6.5,
    Students = new List<string>() { "1", "2", "3" },
    Name = "SoftUni"
};

University MIT = new University()
{
    AverageScore = 4.5,
    Students = new List<string>() { "1" },
    Name = "MIT"
};


University stanford = new University()
{
    AverageScore = 3.5,
    Students = new List<string>() { "1","3" },
    Name = "Stanford"
};
List<University> universities = new List<University>();

universities.Add(MIT);
universities.Add(softUni);
universities.Add(stanford);

universities = universities.OrderBy(x => x, new UniversityStudentsCountComparer()).ToList();

//SortedSet<University> sortedUniversities = new SortedSet<University>(universities, new UniversityNameComparer());

foreach (var university in universities)
{
    Console.WriteLine($"{university.Name} - {university.AverageScore}");
}

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

class UniversityStudentsCountComparer : IComparer<University>
{
    public int Compare(University? x, University? y)
    {
        return x.Students.Count.CompareTo(y.Students.Count);
    }
}

class UniversityNameComparer : IComparer<University>
{
    public int Compare(University? x, University? y)
    {
        return y.Name.CompareTo(x.Name);
    }
}