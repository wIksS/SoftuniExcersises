using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("pesho");
            //text += "test"
            text.Append("test");
            text.Append("test");
            text.AppendLine("test");

            //text +="some string\n"
            text.AppendLine("test123NewLine");
            text.Append("on new line");
            Console.WriteLine(text);

            string textAsString = text.ToString();
            StringBuilder textAsBuilder = new StringBuilder(textAsString);
        }
    }
}
