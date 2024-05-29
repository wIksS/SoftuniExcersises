

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string arrayAsString = String.Join("|||", array);

int[] splitted = arrayAsString.Split("|||").Select(int.Parse).ToArray();


Console.WriteLine(arrayAsString);