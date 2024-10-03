
Course.University = "SoftUni";
Course.Marketing();
Console.WriteLine(Course.MaxCourseParticipants);
Console.WriteLine(Course.University);

Course  cSharp = new Course() { Name="C#", Lecturer="Viktor"};

cSharp.Print();

class Course
{
    public const int MaxCourseParticipants = 250;


    public string Name { get; set; }

    public string Lecturer { get; set; }

    public static string University{ get; set; }

    public void Print()
    {
        Console.WriteLine($"{Name} - {Lecturer} -> {Course.University}");
    }

    public static void Marketing()
    {
        Console.WriteLine($"All courses in {Course.University} are cool!");
    }

    public static void Marketing(string agenda)
    {
        Console.WriteLine($"All courses in {Course.University} are {agenda}!");
    }
}