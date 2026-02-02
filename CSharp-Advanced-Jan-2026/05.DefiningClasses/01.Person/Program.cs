namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person person = new Person(input[0], int.Parse(input[1]));

                family.AddMember(person);
            }

            family.PrintMembers(30);

            //Person oldest = family.GetOldestMember();

            //Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}