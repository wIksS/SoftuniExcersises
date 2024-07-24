
int[] array = new int[] { 1, 2, 3, 4, -1, -5, 0, 50 };

IEnumerable<int> even = array.Where(x => x % 2 == 0);


string[] arrayAsString = array.Select(n => n * 50).Select(n => n.ToString() + "---").ToArray();

Console.WriteLine(String.Join(" ", array));