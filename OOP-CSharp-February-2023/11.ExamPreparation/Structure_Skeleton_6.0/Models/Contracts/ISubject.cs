namespace UniversityCompetition.Models.Contracts
{
    public interface ISubject
    {
        public int Id { get; }

        public string Name { get; }

        public double Rate { get; }
    }
}
