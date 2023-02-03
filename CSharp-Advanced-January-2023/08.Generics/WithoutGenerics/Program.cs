
object variable = 5;

variable = "pet";

variable = new List<string>();

List<object> intList = new List<object> { 1, 2, 3, 4 };

intList.Add("zashto ima tekst pri string??");
intList.Add(new List<int>());

List<object> stringList = new List<object>() { "edno", "dve", "tri" };

PrintList(intList);
PrintList(stringList);

void PrintList(List<object> list)
{
    Console.WriteLine("--------------------");
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}