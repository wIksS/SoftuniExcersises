using NUnit.Framework;

namespace Company.Tests
{
    public class CompanyTests
    {
        private Company company;

        [SetUp]
        public void Setup()
        {
            company = new Company();
        }

        [Test]
        public void Test_CompanyGiveSalaryToAllEmployees()
        {
            var employee1 = new Employee() { Salary = 100 };
            var employee2 = new Employee() { Salary = 1000 };
            company.Add(employee1);
            company.Add(employee2);

            company.GiveSalary();

            Assert.AreEqual(100, employee1.TakenSalary);
            Assert.AreEqual(1000, employee2.TakenSalary);
        }

        [Test]
        public void Test_CompanyRaiseYearlyIncreasesSalaryCorrectly()
        {
            var employee1 = new Employee() { Salary = 100 };
            var employee2 = new Employee() { Salary = 1000 };
            company.Add(employee1);
            company.Add(employee2);

            company.RaiseSalaryYearly(20);

            Assert.AreEqual(120, employee1.Salary);
            Assert.AreEqual(1200, employee2.Salary);
        }
    }
}