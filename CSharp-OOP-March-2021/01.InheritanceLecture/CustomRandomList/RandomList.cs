using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList<T> : List<T>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public void Add(T el)
        {
            base.Add(el);
            Console.WriteLine($"Added the string {el} and we have custom functionalities");
        }

        public T RandomString()
        {
            if (Count == 0)
            {
                return default;
            }

            return this[random.Next(0, this.Count)];
        }
    }
}
