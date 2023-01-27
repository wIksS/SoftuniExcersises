using Students;

Student pesho = new Student()
{
    FirstName = "Pesho",
    LastName = "Petrov",
    Age = 20,
    AverageGrade = 3,
    Courses = new List<Course>()
};

pesho.Courses.Add(new Course()
{
    Name = "C# Advanced",
    StartDate = DateTime.Now,
    EndDate = DateTime.Now.AddDays(60),
    Lecturer = "Viktor Dakov"
});

pesho.Courses.Add(new Course()
{
    Name = "C# OOP",
    StartDate = DateTime.Now.AddDays(60),
    EndDate = DateTime.Now.AddDays(120),
    Lecturer = "Viktor Dakov"
});

pesho.Courses[0].StartDate = DateTime.Now.AddDays(1500000);

PrintStudent(pesho);


static void PrintStudent(Student student)
{
    Console.WriteLine($"Student {student.FirstName} {student.LastName} age {student.Age} grade {student.AverageGrade} was added");

    if (student.Courses.Count > 0)
    {
        foreach (var course in student.Courses)
        {
            Console.WriteLine($"{student.FirstName} is studying: {course.Name} starting {course.StartDate:Y} ending {course.EndDate:Y} with lecturer {course.Lecturer}");
        }
  
    }
}


























List<Student> students = new List<Student>();

students.Add(new Student()
{
    FirstName = "Goshko"
});


students.Add(new Student()
{
    FirstName = "Dimitrichko"
});


students.Add(new Student()
{
    FirstName = "Niki"
});

foreach (var student in students)
{
    Console.WriteLine(student.FirstName);
}