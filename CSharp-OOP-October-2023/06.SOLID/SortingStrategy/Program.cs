// implenet sorting
// support many different sorting strategies


using SortingStrategy;
using SortingStrategy.SortingStrategies;
using System.Reflection;

Console.WriteLine("How do you want to sort?");

string type = Console.ReadLine();

List<Type> strategies = Assembly.GetExecutingAssembly()
    .GetTypes().Where(t => typeof(ISortingStrategy).IsAssignableFrom(t)).ToList();

Type strategyType = strategies.Where(s => s.Name.ToLower().Contains(type.ToLower())).First();

ISortingStrategy strategy = (ISortingStrategy)Activator.CreateInstance(strategyType);

Sorter sorter = new Sorter(strategy, new List<int> { 5,1,3,7,21});

sorter.Sort();









//if (type == "bubble")
//{
//    strategy = new BubbleStrategy();
//}
//else if (type == "selection")
//{
//    strategy = new SelectionStrategy();
//}
//else if (type == "merge")
//{
//    strategy = new MergeStrategy();
//}
//else if (type == "bogo")
//{
//    strategy = new BogoStrategy();
//}