namespace Bakery.Models.BakedFoods.Contracts
{
    public interface IBakedFood
    {
        string Name { get; }

        int Portion { get; }

        decimal Price { get; }
    }
}
