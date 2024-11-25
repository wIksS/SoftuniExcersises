using DepencyInjectionConstructor.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjectionConstructor.IO
{
    public class FileWriter : IWriter
    {
        public void Write(string msg)
        {
            using (StreamWriter writer = new StreamWriter("../../../output.txt", true))
            {
                writer.Write(msg);
            }
        }

        public void WriteLine(string msg)
        {
            using (StreamWriter writer = new StreamWriter("../../../output.txt",true))
            {
                writer.WriteLine(msg);
            }
        }
    }
}
