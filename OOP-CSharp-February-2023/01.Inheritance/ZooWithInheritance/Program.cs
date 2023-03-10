
using ZooWithInheritance;

Lion lion = new Lion();

lion.Mane = 5;
lion.Age = 10;
lion.Name = "Simba";
lion.Room = "Vsichko ogrqno";

lion.LastMeal = DateTime.Now; 

Monkey monkey = new Monkey();   

monkey.LastMeal = DateTime.Now.AddDays(1);


Shark shark = new Shark();

//shark
shark.DangerousLevel = 5;
//fish
shark.WaterSize = 5;
// animal
shark.Name = "Nemo akula";