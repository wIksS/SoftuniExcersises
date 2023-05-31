
Student student = new Student("Goshko");

class Student
{
    public Student()
    {
        Console.WriteLine("In the empty constructor ");
    }
    public Student(int age)
    {
        Console.WriteLine("In the age constructor " + age);
    }

    public Student(string name, int age) : this(age)
    {
        Console.WriteLine($"Name constructor : {name}");
    }
}