namespace Bakery.Core
{
    using Bakery.Core.Contracts;
    using Bakery.IO;
    using Bakery.IO.Contracts;
    using System;

    public class Engine : IEngine
    {
        private IWriter writer;
        private IReader reader;
        private IController controller;

        public Engine()
        {
            this.writer = new Writer();
            this.reader = new Reader();
            this.controller = new Controller();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] arguments = input.Split();

                string command = arguments[0];

                string result = string.Empty;

                //try
                //{
                    switch (command)
                    {
                        case "AddFood":
                            string type = arguments[1];
                            string name = arguments[2];
                            decimal price = decimal.Parse(arguments[3]);

                            result = controller.AddFood(type, name, price);
                            break;

                        case "AddDrink":
                            string drinktype = arguments[1];
                            string drinkName = arguments[2];
                            int portion = int.Parse(arguments[3]);
                            string brand = arguments[4];

                            result = controller.AddDrink(drinktype, drinkName, portion, brand);
                            break;

                        case "AddTable":
                            string tableType = arguments[1];
                            int tableNumber = int.Parse(arguments[2]);
                            int capacity = int.Parse(arguments[3]);

                            result = controller.AddTable(tableType, tableNumber, capacity);
                            break;

                        case "ReserveTable":
                            int numberOfPeople = int.Parse(arguments[1]);

                            result = controller.ReserveTable(numberOfPeople);
                            break;

                        case "OrderFood":
                            int tableNum = int.Parse(arguments[1]);
                            string foodName = arguments[2];

                            result = controller.OrderFood(tableNum, foodName);
                            break;

                        case "OrderDrink":
                            int tableN = int.Parse(arguments[1]);
                            string drName = arguments[2];
                            string drinkBrand = arguments[3];

                            result = controller.OrderDrink(tableN, drName, drinkBrand);
                            break;

                        case "LeaveTable":
                            int leftTableNum = int.Parse(arguments[1]);

                            result = controller.LeaveTable(leftTableNum);
                            break;

                        case "GetFreeTablesInfo":
                            result = controller.GetFreeTablesInfo();
                            break;

                        case "GetTotalIncome":
                            result = controller.GetTotalIncome();
                            break;
                    }

                    writer.WriteLine(result);
                //}
                //catch (ArgumentNullException ane)
                //{
                //    writer.WriteLine(ane.Message);
                //}
                //catch (ArgumentException ae)
                //{
                //    writer.WriteLine(ae.Message);
                //}
                input = reader.ReadLine();
            }
        }
    }
}