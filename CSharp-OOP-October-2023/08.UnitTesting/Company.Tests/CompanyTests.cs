using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Tests
{
    public class CompanyTests
    {
        private Department department;
        private Employee employee1;
        private Employee employee2;
        private Employee employee3;
        private Company company;

        [SetUp]
        public void SetUp()
        {
            company = new Company();

            employee1 = new Employee(Guid.NewGuid(), "Employee1", 1000);
            employee2 = new Employee(Guid.NewGuid(), "Employee2", 2000);
            employee3 = new Employee(Guid.NewGuid(), "Employee3", 3000);

            department = new Department();

            department.Employees.Add(employee1);
            department.Employees.Add(employee2);
            department.Employees.Add(employee3);

            company.Departments.Add(department);
        }

        [Test]
        public void When_RaiseSalary_Employees_Should_HaveCorectData()
        {
            company.RaiseSalary(20);

           //TODO - Mocking lecture
        }
    }
}
