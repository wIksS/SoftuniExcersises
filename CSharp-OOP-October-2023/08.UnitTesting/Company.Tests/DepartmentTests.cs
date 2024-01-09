using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Tests
{
    public class DepartmentTests
    {
        private Department department;
        private Employee employee1;
        private Employee employee2;
        private Employee employee3;

        [SetUp]
        public void SetUp()
        {
            employee1 = new Employee(Guid.NewGuid(), "Employee1", 1000);
            employee2 = new Employee(Guid.NewGuid(), "Employee2", 2000);
            employee3 = new Employee(Guid.NewGuid(), "Employee3", 3000);

            department = new Department();

            department.Employees.Add(employee1);
            department.Employees.Add(employee2);
            department.Employees.Add(employee3);
        }

        [TearDown]
        public void CleanUp()
        {

        }

        [Test]
        [TestCase(0)]
        [TestCase(20)]
        [TestCase(1000)]
        [TestCase(-50)]
        public void When_RaiseSalary_Employees_Should_HaveCorectData(int salaryPercentage)
        {
            department.RaiseSalary(salaryPercentage);

            Assert.AreEqual(1000 + 1000 * salaryPercentage / 100, employee1.Salary);
            Assert.AreEqual(2000 + 2000 * salaryPercentage / 100, employee2.Salary);
            Assert.AreEqual(3000 + 3000 * salaryPercentage / 100, employee3.Salary);
        }

        [Test]
        public void When_FiringPeople_EmployeeShouldBeRemove_AndSalaryShouldBe0()
        {
            Employee employee = department.Employees[1];

            department.FirePeople(employee.Id);

            Assert.AreEqual(2, department.Employees.Count);
            Assert.AreEqual(false, department.Employees.Contains(employee));
            Assert.AreEqual(0, employee.Salary);
        }

        [Test]
        public void When_FiringPeople_AndPersonIsNotFound_ExceptionShouldBe_Thrown()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                department.FirePeople(Guid.NewGuid());
            }, "No such employee found");           
        }
    }
}
