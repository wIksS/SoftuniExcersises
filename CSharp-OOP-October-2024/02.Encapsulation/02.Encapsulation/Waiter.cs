using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt
{
    public class Waiter
    {
        private Kitchen kitchen;

        public Waiter(Kitchen kitchen)
        {
            Chef chef;
            this.kitchen = kitchen;
        }

        public void OrderFood(int table, MenuItem menuItem)
        {
            kitchen.OrderFood(menuItem, this);
            AddItemToCheck(table, menuItem);
            
            //bad encapsulation
            //if (kitchen.onions < 100000)
            //{
            //    kitchen.Order("onions");
            //}
        }

        private void AddItemToCheck(int table, MenuItem menuItem)
        {
            throw new NotImplementedException();
        }
    }
}
