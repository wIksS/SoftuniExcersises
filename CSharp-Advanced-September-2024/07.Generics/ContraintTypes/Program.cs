Method<DateTime>();
Student student = Method<Student>();
//Method<StreamReader>();

T Method<T>() where T : new()
{
    T element = new T();

    return element;
}

class Student
{
    public Student()
    {
        Console.WriteLine("Hey!");
    }
}