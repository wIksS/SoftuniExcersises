namespace SoftuniDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoftUniList<string> stringList = new SoftUniList<string>();

            stringList.Add("Strings!!!");

           SoftUniList<int> list = new SoftUniList<int>();

            list.Shrink();

            for (int i = 0; i < 1_000_005; i++)
            {
                list.Add(i + 1);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < 1_000_000; i++)
            {
                list.RemoveAt(list.Count-1);
            }

            list.ForEach(i => Console.Write(i + " "));

            //list.Shrink();

            Console.WriteLine();
            
            
            
            
            
            
            
            
            
            
            //CustomQueue queue = new CustomQueue();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Console.WriteLine(queue.Dequeue());

            //Console.WriteLine(queue.Count);

            //queue.ForEach(i => Console.Write(i + " "));

            //queue.Clear();

            return;



            //SoftUniList list = new SoftUniList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //Console.WriteLine(list.Pop());
            //Console.WriteLine(list.Pop());
            //Console.WriteLine(list.Pop());
            //Console.WriteLine(list.Pop());

            // list[0] = 55;

            //Console.WriteLine(list[0]);

            //Console.WriteLine(list[4]);

            //list.ForEach(i => Console.Write(i + " "));
            //SoftUniList stack = new SoftUniList();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //stack.RemoveAt(55);

            //Console.WriteLine(stack.Pop());

            ////List<int> list = new List<int>(4);
            //SoftUniList list = new SoftUniList();
            //int n = 4;
            //for (int i = 1;i <= n; i++)
            //{
            //    list.Add(i);
            //}


            //Console.WriteLine(list.Contains(0));
            //Console.WriteLine(list.Contains(2));
            //list.RemoveAt(1);

            ////Console.WriteLine(list[2]);
            //Console.WriteLine(list.GetAt(1));

            //Console.WriteLine(list[2]);
        }
    }
}
