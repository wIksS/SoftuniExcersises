



using _04.Polymorphism;

IDriveable vehicle = new JetSki();

JetSki jetSki = vehicle as JetSki;

if (jetSki != null)
{
    jetSki.SplashWater();
}





if (vehicle is JetSki)
{
    JetSki jet = (JetSki)vehicle;
    Console.WriteLine(jet.Hours);
    jet.SplashWater();
}

Console.WriteLine(vehicle is JetSki);
Console.WriteLine(vehicle is Car);
Console.WriteLine(vehicle is IDriveable);
Console.WriteLine(vehicle is object);
Driver driver= new Driver();


// the ability of an object take on many forms

while (true)
{
    Console.WriteLine("what are you driving?");
    string choice = Console.ReadLine();
    IDriveable driveable = null;
    if (choice == "skoda")
    {
        driveable = new SkodaOctavia();
    }
    if (choice == "bmw")
    {
        driveable = new BMWThree();
    }
    if (choice == "jet")
    {
        driveable = new JetSki();
    }

    driveable.Accelerate();

    driver.Vehicle = driveable;
    
    driver.Drive(driveable);
}

// Driver
// car, jetski, skodaoctavia, bmwthree

class Driver
{
    public IDriveable Vehicle { get; set; }

    public void Drive(IDriveable drivable)
    {
        drivable.Start();
        drivable.Accelerate();

        drivable.Decelerate();

        drivable.Stop();

        if (drivable is JetSki jet)
        {
            jet.SplashWater();
            ((JetSki)drivable).SplashWater();
        }
        else if(drivable is BMWThree)
        {
           
        }
    }
}
