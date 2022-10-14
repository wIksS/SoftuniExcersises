using System;
using System.Collections.Generic;

namespace MultipleGenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();

            GenericDictionary<int, string, int, int, int, int, int> genericDictionary = new GenericDictionary<int, string, int, int, int, int, int>();
        }

        public class GenericDictionary<TKey, TValue, T1, T2, T3, T4, T5>
        {
            private TKey[] keys;
            private TValue[] values;

            public TKey AddKey(TKey element)
            {
                return keys[0];
            }

            public TValue AddValue(TValue element)
            {
                return values[0];
            }
        }
    }
}
