

using System.Reflection;

MethodInfo method = typeof(Student).GetMethod("FuncParam");

Student student = new Student();

method.Invoke(student, new object[] {
    (int x) => { Console.WriteLine("From func: " + x); return 6;}
});

class Student
{
    [Obsolete]
    public void FuncParam(Func<int, int> func)
    {
        func(5);
    }
}