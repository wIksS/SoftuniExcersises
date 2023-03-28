namespace UniversityCompetition.Models.Contracts
{
    using System.Collections.Generic;
    public interface IStudent
    {
        public int Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public IReadOnlyCollection<int> CoveredExams { get; }

        public IUniversity University { get; }

        public void CoverExam(ISubject subject);

        public void JoinUniversity(IUniversity university);
    }
}
