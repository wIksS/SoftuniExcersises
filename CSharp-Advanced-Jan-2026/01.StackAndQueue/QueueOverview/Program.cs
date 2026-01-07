

Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

while (queue.Count > 0)
{
    int current = queue.Dequeue();
    Console.WriteLine(current);
}