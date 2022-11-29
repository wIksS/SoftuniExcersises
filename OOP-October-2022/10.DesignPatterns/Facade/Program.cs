using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account dimitrichko = new Account();
            Account peshkata = new Account();

            IPaymentSystem paymentSystem = new PaymentSystemFacade();

            paymentSystem.MakePayment(dimitrichko, peshkata);
        }
    }
}
