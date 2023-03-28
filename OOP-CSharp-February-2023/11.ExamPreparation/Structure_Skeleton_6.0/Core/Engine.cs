namespace UniversityCompetition.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using UniversityCompetition.Core.Contracts;
    using UniversityCompetition.IO;
    using UniversityCompetition.IO.Contracts;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IController controller;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new TextWriter();
            this.controller = new Controller();
        }

        public void Run()
        {
            while (true)
            {
                string[] input = reader.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }
                try
                {
                    string result = string.Empty;

                    if (input[0] == "AddSubject")
                    {
                        string subjectName = input[1];
                        string category = input[2];

                        result = controller.AddSubject(subjectName, category);
                    }
                    else if (input[0] == "AddUniversity")
                    {
                        string universityName = input[1];
                        string category = input[2];
                        int capacity = int.Parse(input[3]);
                        List<string> requiredSubjects = input[4].Split(",").ToList();

                        result = controller.AddUniversity(universityName, category, capacity, requiredSubjects);
                    }
                    else if (input[0] == "AddStudent")
                    {
                        string firstName = input[1];
                        string lastName = input[2];

                        result = controller.AddStudent(firstName, lastName);
                    }
                    else if (input[0] == "TakeExam")
                    {
                        int studentId = int.Parse(input[1]);
                        int subjectId = int.Parse(input[2]);

                        result = controller.TakeExam(studentId, subjectId);
                    }
                    else if (input[0] == "ApplyToUniversity")
                    {
                        string studentName = input[1] + " " + input[2];
                        string universityName = input[3];

                        result = controller.ApplyToUniversity(studentName, universityName);
                    }
                    else if (input[0] == "UniversityReport")
                    {
                        int universityId = int.Parse(input[1]);

                        result = controller.UniversityReport(universityId);
                    }                    

                    writer.WriteLine(result);
                }
                catch (ArgumentException ex)
                {
                    throw ex;
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
