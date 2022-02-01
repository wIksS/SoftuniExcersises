using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Action2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };

            list.ForEach(x => Console.WriteLine(x));

            //DownloadText("http://softuni.bg", (result) =>
            //{
            //    Console.WriteLine(result);
            //});
        }

        public static void DownloadText(string url, Action<string> callback)
        {
            using (WebClient web1 = new WebClient())
            {
                string data = web1.DownloadString(url);
                callback(data);
            }
        }
    }
}
