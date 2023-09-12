
Queue<string> people = new Queue<string> ();

people.Enqueue("Dimitrichko");

people.Enqueue("Goshko");

people.Enqueue("Niki");

people.Enqueue("Dimo");


while (people.Count > 0)
{
    Console.WriteLine($"Next in line: {people.Dequeue()}");
}


Console.WriteLine($"Next in line: {people.Dequeue()}");