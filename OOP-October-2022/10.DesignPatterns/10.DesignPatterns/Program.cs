using System;

namespace _10.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(User.Instance.Username);
            User user = User.Instance;

            user.Login("DImitrichko", "password");

            Console.WriteLine(user.Username);
            Console.WriteLine(user.Password);
        }
    }
}
