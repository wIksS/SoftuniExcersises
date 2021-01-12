using System;
using System.Collections.Generic;

namespace StacksQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> books = new Queue<string>();

            books.Enqueue("Pinokio");
            books.Enqueue("War and peace");
            books.Enqueue("Alhimikyt");

            Console.WriteLine(books.Peek());
            Console.WriteLine(books.Peek());

            books.Enqueue("Fermata na jivotnite");

            Console.WriteLine(books.Dequeue());
            Console.WriteLine(books.Dequeue());
            Console.WriteLine(books.Dequeue());

            // books.Push("War and peace");

            // Console.WriteLine(books.Pop());

        }
    }
}