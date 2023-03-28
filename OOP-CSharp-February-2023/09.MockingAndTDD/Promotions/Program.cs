
using Promotions;

PromotionService promotionService = new PromotionService();
Console.WriteLine($"Discount today is: {promotionService.GetPromotionPercentage(DateTime.Now)}%");
