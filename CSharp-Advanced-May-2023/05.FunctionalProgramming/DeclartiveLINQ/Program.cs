
// filter only even numbers and print sum

List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// declarative

int sum = list.Where(x => x % 2 == 0).Sum();

//imperative

List<int> evenNumbers = new List<int>();

for (int i = 0; i < list.Count; i++)
{
    if (list[i] % 2 == 0)
    {
        evenNumbers.Add(list[i]);
    }
}

sum = 0;
for (int i = 0; i < list.Count; i++)
{
    sum += list[i];
}

Console.WriteLine(sum);