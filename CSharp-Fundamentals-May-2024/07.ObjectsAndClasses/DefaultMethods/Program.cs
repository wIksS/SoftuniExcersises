
Empty empty = new Empty();
Console.WriteLine(empty.ToString());
Console.WriteLine(empty.GetHashCode());
Console.WriteLine(empty.GetType());

Object obj = new object();

Console.WriteLine(obj.ToString());
Console.WriteLine(obj.GetHashCode());
Console.WriteLine(obj.GetType());
Console.WriteLine(obj.Equals(empty));

class Empty
{

}