using Moq;
using MoqExample;
using System;

namespace MoqExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mock<IDatabase> mockDb = new Mock<IDatabase>();

            IDatabase db = mockDb.Object;

            ProductsService service = new ProductsService(mockDb.Object);


            Console.WriteLine(db.Count);
            db.Save();

            var result = db.GetAll();
            Console.WriteLine(db.GetAll());

            db.Update(new Product());
        }
    }
}
