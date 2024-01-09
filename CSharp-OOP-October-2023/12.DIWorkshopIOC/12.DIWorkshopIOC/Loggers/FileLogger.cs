using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DIWorkshopIOC.Loggers
{
    class FileLogger : ILogger
    {

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter("../../../logs.txt", true))
            {
                writer.WriteLine($"{DateTime.Now}:{message}");
            }
        }
    }
}
