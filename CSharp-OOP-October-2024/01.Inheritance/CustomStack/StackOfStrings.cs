using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return Count == 0;
        }

        public Stack<string> AddRange(IEnumerable<string> range)
        {
            foreach (var item in range)
            {
                Push(item);
            }

            return this;
        }
    }
}
