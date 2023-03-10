using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface ICar
    {
        void Accelerate();
        void Stop();

        void StartEngine();
        void StopEngine();

        void ServiceCheck();

        void RePaint();
    }

    //interface IMover
    //{
    //    void Accelerate();
    //    void Stop();
    //}



    //interface IServicable
    //{
    //    void ServiceCheck();
    //}
    //interface IPaintable
    //{
    //    void RePaint();
    //}
}
