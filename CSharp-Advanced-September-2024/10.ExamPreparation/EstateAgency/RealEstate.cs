namespace EstateAgency
{
    public class RealEstate
    {
        public RealEstate(string address, string postalCode, decimal price, double size)
        {
            Address = address;
            PostalCode = postalCode;
            Price = price;
            Size = size;
        }

        public string Address { get; set; }

        public string PostalCode  { get; set; }

        public decimal Price { get; set; }

        public double Size { get; set; }

        public override string ToString()
        {
            return $"Address: {Address}, PostalCode: {PostalCode}, Price: ${Price}, Size: {Size} sq.m."; 
        }
    }
}
