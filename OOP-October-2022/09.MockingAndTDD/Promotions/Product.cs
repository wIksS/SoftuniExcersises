namespace Promotions
{
    public class Product
    {
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price{ get; set; }

        public override string ToString()
        {
            return $"Id: {Id} -- {Name} : {Price}";
        }
    }
}