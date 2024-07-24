
using System.Linq;
// lambda expression = anonymous function

// anonymous function  = lambda expression
List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//list = list.Where(IsOdd).ToList();
//var oddList = list.Where(number => number % 2 == 1).ToList();

list = list.Where((int number, int index) =>
{
    Console.WriteLine($"Checking number: {number} on index {index}");
    return number % 2 == 1;
}).ToList();


Console.WriteLine(String.Join(",", list));


bool IsOdd(int number, int index)
{
    Console.WriteLine($"Checking number: {number} on index {index}");
    return number % 2 == 1;
}