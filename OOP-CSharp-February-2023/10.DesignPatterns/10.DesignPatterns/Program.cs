using _10.DesignPatterns;

for (int i = 0; i < 1000; i++)
{
    new Thread(() =>
    {
        User newUser = User.Instance;
    }).Start();
}

User user = User.Instance;

user.Login("DImitrichko", "password");

Console.WriteLine(User.Instance.Username);
Console.WriteLine(user.Password);