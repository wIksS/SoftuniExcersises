

Queue<string> tickets = new Queue<string>();

//Console.WriteLine(tickets[0]);

tickets.Enqueue("Ne mi raboti stream-a");

tickets.Enqueue("Laptopa ne raboti");

tickets.Enqueue("spam");

string ticket = tickets.Dequeue();

Console.WriteLine(ticket);

ticket = tickets.Dequeue();

Console.WriteLine(ticket);
Console.WriteLine(tickets.Count);
Console.WriteLine(tickets.Contains("spam"));

//ticket = tickets.Dequeue();
//ticket = tickets.Dequeue();
//ticket = tickets.Dequeue();
