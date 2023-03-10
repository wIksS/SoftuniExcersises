

using Throwing;

Student student = new Student();
int age = int.Parse(Console.ReadLine());
try
{
    student.Age = age;
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    //throw new SystemException("", ex);
}

