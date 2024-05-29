

using _01.Singleton;


for (int i = 0; i < 1000; i++)
{
    new Thread(() =>
    {
        UserSingleton.Instance.Username = i.ToString();
    }).Start();
}



Console.WriteLine("before singleton");

UserSingleton userSingleton = UserSingleton.Instance;

UserSingleton.Instance.Username = "Dimitrichko";

UserSingleton.Instance.Password = "password";


Console.WriteLine(UserSingleton.Instance.Username);