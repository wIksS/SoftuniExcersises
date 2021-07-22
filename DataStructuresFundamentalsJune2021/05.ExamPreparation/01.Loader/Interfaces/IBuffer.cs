namespace _01.Loader.Interfaces
{
    using _01.Loader.Models;
    using System.Collections.Generic;

    public interface IBuffer : IEnumerable<IEntity>
    {
        int EntitiesCount { get; }

        void Add(IEntity entity);

        IEntity Extract(int id);

        IEntity Find(IEntity entity);

        bool Contains(IEntity entity);

        void Replace(IEntity oldEntity, IEntity newEntity);

        void Swap(IEntity first, IEntity second);

        void Clear();

        IEntity[] ToArray();

        List<IEntity> RetainAllFromTo(BaseEntityStatus lowerBound, BaseEntityStatus upperBound);

        List<IEntity> GetAll();

        void UpdateAll(BaseEntityStatus oldStatus, BaseEntityStatus newStatus);

        void RemoveSold();
    }
}
