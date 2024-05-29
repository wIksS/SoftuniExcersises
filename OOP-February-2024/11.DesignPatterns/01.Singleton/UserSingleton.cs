using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Singleton
{
    public class UserSingleton
    {
        private static UserSingleton instance;
        private static object lockObj = new object();
        private UserSingleton()
        {
            Console.WriteLine("In constructor");
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


        public string Username { get; set; }

        public string Password { get; set; }
    }
}
