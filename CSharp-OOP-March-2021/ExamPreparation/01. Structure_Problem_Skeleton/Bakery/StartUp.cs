namespace Bakery
{
    using Bakery.Core;
    using Bakery.Models.BakedFoods;
    using Bakery.Models.Tables;
    using Bakery.Utilities.Enums;
    using System;
    using System.Globalization;
    using System.Threading;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            //string x = Environment.NewLine;
            //System.Console.WriteLine(TableType.InsideTable.ToString());
            //InsideTable table = new InsideTable(5, 45);

            //Bread bread = new Bread("lebec", 5);
            //table.OrderFood(bread);

            //System.Console.WriteLine(table.GetFreeTableInfo());
            //System.Console.WriteLine(table.GetBill());
            //Don't forget to comment out the commented code lines in the Engine class!
            var engine = new Engine();

            engine.Run();
        }
    }
}
