namespace _01.Loader.Models
{
    using _01.Loader.Interfaces;
    using System;
    using System.Collections.Generic;

    public abstract class BaseEntity : IEntity
    {
        private int? _parentId;

        public BaseEntity(int id, int? parentId)
        {
            this.Id = id;
            this.ParentId = parentId;
            this.Children = new List<IEntity>();
        }

        public int Id { get; set; }
        public int? ParentId
        {
            get
            {
                return this._parentId;
            }
            set
            {
                this._parentId = value == null ? 0 : value;
            }
        }

        public BaseEntityStatus Status { get; set; }

        public List<IEntity> Children { get; set; }

        public void AddChild(IEntity child)
        {
            this.Children.Add(child);
        }

        public int CompareTo(object obj)
        {
            var current = (IEntity)obj;

            return current.Id - this.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is IEntity)
            {
                var entity = (IEntity)obj;
                return entity.Id == this.Id;
            }

            return false;
        }
    }
}
