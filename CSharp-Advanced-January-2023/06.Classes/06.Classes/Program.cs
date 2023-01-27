
using _06.Classes;

Course csharpAdvanced = new Course()
{
    Name = "C# Advanced",
    StartDate = DateTime.Now,
    EndDate = DateTime.Now.AddDays(60),
    Lecturer = "Viktor Dakov"
};

// new instance (object)
Student pesho = new Student()
{
    FirstName = "Pesho",
    LastName = "Petrov",
    Age = 20,
    AverageGrade = 3,
    Course = csharpAdvanced
};

Student gosho = new Student();

gosho.Age = 30;
gosho.FirstName = "Georgi";
gosho.LastName = "Georgiev";
gosho.AverageGrade = 2;
gosho.Course = csharpAdvanced;

Print(pesho);
Print(gosho);

while (true)
{
    Student student = new Student();

    student.FirstName = Console.ReadLine();
    student.LastName = Console.ReadLine();
    student.Age = int.Parse(Console.ReadLine());
    student.AverageGrade = double.Parse(Console.ReadLine());

    //PrintStudent(firstName, lastName, age, averageGrade);
    Print(student);
}


static void PrintStudent(string firstName, string lastName, int age, double averageGrade)
{
    Console.WriteLine($"Student {firstName} {lastName} age {age} grade {averageGrade} was added");
}

static void Print(Student student)
{
    Console.WriteLine($"Student {student.FirstName} {student.LastName} age {student.Age} grade {student.AverageGrade} was added");

    if (student.Course != null)
    {
        Console.WriteLine($"{student.FirstName} is studying: {student.Course.Name} starting {student.Course.StartDate:Y} ending {student.Course.EndDate:Y} with lecturer {student.Course.Lecturer}");
    }
}