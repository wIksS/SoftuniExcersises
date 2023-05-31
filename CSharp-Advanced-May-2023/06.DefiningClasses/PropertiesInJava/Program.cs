
StudentInJava student = new StudentInJava();

student.SetFirstName("Pesho");

Console.WriteLine(student.GetFirstName());

class StudentInJava
{
    private string firstName;

    public string GetFirstName()
    {
        return firstName;
    }
    public void SetFirstName(string value)
    {
        this.firstName = value;
    }
}
class StudentInCSharp
{
    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName { get; set; }

}
