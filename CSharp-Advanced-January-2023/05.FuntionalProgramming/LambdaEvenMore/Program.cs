
//int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
//int[] numbers = Console.ReadLine().Split().Select((string x) => int.Parse(x)).ToArray();
int[] numbers = Console.ReadLine().Split().Select((string x) =>
{
    return int.Parse(x);
})
    .ToArray();

Array.ForEach(numbers, x =>
{
    Console.WriteLine(x);
});

Func<int, bool> lambda = (x) => x % 2 == 0;