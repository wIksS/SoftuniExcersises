using Static;

Student.PrintUniversity();


Student student = new Student();

student.Name = "Pesho";

student.Print();


Student.NumberOfStudents = 100;

Console.WriteLine(Student.NumberOfStudents);

//StaticClass staticClass = new StaticClass();