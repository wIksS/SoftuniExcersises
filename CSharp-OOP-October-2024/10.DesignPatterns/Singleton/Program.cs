

using Singleton;

Console.WriteLine("Before singleton creation");

for (int i = 0; i < 100; i++)
{
    new Thread(() =>
    {
        LoggedUserSingleton.Instance.Username = "Viktor" + i;
    }).Start();
}


Console.WriteLine(LoggedUserSingleton.Instance.Username);