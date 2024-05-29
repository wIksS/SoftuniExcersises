using DependencyInversion;

var p = new Promotion();
p.Date = DateTime.Now;  

p.Date = p.Date.AddDays(1); 
Console.WriteLine(p.GetPromotion(DateTime.Now));
Console.WriteLine(p.GetPromotion(new DateTime(2024,3,4)));