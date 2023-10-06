
Student student = new Student();

student.Name = "Pesho";

Console.WriteLine(student.Name);

class Student
{
    //private string name;

    //public string Name
    //{
    //    get { return name; }
    //    set { name = value; }
    //}


    public string Name { get; set; }
}