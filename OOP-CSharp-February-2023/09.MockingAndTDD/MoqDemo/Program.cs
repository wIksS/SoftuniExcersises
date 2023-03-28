
using Moq;
using MoqDemo;

Mock<IPromotion> promotionMock = new Mock<IPromotion>();

//Store store = new Store(promotionMock.Object);

promotionMock.Setup(p => p.GetPromotion()).Returns(20);

IPromotion promotionObject = promotionMock.Object;

Console.WriteLine(promotionObject.GetPromotion());














