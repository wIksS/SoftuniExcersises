// See 

string[] array1 = ["1", "2", "3", "Hey"];
string[] array2 = ["4", "5", "6"];

string[] spreadArray = ["First", ..array1,"Between 1 and 2 arrays", ..array2];

//string[] spreadArray2 = ["First", "1", "2", "3", "Hey"];

Console.WriteLine(String.Join(" ", spreadArray));



