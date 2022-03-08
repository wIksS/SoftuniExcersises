using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which file do you want to read from?");

            string path = Console.ReadLine();

            try
            {

                using (StreamReader reader = new StreamReader(path))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException ex)
            {
                try
                {
                    Console.WriteLine("File does not exist");
                    Console.WriteLine("Reading from default");
                    using (StreamReader reader = new StreamReader("../../../test"))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
                catch (FileNotFoundException outerException)
                {

                    throw new ArgumentException("default pytq go nqma", ex);
                }
            }

        }
    }
}
