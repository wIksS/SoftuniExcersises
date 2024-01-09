using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Tests
{
    public class EmployeeTests
    {
        private Guid guid = Guid.Parse("f8279729-88e1-447f-98de-1d0d42f7c919");
        private string name = "Dimitrichko";
        private int salary= 5000;

        [Test]
        public void When_CreatingANewEmployee_Id_ShouldBeNotBeNull()
        {
            Employee employee= new Employee();

            Assert.AreNotEqual(Guid.Empty, employee.Id);
        }

        [Test]
        public void When_CreatingANewEmployee_Data_ShouldBeSetCorrectly()
        {
            Employee employee = new Employee(guid, name, salary);

            Assert.AreEqual(guid, employee.Id);
            Assert.AreEqual(name, employee.Name);
            Assert.AreEqual(salary, employee.Salary);
        }

        [Test]
        public void When_PrintingAnEmployee_Format_ShouldBeCorrect()
        {
            Employee employee = new Employee(guid, name, salary);

            Assert.AreEqual("f8279729-88e1-447f-98de-1d0d42f7c919 - Dimitrichko is paid - 5000", employee.ToString());

        }
    }
}
