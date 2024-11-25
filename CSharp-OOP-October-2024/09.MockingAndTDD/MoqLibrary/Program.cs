
using Moq;

Mock<IPromotion> mockPromotion = new Mock<IPromotion>();

mockPromotion
    .Setup(m => m.GetPromotionToday())
    .Returns(42)
    .Callback(() =>
    {
        Console.WriteLine("Fake promotion is called");
    });

IPromotion promotion = mockPromotion.Object;

Store store = new Store(promotion);
store.PrintPromotion();

//public class FakePromotion : IPromotion
//{
//    public int GetPromotionToday()
//    {
//        Console.WriteLine("Fake promotion is called!");
//        return 42;
//    }
//}

class Store
{
    IPromotion promotion;

    public Store(IPromotion promotion)
    {
        this.promotion = promotion;
    }

    public void PrintPromotion()
    {
        Console.WriteLine($"Promotion today -> {promotion.GetPromotionToday()}");
    }
}


public interface IPromotion
{
    int GetPromotionToday();
}

