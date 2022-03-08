using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(5,6);
            SoftwareEngineer engineer = new SoftwareEngineer();





            List<Employee> list = new List<Employee>()
            {
                new SoftwareEngineer(),
                new Intern(),
                new Employee(5,6)
            };

            Intern intern = new Intern();
            intern.GetHelp();

            SoftwareEngineer sde;
            //sde = new Employee();

            Employee employee;
            employee = new SoftwareEngineer();

            //((SoftwareEngineer)employee).

            Employee engineer = new SoftwareEngineer();

            FireEmployee(new Employee(5,6));
            FireEmployee(new SoftwareEngineer());
            FireEmployee(new Intern());

            FixLaptop(new Intern());

            ToStringObj(new DateTime());
            ToStringObj(5);

            //FixLaptop(new Employee());
        }

        public static void FireSocialEmployee(Employee employee)
        {
            //employee.SocialSkills
            Console.WriteLine("Closing all accounts");
            employee.Fire();
        }

        public static void FireEmployee(Employee employee)
        {
            Console.WriteLine("Closing all accounts");
            employee.Fire();
        }

        public static void FixLaptop(SoftwareEngineer engineer)
        {
            //engineer.Laptop
        }

        public static void ToStringObj(Object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
