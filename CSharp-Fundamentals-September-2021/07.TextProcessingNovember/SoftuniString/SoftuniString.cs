using System;
using System.Collections.Generic;
using System.Text;

namespace SoftuniString
{
    class SoftuniString
    {
        private int index = 0;
        private char[] array;

        public SoftuniString(int count = 8)
        {
            array = new char[count];
        }

        // Op
        public void Append(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                array[index++] = text[i];
                Resize();
            }
        }

        private void Resize()
        {
            if (index >= array.Length)
            {
               // Console.WriteLine("Resize");

                var newArray = new char[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray;
            }
        }

        public override string ToString()
        {
            return new string(array);
        }
    }
}
