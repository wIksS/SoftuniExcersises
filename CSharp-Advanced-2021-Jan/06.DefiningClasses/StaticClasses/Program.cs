using Geometry;
using System;
namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftuniMaths.Something = 55;

            SoftuniMaths maths = new SoftuniMaths();

            maths.PI = 3;
            maths.Multiply(5, 6); 
            
            SoftuniMaths maths2 = new SoftuniMaths();

            maths.PI = 333;
            maths.Multiply(5, 6);


            SoftuniMaths.Add(5, 6);
       
        }
    }
}
