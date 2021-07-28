using System;
using System.Text.RegularExpressions;

namespace Html
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"<b>Regular Expressions</b> are cool!
<p>I am a paragraph</p> … some text after
Hello, <div>I am a<code>DIV</code></div>!
<span>Hello, I am Span</span>
<a href=""https://softuni.bg/"">SoftUni</a>
            ";

            Regex regex = new Regex(@"<(.*)>(.*)<\/\1>");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }

        }
    }
}
