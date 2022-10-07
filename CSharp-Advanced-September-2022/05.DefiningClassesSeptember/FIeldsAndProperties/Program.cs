using System;

namespace FIeldsAndProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = Console.ReadLine();
            Console.WriteLine(student.Name);

            Human human = new Human();
            human.FirstName = "Pesho";
            human.LastName = "Goshov";

            Console.WriteLine(human.FullName);




            //student.Greet();

            //Student student2= new Student();
            //student2.Username = "Dimitrichko";

            //student2.Greet();

        }
    }
}
