namespace _01.Loader.Interfaces
{
    using _01.Loader.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IEntity : IComparable
    {
        int Id { get; set; }

        int? ParentId { get; set; }

        BaseEntityStatus Status { get; set; }

        List<IEntity> Children { get; }

        void AddChild(IEntity child);
    }
}
