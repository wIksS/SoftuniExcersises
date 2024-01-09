

Type studentType = typeof(Student);

//Student student = new Student();
Student student = (Student) Activator.CreateInstance(studentType);

student.SayHi();
class Student
{
    public Student()
    {
        Console.WriteLine("Student was created!");
    }

    public void SayHi()
    {
        Console.WriteLine("Hello from student");
    }
}