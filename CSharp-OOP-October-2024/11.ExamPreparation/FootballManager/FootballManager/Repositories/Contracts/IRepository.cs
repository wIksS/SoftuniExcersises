namespace FootballManager.Repositories.Contracts
{
    public interface IRepository<T> where T : class
    {
        public IReadOnlyCollection<T> Models { get; }

        public int Capacity { get; }

        void Add(T model);

        bool Remove(string name);

        bool Exists(string name);

        T Get(string name);
    }
}
