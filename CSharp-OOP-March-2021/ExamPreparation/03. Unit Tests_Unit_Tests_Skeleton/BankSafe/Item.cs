using System;
using System.Collections.Generic;
using System.Text;

namespace BankSafe
{
    public class Item
    {
        private string owner;
        private string itemId;

        public Item(string owner, string itemId)
        {
            this.Owner = owner;
            this.ItemId = itemId;
        }

        public string Owner
        {
            get => this.owner;
            private set => this.owner = value;
        }

        public string ItemId
        {
            get => this.itemId;
            private set => this.itemId = value;
        }
    }
}

