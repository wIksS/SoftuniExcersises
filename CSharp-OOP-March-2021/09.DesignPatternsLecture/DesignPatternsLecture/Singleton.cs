using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLecture
{
    class Singleton
    {
        private static Singleton instance;
        private static object lockObject = new object();
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }

        public void DoWork()
        {
            Console.WriteLine("Work done only by single instance");
        }
    }
}
