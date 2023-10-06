
Cat cat = new Cat("Dimitrichka");
while (true)
{
    Console.ReadLine();
    Console.WriteLine($"Is hungry : {cat.IsHungry()}");
}
class Cat
{
    private DateTime lastFeedTime;
    private TimeSpan fullTime = TimeSpan.FromMilliseconds(2000);

    public Cat()
    {
        lastFeedTime = DateTime.Now;
    }

    public Cat(string name) : this()
    {
        Name = name;
    }

    public Cat(string name, int age) : this(name)
    {
       Age = age;
    }

    public string Name { get; set; }
    public int Age { get; private set; }

    public bool IsHungry()
    {
        if (DateTime.Now - lastFeedTime > fullTime)
        {
            FeedCat();
            return true;
        }

        Console.WriteLine(DateTime.Now - lastFeedTime);
        return false;
    }

    private void FeedCat()
    {
        lastFeedTime = DateTime.Now;
    }
}