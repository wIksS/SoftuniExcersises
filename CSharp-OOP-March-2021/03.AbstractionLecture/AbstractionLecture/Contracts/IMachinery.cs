using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLecture.Contracts
{
    public interface IMachinery
    {
        void ListAllMachineries();

        List<string> Machineries { get; set; }
    }
}
