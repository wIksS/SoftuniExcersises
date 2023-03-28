namespace UniversityCompetition.Repositories.Contracts
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> Models { get; }

        void AddModel(T model);

        T FindById(int id);

        T FindByName(string name);
    }
}
