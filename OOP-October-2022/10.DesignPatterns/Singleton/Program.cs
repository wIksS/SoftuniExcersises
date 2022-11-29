using System;
using System.Threading;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                new Thread(() =>
                {
                    UserSingleton.Instance.Name = i.ToString();
                }).Start();
            }

            //Console.WriteLine("Before initializing");

            //UserSingleton.Instance.Name = "Pesho";

            //Console.WriteLine(UserSingleton.Instance.Name);

            //Console.WriteLine(UserSingleton.Instance.DeviceId);
            //Console.WriteLine(UserSingleton.Instance.DeviceId);
            //Console.WriteLine(UserSingleton.Instance.DeviceId);
            //Console.WriteLine(UserSingleton.Instance.DeviceId);
            //Console.WriteLine(UserSingleton.Instance.DeviceId);
        }
    }
}
