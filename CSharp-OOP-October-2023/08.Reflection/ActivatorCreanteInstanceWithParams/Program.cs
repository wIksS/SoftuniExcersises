

Student student = (Student)Activator.CreateInstance(typeof(Student), new object[] { "Dimitrichko", "Petrov" });

Console.WriteLine(student.FirstName + " " + student.LastName);
class Student
{
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
}