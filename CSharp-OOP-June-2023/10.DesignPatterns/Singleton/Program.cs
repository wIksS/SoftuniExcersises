using Singleton;

for (int i = 0; i < 10000; i++)
{
    new Thread(() =>
    {
        var test = UserSingleton.Instance.Name;
    }).Start();
}



Console.WriteLine("Before initializing singleton");

UserSingleton loggedUser = UserSingleton.Instance;


UserSingleton.Instance.Name = "Goshko";

UserSingleton.Instance.ChangePassword("goshko123");