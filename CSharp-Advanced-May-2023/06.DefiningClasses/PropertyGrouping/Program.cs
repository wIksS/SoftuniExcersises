
Student student = new Student()
{
    FirstName = "Pesho",
    LastName = "Petrov"
};

Console.WriteLine(student.FullName);

class Student
{
    private string firstName;

    private string lastName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FullName
    {
        get { return $"{this.firstName} {this.lastName}"; }
    }
}