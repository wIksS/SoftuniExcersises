
Console.WriteLine("Code before initialization");

Console.WriteLine(Course.University);

class Course
{
    static Course()
    {
        Console.WriteLine("Static was initialized!");
        university = "SoftUni";
    }

    public Course()
    {
        Console.WriteLine();
    }

    private static string university;

    public static string University
    {
        get
        {
            return university;
        }
        set { university = value; }
    }

}