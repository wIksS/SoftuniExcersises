using System.Collections.Generic;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public interface IBag
    {
        int Capacity { get; set; }

        int Load { get; }

        IReadOnlyCollection<Item> Items { get; }

        void AddItem(Item item);

        Item GetItem(string name);
    }
}
