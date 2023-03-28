using NUnit.Framework;

namespace Companies.Tests
{
    // Company
    // Employee
    // Employees that are over achievers should be rewarded with 200% increase
    // Non over achievers should be rewarded with 0 % increase
    // Under achievers should be rewarded with 0 % increase -> go under achievers list

    public class CompanyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SalaryOfOverAchieversIsIncreasedBy200Percent()
        {
            Company company =new Company();
            Employee employee = new Employee("Dimitrichko", Score.OverAchiever, 2000m);
            
            company.AddEmployee(employee);

            company.IncreaseSalary();

            Assert.AreEqual(6000, employee.Salary);
        }
        [Test]
        public void SalaryOfNonAchieversIsIncreasedBy0Percent()
        {
            Company company = new Company();
            Employee employee = new Employee("Dimitrichko", Score.NonAchiever, 2000m);

            company.AddEmployee(employee);

            company.IncreaseSalary();

            Assert.AreEqual(2000, employee.Salary);
        }

        [Test]
        public void SalaryOfUnderAchieversIsIncreasedBy0PercentAndAreAddedToList()
        {
            Company company = new Company();
            Employee employee = new Employee("Dimitrichko", Score.UnderAchiever, 2000m);

            company.AddEmployee(employee);

            company.IncreaseSalary();

            Assert.AreEqual(2000, employee.Salary);

            Assert.AreEqual(1, company.UnderAchievers.Count);
        }
    }
}