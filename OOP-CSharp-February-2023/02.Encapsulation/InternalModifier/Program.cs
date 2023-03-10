

using AccessModifiers;
using CustomRandomList;

PublicStudent x;
Student student = new Student();
student.publicField = 5;
//student.internalField = 5;

RandomList list = new RandomList();

list.Add("1");
list.Add("2");
list.Add("3");
list.Add("4");

Console.WriteLine(list.RandomString());