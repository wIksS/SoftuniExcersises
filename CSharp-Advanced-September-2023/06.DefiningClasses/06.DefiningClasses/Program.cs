using Students;

Student dimitrichko = new Student()
{
    Name = "Dimitrichko",
    UserName = "Otlichnik",
    Score = 4
};

dimitrichko.Score = 6;

PrintStudent(dimitrichko);

void PrintStudent(Student student)
{
    Console.WriteLine($"{student.UserName}- {student.Name} : {student.Score}");
}

