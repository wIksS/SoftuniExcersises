using System;
using System.Collections.Generic;
using System.Text;

namespace Auth
{
    internal class UsersController
    {
        private Authenticator authenticator;

        public UsersController(Authenticator authenticator)
        {
            this.authenticator = authenticator;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Login(1) or register(2)?");
                int choice = int.Parse(Console.ReadLine());
                string username = Console.ReadLine();   
                string password = Console.ReadLine();   
                if (choice == 1)
                {
                    bool isLogged = authenticator.Login(username, password);
                    Console.WriteLine($"Logged: {isLogged}");
                }
                else if (choice == 2)
                {
                    try
                    {
                        authenticator.Register(username, password);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }
                    catch (UserRegisteredException)
                    {
                        Console.WriteLine("Successfully registered");
                    }
                }
            }
        }
    }
}
