
Student student = new Student();

student.FullName = "Neshto";

class Student
{
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            Console.WriteLine("Haha lied to you");
        }
    }
}

//class Student
//{
//    private string firstName;

//    public string FirstName
//    {
//        get { return firstName; }
//        set { firstName = value; }
//    }
//}