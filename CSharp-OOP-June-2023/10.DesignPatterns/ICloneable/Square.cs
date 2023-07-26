using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableNS
{
    internal class Square : ICloneable
    {
        public int Width { get; set; }

        public Page Page { get; set; }

        public object Clone()
        {
            // shallow copy
            //return this.MemberwiseClone();

            // deep copy
            return JsonConvert.DeserializeObject<Square>(JsonConvert.SerializeObject(this));
        }
    }
}
