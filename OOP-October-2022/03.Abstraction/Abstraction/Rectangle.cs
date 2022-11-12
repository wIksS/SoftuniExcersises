using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Rectangle : BaseShape
    {
        private int row, col, width, height;
        public Rectangle(IDrawer drawer, int row, int col, int width, int height) : base(drawer)
        {
            this.row = row;
            this.col = col;
            this.width = width;
            this.height = height;
        }

        public override void Draw()
        {
            int x = row;
            int y = col;

            char Edge = '#';
            string Message = "Hello";
            int LastIndex = 0;

            drawer.WriteAtPosition(y, x, "");
            for (int h_i = 0; h_i <= height; h_i++)
            {
                if (LastIndex != -1)
                {
                    int seaindex = (LastIndex + (width - 1));
                    if (seaindex >= Message.Length - 1)
                        seaindex = Message.Length - 1;
                    int newIndex = Message.LastIndexOf(' ', seaindex);
                    if (newIndex == -1)
                        newIndex = Message.Length - 1;
                    string substr = Message.Substring(LastIndex, newIndex - LastIndex);
                    LastIndex = newIndex;
                    drawer.WriteAtPosition(x + 1, y + h_i, "");

                    drawer.Write(substr);
                }
                for (int w_i = 0; w_i <= width; w_i++)
                {

                    if (h_i % height == 0 || w_i % width == 0)
                    {
                        drawer.WriteAtPosition(y + h_i, x + w_i, "");
                        drawer.Write(Edge.ToString());
                    }


                }

            }
        }
    }
}
