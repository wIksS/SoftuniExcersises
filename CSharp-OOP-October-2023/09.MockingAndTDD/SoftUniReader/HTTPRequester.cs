using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniReader
{
    internal class HTTPRequester : IHTTPRequester
    {
        public string GetData(string url)
        {
            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            return reader.ReadToEnd();
        }
    }
}
