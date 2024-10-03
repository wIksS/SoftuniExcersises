

Student student = new Student();

student.Name = "Nik";
student.LastName = "Nikov";

Console.WriteLine(student.Name);

Console.WriteLine(student.FullName);
class Student
{
    public string Name { get; set; }

    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            return Name + " " + LastName;
        }
    }
}