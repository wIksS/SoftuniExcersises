namespace _04.Polymorphism
{
    public class Accountant
    {
        private List<IPayable> payables;

        public void PaySalaries()
        {
            foreach (var item in payables)
            {
                item.GetSalary();
            }
        }
    }
}