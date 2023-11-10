using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class RandomList : List<string>
    {
        private Random random = new Random();
        public string RandomString()
        {
            return this[random.Next(0, this.Count)];
        }
    }
}
