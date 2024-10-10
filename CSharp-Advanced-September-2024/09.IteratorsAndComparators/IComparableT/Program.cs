
Student dimitrichko = new Student("Dimi", 6);
Student goshko = new Student("Goshko", 2);
Student pepi = new Student("pepi", 3);

//Console.WriteLine(dimitrichko.CompareTo(goshko));
//Console.WriteLine(goshko.CompareTo(dimitrichko));

SortedSet<Student> list = new SortedSet<Student>() { dimitrichko, goshko, pepi };
//list.Sort();

foreach (var student in list)
{
    Console.WriteLine($"{student.Name} : {student.Score}");
}

list.Add(new Student("Gogi", 4));

class Student : IComparable<Student>
{
    public Student(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public string Name { get; set; }
    public int Score { get; set; }

    public int CompareTo(Student other)
    {
        Console.WriteLine($"Comparing: {Name} & {other.Name}");
        //return other.Score.CompareTo(Score);

        if (Score > other.Score)
        {
            return 1;
        }
        else if (Score < other.Score)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}