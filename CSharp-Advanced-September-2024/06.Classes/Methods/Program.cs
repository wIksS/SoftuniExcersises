Student student1 = new Student() { Name="Niki"};
Student student2 = new Student() { Name = "Ivo" };

student1.Print();
student2.Print();

class Student
{
    private string campus = "Softuni";

    public string Name { get; set; }

    public void Print()
    {
        Console.WriteLine(this.campus);

        Console.WriteLine(Name);
    }
}