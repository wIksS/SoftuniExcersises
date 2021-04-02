namespace Bakery.Models.Drinks.Contracts
{
    public interface IDrink
    {
        string Name { get; }

        int Portion { get; }

        decimal Price { get; }

        string Brand { get; }
    }
}
