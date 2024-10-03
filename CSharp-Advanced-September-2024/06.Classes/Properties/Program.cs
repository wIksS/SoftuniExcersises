
Student student = new Student();

student.Name = "Nik";

Console.WriteLine(student.Name);

class Student
{
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length <= 3)
            {
                throw new ArgumentException("Invalid name");
            }

            name = value;
        }
    }
}