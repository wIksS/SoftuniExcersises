
namespace _02.Data.Models
{
    using _02.Data.Interfaces;
    using System;
    using System.Collections.Generic;

    public abstract class BaseEntity : IEntity, IComparable<IEntity>
    {
        private int? _parentId;

        public BaseEntity(int id, int? parentId)
        {
            Id = id;
            ParentId = parentId;
            Children = new List<IEntity>();
        }
        public BaseEntity(IEntity entity)
        {
            Id = entity.Id;
            ParentId = entity.ParentId;
            Status = entity.Status;
            Children = new List<IEntity>(entity.Children);
        }

        public int Id { get; set; }
        public int? ParentId
        {
            get
            {
                return _parentId;
            }
            set
            {
                _parentId = value == null ? 0 : value;
            }
        }

        public BaseEntityStatus Status { get; set; }

        public List<IEntity> Children { get; set; }

        public void AddChild(IEntity child)
        {
            Children.Add(child);
        }

        public int CompareTo(object obj)
        {
            var other = (IEntity)obj;

            return other.Id - Id;
        }

        public int CompareTo(IEntity other)
        {
            return Id - other.Id;
        }
    }
}
