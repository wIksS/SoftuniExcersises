
Cat garfield = new Cat()
{
    Age = 3,
    Name = "Garfield"
};

Cat mac = new Cat()
{
    Age = 10,
    Name = "Mac"
};


garfield.GetOlder(1);
garfield.GetOlder(1);
garfield.GetOlder(1);

mac.GetOlder(1);

class Cat
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int GetOlder(int years)
    {
        Age += years;

        return Age;
    }
}