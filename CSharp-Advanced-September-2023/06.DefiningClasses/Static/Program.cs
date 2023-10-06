
using Static;


Student.StaticPrintStudent();
Console.WriteLine(Student.staticUniversity = "Changed SoftUni");

Student student = new Student();
student.instanceUniversity = "SoftUni instance";

student.PrintStudent();
