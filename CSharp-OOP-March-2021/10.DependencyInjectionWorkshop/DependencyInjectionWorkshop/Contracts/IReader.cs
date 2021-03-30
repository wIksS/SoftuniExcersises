using DependencyInjectionWorkshop.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.Contracts
{
    interface IReader
    {
        Position ReadKey();

        string ReadLine();
    }
}
