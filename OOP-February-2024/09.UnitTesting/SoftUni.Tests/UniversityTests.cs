using NUnit.Framework;
using System;

namespace SoftUni.Tests
{
    public class UniversityTests
    {
        private University university;
        private Student student;

        [SetUp]
        public void SetUp()
        {
            university = new University();
            student = new Student()
            {
                Name = "Dimitrichko",
                Age = 21,
                Id = 5
            };
        }

        [TearDown]
        public void CleanUp()
        {
            // runs after every test
        }

        [Test]
        public void RegisterStudent_ShouldAddCorrectly()
        {
            university.RegisterStudent(student);

            Assert.AreEqual(university.Students.Count, 1);
            Assert.IsTrue(university.FindStudent(5) == student);

        }

        [Test]
        public void RegisterStudent_YoungerThan12_ShouldThrowAnError()
        {
            student.Age = 5;

            Assert.Throws<ArgumentException>(() =>
            {
                university.RegisterStudent(student);
            });
        }

        [Test]
        public void RegisterStudent_WithNegativeAge_ShouldThrowAnError()
        {
            student.Age = -12;

            Assert.Throws<ArgumentException>(() =>
            {
                university.RegisterStudent(student);
            });
        }
    }
}