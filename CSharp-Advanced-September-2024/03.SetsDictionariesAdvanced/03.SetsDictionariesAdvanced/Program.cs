
KeyValuePair<string, int> studentGrade = new KeyValuePair<string, int>("Goshko", 4);

Console.WriteLine(studentGrade.Key);
Console.WriteLine(studentGrade.Value);

Dictionary<string, int> studentGrades = new Dictionary<string, int>();

studentGrades.Add("Goshko", 3);

foreach (KeyValuePair<string,int> studentGradePair in studentGrades)
{
    Console.WriteLine(studentGradePair.Key + " " + studentGradePair.Value);
}