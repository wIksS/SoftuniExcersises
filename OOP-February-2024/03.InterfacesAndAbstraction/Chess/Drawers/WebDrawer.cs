using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Drawers
{
    internal class WebDrawer : IDrawer
    {
        private string path = "../../../chess.html";

        public WebDrawer()
        {
            File.Delete(path);
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write($"<html><body>");
            }
        }

        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write($"<span>{message}</span>");
            }
        }

        public void WriteLine(string message)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"<i><b><h1>{message}</h1></b></i>");
            }
        }
    }
}
