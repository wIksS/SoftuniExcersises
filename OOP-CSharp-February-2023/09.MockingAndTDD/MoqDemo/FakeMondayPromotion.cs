using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo
{
    class FakeMondayPromotion : IPromotion
    {
        public int GetPromotion()
        {
            return 20;
        }
    }
}
