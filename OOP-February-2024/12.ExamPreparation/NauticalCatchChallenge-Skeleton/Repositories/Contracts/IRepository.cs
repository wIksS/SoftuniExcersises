namespace NauticalCatchChallenge.Repositories.Contracts
{
    public interface IRepository<T>
    {
        IReadOnlyCollection<T> Models { get; }

        void AddModel(T model);

        T GetModel(string name);
    }
}
