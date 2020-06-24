using System;

namespace _02.RandomStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer randomizer = new StringRandomizer();
            randomizer.Words = Console.ReadLine().Split();
            randomizer.Randomise();
            randomizer.PrintWords();
        }
    }

    public class StringRandomizer
    {
        public string[] Words;

        public void Randomise()
        {
            Random rand = new Random();
            for (int i = 0; i < this.Words.Length; i++)
            {
                int randomPosition = rand.Next(0, this.Words.Length);
                string temp = this.Words[i];
                this.Words[i] = this.Words[randomPosition];
                this.Words[randomPosition] = temp;
            }
        }

        public void PrintWords()
        {
            Console.WriteLine(String.Join(Environment.NewLine, this.Words));
        }
    }
}
