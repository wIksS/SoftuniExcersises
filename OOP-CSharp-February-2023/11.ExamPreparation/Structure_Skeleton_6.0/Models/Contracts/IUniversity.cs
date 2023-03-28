namespace UniversityCompetition.Models.Contracts
{
    using System.Collections.Generic;

    public interface IUniversity
    {
        public int Id { get; }

        public string Name { get; }

        public string Category { get; }

        public int Capacity { get; }

        public IReadOnlyCollection<int> RequiredSubjects { get; }
    }
}
