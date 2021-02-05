using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsList
{
    class StringList
    {
        private string[] array = new string[10];
        private int index = 0;

        public void Add(string element)
        {
            array[index] = element;
            index++;
        }

        public string GetAt(int position)
        {
            return array[position];
        }
    }
}
