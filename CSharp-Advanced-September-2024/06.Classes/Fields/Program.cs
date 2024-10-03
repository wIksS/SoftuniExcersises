
Student student = new Student();
student.SetName("Goshko");

Console.WriteLine(student.GetName());

class Student
{
    private string name;
    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        if (value.Length > 3)
        {
            name = value;
        }
        else
        {
            throw new ArgumentException("invalid name");
        }
    }
}