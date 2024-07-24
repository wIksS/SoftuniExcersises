Student student = new Student()
{ FirstName = "Goshko", LastName = "Goshkov" };

Console.WriteLine(student.FullName);

Student student2 = new Student();
student2.FirstName = Console.ReadLine();
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

}