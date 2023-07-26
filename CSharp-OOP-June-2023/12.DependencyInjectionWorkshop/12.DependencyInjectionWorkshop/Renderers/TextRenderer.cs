using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop.Renderers
{
    internal class TextRenderer : IRenderer
    {
        private string path = "../../../output.txt";
        public void Write(string s)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(s);
            }
        }

        public void WriteLine(string s)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(s);
            }
        }
    }
}
