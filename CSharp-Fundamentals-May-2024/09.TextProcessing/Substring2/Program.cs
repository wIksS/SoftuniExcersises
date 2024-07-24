

string numbers = "0123456789";

string subString = numbers.Substring(3, 5);

//Console.WriteLine(subString);

//Console.WriteLine(numbers.Substring(3, 5));

//Console.WriteLine(numbers.Substring(1, 4));

//Console.WriteLine(numbers.Substring(3, 1));


string word1 = Console.ReadLine();
string word2 =  Console.ReadLine();

string text = "some very big text that is cool";

int index1 = text.IndexOf(word1);
int index2 = text.IndexOf(word2);

subString = text.Substring(index1, index2 - index1 + word2.Length);

Console.WriteLine(subString);