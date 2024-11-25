using AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoraunt;

namespace AccessModifiersAnother
{
    internal class University
    {
        private Person person;

        public University()
        {
            //Chef chef = new Chef();
            Kitchen kitchen = new Kitchen();

            Waiter waiter = new Waiter(kitchen);
            
        }
    }
}
