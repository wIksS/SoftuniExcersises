using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Abstraction.Drawers
{
    public class FileDrawer : IDrawer
    {
        private string path;
        public FileDrawer(string path)
        {
            this.path = path;
            File.Delete(path);
          
        }

        public void Write(string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(text);
            }
        }

        public void WriteAtPosition(int row, int col, string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
