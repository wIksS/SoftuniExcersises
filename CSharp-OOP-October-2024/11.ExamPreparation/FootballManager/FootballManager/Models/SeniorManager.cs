using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class SeniorManager : Manager
    {
        public SeniorManager(string name) : base(name, 30)
        {
        }

        public override void RankingUpdate(double updateValue)
        {
            base.UpdateRanking(updateValue);
        }
    }
}
