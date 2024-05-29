

using Moq;

Mock<IPromotionStrategy> mockPromotion = new Mock<IPromotionStrategy>();

mockPromotion.Setup(p => p.GetPromotion(It.Is<decimal>(p => p > 0)))
    .Returns(20)
    .Callback<decimal>(p =>
    {
        global::System.Console.WriteLine($"GetPromotion with a positive {p} number called");
    });

mockPromotion.Setup(p => p.GetPromotion(It.IsInRange<decimal>(0,1000, Moq.Range.Inclusive))).Returns(53);

mockPromotion.Setup(p => p.GetPromotion(44343)).Returns(-100);

mockPromotion.Setup(p => p.GetDate())
    .Returns(DateTime.UtcNow);

mockPromotion.Setup(promotion => promotion.GetPromotion(It.Is<decimal>(n => n <= 0)))
    .Throws<ArgumentException>(() =>
    {
        throw new ArgumentException("Custom message");
    });

Console.WriteLine(mockPromotion.Object.GetPromotion(-5));


Console.WriteLine(mockPromotion.Object.GetPromotion(1001));

Console.WriteLine(mockPromotion.Object.GetDate());

IPromotionStrategy promotion = mockPromotion.Object;

UsePromotion(promotion);

void UsePromotion(IPromotionStrategy promotionStrategy)
{
    Console.WriteLine(promotion.GetPromotion(100));
}

public interface IPromotionStrategy
{
    public decimal GetPromotion(decimal price);

    public DateTime GetDate();

}

//class FakePromotion : IPromotionStrategy
//{
//    public decimal GetPromotion(decimal price)
//    {
//        return 20;
//    }
//}
