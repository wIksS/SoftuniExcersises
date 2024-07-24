
int[] numbers = new int[] {5,6,1,3,5,2};

Console.WriteLine(Array.IndexOf(numbers, 1));


string text = "this is a very big string";
char[] chArray = text.ToCharArray();
int index = text.LastIndexOf("i", 21);

Console.WriteLine(text);
Console.WriteLine($"i->{index}");