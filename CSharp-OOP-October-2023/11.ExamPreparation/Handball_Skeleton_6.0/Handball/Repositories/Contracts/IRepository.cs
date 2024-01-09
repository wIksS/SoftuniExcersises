using System.Collections.Generic;

namespace Handball.Repositories.Contracts
{
    //repository pattern
    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> Models { get; }

        void AddModel(T model);
        bool RemoveModel(string name);
        bool ExistsModel(string name);
        T GetModel(string name);
    }
}
