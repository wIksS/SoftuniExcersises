using System;

namespace _01.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Junior junior = new Junior("Goshko");


            Employee employee = new Employee("Goshko");
            Console.WriteLine(employee.Name);

            Programmer programmer = new Programmer("Pesho");

            programmer.CreateBugs();
            programmer.Name = "Dimitrichko";

            programmer.GetPaid();

            TeamLead teamLead = new TeamLead();

            teamLead.FixBugs();
            teamLead.GetPaid();
        }
    }
}
