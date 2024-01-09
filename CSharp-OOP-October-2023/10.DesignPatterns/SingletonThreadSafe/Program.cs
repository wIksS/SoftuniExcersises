
for (int i = 0; i < 100; i++)
{
    new Thread(() =>
    {
        LoggedUserSingleton.Instance.Name = i.ToString();
    }).Start();
}



class LoggedUserSingleton
{
    private static int counter = 0;
    private static LoggedUserSingleton instance;
    private static object lockObject = new object();
    private LoggedUserSingleton()
    {
        Console.WriteLine(counter++);
        Console.WriteLine("Logged user created");
    }
    public string Name { get; set; }

    public static LoggedUserSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new LoggedUserSingleton();
                    }

                }
            }

            return instance;
        }
    }
}