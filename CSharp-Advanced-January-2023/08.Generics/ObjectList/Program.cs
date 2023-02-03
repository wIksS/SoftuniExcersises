using ObjectLists;

GenericList<int> genericList = new GenericList<int>();

genericList.Add(5);
genericList.Add(6); 
genericList.Add(7);

GenericList<string> stringList = new GenericList<string>();

stringList.Add("5");

ObjectList objectList = new ObjectList();

objectList.Add("6");
objectList.Add(5);

objectList.Add(DateTime.Now);

string secondElement = (string)objectList.GetElement(1);

Console.WriteLine(secondElement);