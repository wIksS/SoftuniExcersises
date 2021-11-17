using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ImotHacker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> priceByLocation = new Dictionary<string, List<int>>();
            Dictionary<string, List<int>> priceByRooms = new Dictionary<string, List<int>>();
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 25; i++)
            {
                string htmlCode = "";
                WebClient client = new WebClient { Encoding = Encoding.UTF8 };
                byte[] reply = client.DownloadData($"https://www.imot.bg/pcgi/imot.cgi?act=3&slink=7ckhmq&f1={i + 1}");

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding encoding1251 = Encoding.GetEncoding("windows-1251");
                var convertedBytes = Encoding.Convert(encoding1251, Encoding.UTF8, reply);
                htmlCode = Encoding.UTF8.GetString(convertedBytes);

                Regex regex = new Regex(@"<div class=""price""><im.*?>(.*?)<a.*?<a.*?>(.*?)<.*?<a.*?>(.*?)<|<div class=""price"">(.*?)<a.*?<a.*?>(.*?)<.*?<a.*?>(.*?)<", RegexOptions.Singleline);

                var matches = regex.Matches(htmlCode);
                foreach (Match match in matches)
                {
                    try
                    {
                        string room = "";
                        string location = "";
                        int price = 0;
                        if (String.IsNullOrEmpty(match.Groups[1].Value))
                        {
                            var priceTruncated = Regex.Match(match.Groups[4].Value, @"[0-9]+ ?[0-9]*").Value;
                            priceTruncated = Regex.Replace(priceTruncated, @" ", "");
                            price = int.Parse(priceTruncated);
                            room = match.Groups[5].Value;
                            location = match.Groups[6].Value;
                            //Console.WriteLine(match.Groups[4]);
                            //Console.WriteLine(match.Groups[5]);
                            //Console.WriteLine(match.Groups[6]);
                        }
                        else
                        {
                            var priceTruncated = Regex.Match(match.Groups[1].Value, @"[0-9]+ ?[0-9]*").Value;
                            priceTruncated = Regex.Replace(priceTruncated, @" ", "");
                            price = int.Parse(priceTruncated); room = match.Groups[2].Value;
                            location = match.Groups[3].Value;
                            //Console.WriteLine(match.Groups[1]);
                            //Console.WriteLine(match.Groups[2]);
                            //Console.WriteLine(match.Groups[3]);
                        }

                        if (!priceByRooms.ContainsKey(room))
                        {
                            priceByRooms.Add(room, new List<int>());
                        }

                        if (!priceByLocation.ContainsKey(location))
                        {
                          //  Console.WriteLine(location + " Added");
                            priceByLocation.Add(location, new List<int>());
                        }

                        priceByLocation[location].Add(price);
                        priceByRooms[room].Add(price);
                    }
                    catch (Exception e)
                    {

                    }
                }
            }

            foreach (var location in priceByLocation)
            {
                Console.WriteLine($"{location.Key} -> {(int)location.Value.Average()}");
            }
            foreach (var room in priceByRooms)
            {
                Console.WriteLine($"{room.Key} -> {(int)room.Value.Average()}");
            }
        }
    }
}
