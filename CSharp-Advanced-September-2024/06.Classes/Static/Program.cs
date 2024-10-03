Student niki = new Student();
niki.thisStudentYears = 25;
Student.years = 25;

Console.WriteLine(Student.years);

class Student
{
    // instance member
    public int thisStudentYears = 1;
    // static member
    public static int years = 1;
}