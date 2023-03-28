using System;
using System.Collections.Generic;
using System.Text;

namespace _10.DesignPatterns
{
    // Singleton
    public class User
    {
        private static User instance;
        private User()
        {

            Console.WriteLine("Hello");
        }

        public static User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();  
                }

                return instance;
            }
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsLogged { get; set; }


        public void Login(string username, string password)
        {
            Username = username;
            Password = password;
            IsLogged = true;
        }
    }
}
