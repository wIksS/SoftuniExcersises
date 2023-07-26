using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class UserSingleton
    {
        private static UserSingleton instance;
        private static object lockObject = new object();

        private UserSingleton()
        {
            Console.WriteLine("Creating the first and only Singleton");
        }

        public static UserSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
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

        public string Name { get; set; }

        public string Password { get; set; }

        public void ChangePassword(string newPass)
        {
            Console.WriteLine("Sent a confirmation email");
        }

    }
}
