
Student pesho = new Student()
{
    name = "Pesho Petrov",
    age = 13
};

PrintStudent(pesho);

Console.WriteLine(pesho.name);

void PrintStudent(Student student)
{
    student.name = "dimitrichko";
    Console.WriteLine($"{student.name} : {student.age}");

}

class Student
{
    public string name;
    public int age;
}