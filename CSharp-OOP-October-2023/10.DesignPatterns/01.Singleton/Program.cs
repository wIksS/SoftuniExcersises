

Console.WriteLine("Who are you");
string name = Console.ReadLine();

LoggedUserSingleton loggedUser = LoggedUserSingleton.Instance;
LoggedUserSingleton.Instance.Name = name;

Console.WriteLine($"{LoggedUserSingleton.Instance.Name} is logged in");

class LoggedUserSingleton
{
    private static LoggedUserSingleton instance;

    private LoggedUserSingleton()
    {
        Console.WriteLine("Logged user created");
    }
    public string Name { get; set; }

    public static LoggedUserSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LoggedUserSingleton();
            }

            return instance;
        }
    }
}