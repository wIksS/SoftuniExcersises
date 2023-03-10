
using DependencyInversion;

Store store = new Store();

Console.WriteLine(store.GetPromotionToday()); 
Console.WriteLine(store.GetPromotionTodayDI(DateTime.Now));

Console.WriteLine(store.GetPromotionTodayDI(DateTime.Now.AddDays(3)));
Console.WriteLine(store.GetPromotionTodayDI(DateTime.Now.AddYears(2)));