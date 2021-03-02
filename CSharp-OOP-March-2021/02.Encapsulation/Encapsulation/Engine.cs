using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Engine
    {
        private Oil oil;
        private Turbo turbo;
        private Karter karter;
        private Cilindri cilindri;

        private void StartTurbo()
        {
            turbo.Start();
            // 5 neshta
        }

        private void KarterStart()
        {
            // karter.Start();
            // 5 neshta
        }

        public void Start()
        {
            oil.Stop();
            StartTurbo();
            KarterStart();
            // karter
            // cilindri
            // butalka
            // golfa
        }


        public void Stop()
        {
            oil.Stop();
            turbo.Stop();
            // karter stop
            // cilindri
            // butalka
            // golfa nqma stop
        }

        public void Accelerate()
        {

        }
    }
}
