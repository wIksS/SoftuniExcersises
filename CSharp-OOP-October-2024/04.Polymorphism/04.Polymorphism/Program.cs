

using _04.Polymorphism;




IPayable payable = null;

string input =Console.ReadLine();

if (input == "waiter")
{
    payable = new Waiter();
}
else
{
    payable = new Cook();
}

payable.GetSalary();

PaySalary(payable);
if (payable is Cook)
{
    PayFine(payable);
}



void PaySalary(IPayable payable)
{
    payable.GetSalary();
}

void PayFine(IPayable payable)
{
    Console.WriteLine("20% less salary");
}

void Work(IWorker worker)
{
    worker.Work();
}