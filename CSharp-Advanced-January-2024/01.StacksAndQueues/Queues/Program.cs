

//Queue<string> tickets = new Queue<string>();

//tickets.Enqueue("Porychkata mi e greshna :(");
//tickets.Enqueue("Porychkata mi se bavi :(");
//tickets.Enqueue("Porychkata mi q nqma :(");

////Console.WriteLine(tickets.Dequeue());
////Console.WriteLine(tickets.Dequeue());

//while (tickets.Count != 0)
//{
//    string element = tickets.Dequeue();

//    Console.WriteLine(element);
//}



Stack<string> tickets = new Stack<string>();

tickets.Push("1. Porychkata mi e greshna :(");
tickets.Push("2. Porychkata mi se bavi :(");
tickets.Push("3. Porychkata mi q nqma :(");


while (tickets.Count != 0)
{
    string element = tickets.Pop();

    Console.WriteLine(element);
}