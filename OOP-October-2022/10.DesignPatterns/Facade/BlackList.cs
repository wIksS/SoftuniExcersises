using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class BlackList
    {
        public BlackList()
        {
            BlackListedAccounts = new List<Account>();
        }

        public List<Account> BlackListedAccounts { get; set; }

        public bool CheckIfAccountisBlackListed(Account acc)
        {
            // if acc is in list return true;

            return false;
        }

    }
}
