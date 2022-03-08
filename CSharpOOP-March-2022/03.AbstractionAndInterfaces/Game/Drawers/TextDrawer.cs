using Game.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Game.Drawers
{
    class TextDrawer : IDrawer
    {
        private string path;
        public TextDrawer(string path)
        {
            this.path = path;
        }
        public void Write(string message)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.Write(message);
            }
        }

        public void WriteAt(string message, int x, int y)
        {
            using (StreamWriter writer = new StreamWriter(path,true))
            {
                writer.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            using (StreamWriter writer = new StreamWriter(path,true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
