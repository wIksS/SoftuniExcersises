namespace _01.Loader
{
    using _01.Loader.Interfaces;
    using _01.Loader.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Loader : IBuffer
    {
        private List<IEntity> entities;

        public Loader()
        {
            entities = new List<IEntity>();
        }

        public int EntitiesCount => entities.Count;


        // O(1)
        public void Add(IEntity entity)
        {
            entities.Add(entity);
        }

        // O(n)
        public void Clear()
        {
            entities.Clear();
        }

        // O(1) O(logn) 
        //O(n)
        public bool Contains(IEntity entity)
        {
            return entities.Contains(entity);
        }

        // O(1) O(logn) 
        //O(n)
        public IEntity Extract(int id)
        {
            IEntity entity = FindById(id);
            if (entity != null)
            {
                entities.Remove(entity);
            }

            return entity;
        }

        // O(1) O(logn) O(n)
        public IEntity Find(IEntity entity)
        {
            return FindByEntity(entity);
        }

        // O(n)
        public List<IEntity> GetAll()
        {
            return new List<IEntity>(entities);
        }

        // O(1)
        public IEnumerator<IEntity> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        // O(n) O(logn)
        public void RemoveSold()
        {
            List<IEntity> withoutSold = new List<IEntity>();
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Status != BaseEntityStatus.Sold)
                {
                    withoutSold.Add(entities[i]);
                }
            }

            entities = withoutSold;
        }

        // O(n) O(logn) O(1)
        public void Replace(IEntity oldEntity, IEntity newEntity)
        {
            int oldIndex = entities.IndexOf(oldEntity);
            CheckValidIndex(oldIndex, "Entity not found");

            entities[oldIndex] = newEntity;
        }

        // O(n)
        public List<IEntity> RetainAllFromTo(BaseEntityStatus lowerBound, BaseEntityStatus upperBound)
        {
            List<IEntity> inBounds = new List<IEntity>();
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Status >=  lowerBound && entities[i].Status <= upperBound)
                {
                    inBounds.Add(entities[i]);
                }
            }

            return inBounds;
        }

        // O(n) O(logn)
        public void Swap(IEntity first, IEntity second)
        {
            int firstEntityIndex = IndexOf(first.Id, 0, entities.Count);//entities.IndexOf(first);//IndexOf(first.Id, 0, entities.Count);
            int secondEntityIndex = IndexOf(second.Id, 0, entities.Count);// entities.IndexOf(second);//IndexOf(second.Id, 0, entities.Count);
            CheckValidIndex(firstEntityIndex, "Entity not found");
            CheckValidIndex(secondEntityIndex, "Entity not found");

            //IEntity temp = entities[firstEntityIndex];
            //entities[firstEntityIndex] = entities[secondEntityIndex];
            //entities[secondEntityIndex] = temp;
        }

        // O(n)
        public IEntity[] ToArray()
        {
            return entities.ToArray();
        }

        // O(n)
        public void UpdateAll(BaseEntityStatus oldStatus, BaseEntityStatus newStatus)
        {
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Status == oldStatus)
                {
                    entities[i].Status = newStatus;
                }
            }
        }

        // O(1)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        private IEntity FindById(int id)
        {
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Id == id)
                {
                    return entities[i];
                }
            }

            return null;
        }

        private IEntity FindByEntity(IEntity entity)
        {
            int index = entities.IndexOf(entity);
            if (index >= 0)
            {
                return entities[index];
            }

            return null;
        }

        private int IndexOf(int searchedId,int start, int end)
        {
            if (start > end)
            {
                return -1;
            }
            if (start == end && end == entities.Count || end == -1)
            {
                return -1;
            }

            var middle = (start + end)/ 2;


            if (entities[middle].Id == searchedId)
            {
                return middle;
            }

            if (entities[middle].Id > searchedId)
            {
                return IndexOf(searchedId, start, middle - 1);
            }
            else
            {
                return IndexOf(searchedId, middle+1, end);
            }
        }

        private void CheckValidIndex(int index, string message)
        {
            if (index < 0)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}
