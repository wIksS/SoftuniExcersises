
class Program
{
    static void Main()
    {
        Student niki = new Student() { Name = "Niki", Score = 2 };
        Student ivo = new Student() { Name = "Ivo", Score = 3 };

        niki.PrintStudent();
        ivo.PrintStudent();
    }
}


class Student
{
    public string Name { get; set; }

    public int Score { get; set; }

    public void PrintStudent()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Score);
    }
}