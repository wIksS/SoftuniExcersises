using System;

namespace Auth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsersController usersController = new UsersController(new Authenticator());

            usersController.Run();
        }
    }
}
