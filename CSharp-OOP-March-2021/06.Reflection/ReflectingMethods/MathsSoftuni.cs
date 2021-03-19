using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectingMethods
{
    /// <summary>
    /// 
    /// </summary>
    class MathsSoftuni
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c = 5)
        {
            return a + b + c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [Obsolete]
        public static int  Multiply(int a, int b)
        {
            return a * b;
        }

        protected int Divide(int a, int b)
        {
            return a / b;
        }

        public virtual int Percentage(int a, int b)
        {
            return a / b * 100;
        }
    }
}
