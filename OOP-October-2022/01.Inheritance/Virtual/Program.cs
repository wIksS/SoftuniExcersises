using System;

namespace Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Work();


            Programmer programmer = new Programmer();

            programmer.Work();
        }
    }
}
