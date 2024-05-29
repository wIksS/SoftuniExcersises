using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public class ReefFish : Fish
    {
        public ReefFish(string name, double points) : base(name, points, 30)
        {
        }
    }
}
