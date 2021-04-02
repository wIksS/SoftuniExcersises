namespace Bakery.Core.Contracts
{
    public interface IController
    {
        public string AddFood(string type, string name, decimal price);

        public string AddDrink(string type, string name, int portion, string brand);

        public string AddTable(string type, int tableNumber, int capacity);

        public string ReserveTable(int numberOfPeople);

        public string OrderFood(int tableNumber, string foodName);

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand);

        public string LeaveTable(int tableNumber);

        public string GetFreeTablesInfo();

        public string GetTotalIncome();
    }
}
