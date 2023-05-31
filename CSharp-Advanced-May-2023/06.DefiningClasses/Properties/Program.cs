
Student student = new Student();

student.FirstName = "P";

Console.WriteLine(student.FirstName);

class Student
{
    private string firstName;

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException();
            }

            this.firstName = value;
        }
    }
}