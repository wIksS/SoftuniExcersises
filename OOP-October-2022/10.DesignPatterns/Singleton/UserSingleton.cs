using DeviceId;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class UserSingleton
    {
        private static UserSingleton instance;
        private static object lockObj = new object();
        private UserSingleton()
        {
            Console.WriteLine("Initializing");
            DeviceId = new DeviceIdBuilder()
                        .AddMachineName()
                        .AddOsVersion()
                        .ToString();
        }

        public static UserSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new UserSingleton();
                        }
                    }
                }

                return instance;
            }
        }

        public string DeviceId { get; set; }

        public string Name { get; set; }
    }
}
