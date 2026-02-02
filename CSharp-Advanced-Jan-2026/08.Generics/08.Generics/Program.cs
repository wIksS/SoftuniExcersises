

using _08.Generics;

int n = int.Parse(Console.ReadLine());

//BoxList<string> list = new BoxList<string>();
BoxList<double> list = new BoxList<double>();

for (int i = 0; i < n; i++)
{
    //Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
    //Box<string> box = new Box<string>(Console.ReadLine());
    Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));

    list.Data.Add(box);
}

Console.WriteLine(
    list.GetBiggerBoxes(
    new Box<double>(double.Parse(Console.ReadLine()))));


//string[] input = Console.ReadLine().Split();
//list.Swap(int.Parse(input[0]), int.Parse(input[1]));

//foreach (var box in list.Data)
//{
//    Console.WriteLine(box);
//}


//Box<int> intBox = new Box<int>(42);

//Console.WriteLine(intBox);

//Box<Box<string>> stringBoxBox = new Box<Box<string>>(stringBox);

//Console.WriteLine(stringBoxBox);