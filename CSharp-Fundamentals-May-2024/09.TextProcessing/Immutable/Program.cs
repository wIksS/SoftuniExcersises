
string text2 = "Hello" + "," + "world!"; 
string text = "12";
//text[0] = '5';

//text += "34";
text = ConcatenateString(text, "34");

char[] textAsArray = new char[2] { '1', '2' };

textAsArray = Concatenate(textAsArray, new char[] { '3', '4' });

Console.WriteLine(text[0]);
Console.WriteLine(textAsArray[0]);


char[] Concatenate(char[] left, char[] right)
{
    char[] newArray = new char[left.Length + right.Length];
    int index = 0;

    for (int i = 0; i < left.Length; i++)
    {
        newArray[index++] = left[i];
    }

    for (int i = 0; i < right.Length; i++)
    {
        newArray[index++] = right[i];
    }

    return newArray;
}

string ConcatenateString(string left, string right)
{
    char[] concatenated = Concatenate(left.ToCharArray(), right.ToCharArray());
    string result = new string(concatenated);
    return result;
}