namespace UniversityCompetition.Core.Contracts
{
    using System.Collections.Generic;
    public interface IController
    {
        string AddSubject(string subjectName, string subjectType);

        string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects);

        string AddStudent(string firstName, string lastName);

        string TakeExam(int studentId, int subjectId);

        string ApplyToUniversity(string studentName, string universityName);

        string UniversityReport(int universityId);
    }
}
