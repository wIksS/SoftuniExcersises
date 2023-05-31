


List<int> list = new List<int>() { 5, 1, 7, 8, 19, 31, 14 };

list = list.OrderByDescending(num => num).ToList();

Console.WriteLine($"{string.Join(",", list)}");


List<Student> students = new List<Student>();

Student dimitrichko = new Student();
dimitrichko.age = 18;
dimitrichko.name = "Dimitrichko";

students.OrderBy(s => s.name).ThenBy(s => s.age);

class Student
{
    public int age;

    public string name;
}