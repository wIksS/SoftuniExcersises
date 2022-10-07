using System;
using System.IO;

namespace ReadFromWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader=null;
            try
            {
                 reader = new StreamReader("../../../word.docx");
                Console.WriteLine(reader.ReadLine());
                int num = 0;
                Console.WriteLine(num / 0);
            }
            catch (Exception ex)
            {
            }
            finally 
            {
                reader.Close();

            }



            Console.ReadLine();

            //using (StreamReader reader = new StreamReader("../../../word.docx"))
            //{
            //    for (int i = 0; i < 50; i++)
            //    {
            //        Console.WriteLine(reader.ReadLine());
            //    }
            //}
        }
    }
}
