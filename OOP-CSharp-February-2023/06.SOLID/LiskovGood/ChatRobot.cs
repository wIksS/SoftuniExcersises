using LiskovGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstituonPrinciple
{
    class ChatRobot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working all day and night");
        }
    }
}
