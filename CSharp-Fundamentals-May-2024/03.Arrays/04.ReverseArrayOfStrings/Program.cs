

string[] array= Console.ReadLine().Split();

for (int i = 0; i < array.Length/2; i++)
{
    string temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}



Console.WriteLine(string.Join(" ", array));