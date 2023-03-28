using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class MoneyTransferFacade : IMoneyTransfer
    {
        private Bank bank = new Bank();
        private ThreeDSVericitaion verification = new ThreeDSVericitaion();
        private BlackList blackList = new BlackList();

        public void Transfer(string from, string to, decimal amount)
        {           
            Account accountFrom = bank.GetUser(from);
            Account accountTo = bank.GetUser(to);

            if (verification.IsEligble(accountFrom))
            {
                if (!blackList.IsBlackListed(accountFrom))
                {
                    accountFrom.SubtractMoney(200);
                    accountTo.AddMoney(200);
                }
            }
        }
    }
}
