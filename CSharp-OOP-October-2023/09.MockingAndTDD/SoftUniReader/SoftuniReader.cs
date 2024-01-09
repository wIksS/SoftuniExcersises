using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniReader
{
    public class SoftuniReader
    {
        private IHTTPRequester http;
        private string[] pages = new string[] { "https://softuni.bg/trainings/4224/csharp-oop-october-2023", "https://softuni.bg/trainings/4224/csharp-oop-october-2022", "https://softuni.bg/trainings/4224/csharp-oop-october-2021" };

        public SoftuniReader(IHTTPRequester http)
        {
            this.http = http;
        }

        public string ReadSoftUniData()
        {
            string result = "";

            foreach (string page in pages)
            {


                result += http.GetData(page) + "\n\n\n\n";
            }

            return result;
        }
    }
}
