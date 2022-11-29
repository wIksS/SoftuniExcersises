using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PrototypePattern
{
    public class Dice : ICloneable
    {
        public Dice(int id)
        {
            Id = id;
            Console.WriteLine("Initalizing");
        }
        public Side Side { get; set; }

        public int Id { get; set; }

        public object Clone()
        {
            //Deep copy
            return DeepCloner.DeepClone(this);
            //return new Dice(Id)
            //{
            //    Side = new Side()
            //    {
            //        Number = Side.Number,
            //        Times = Side.Times
            //    }
            //};
        }

        //public object Clone()
        //{
        //    //Shallow copy
        //    return MemberwiseClone();
        //}
    }
}
