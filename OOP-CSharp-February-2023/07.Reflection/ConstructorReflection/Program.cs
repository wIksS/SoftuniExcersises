
Random rand = (Random)Activator.CreateInstance(typeof(Random));

Random rand2 = new Random();

Console.WriteLine(rand.Next());
Console.WriteLine(rand2.Next());


DateTime date =(DateTime) InstanceCreator(typeof(DateTime));

Console.WriteLine(date.ToString());

object InstanceCreator(Type type)
{
    return Activator.CreateInstance(type);  
}