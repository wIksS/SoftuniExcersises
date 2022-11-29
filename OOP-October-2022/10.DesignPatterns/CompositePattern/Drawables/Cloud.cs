using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Drawables
{
    public class Cloud : Shape
    {
        public Cloud(Position pos):base(pos)
        {
            shape = new char[,]
            {
               {  ' ','*','*',' ', },
               {  '*','*','*','*', },
               {  '*','*','*','*', },
               {  ' ','*','*',' ', },
            };
        }
    }
}
