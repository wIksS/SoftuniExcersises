

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {

            //Person person2 = new Person("", "", 239, 100);

            //person2.IncreaseSalary(20);

            // Console.WriteLine(person2);

            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                try
                {

                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                             cmdArgs[1],
                             int.Parse(cmdArgs[2]),
                             decimal.Parse(cmdArgs[3]));

                    //person.Age = 5;
                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //var percentage = decimal.Parse(Console.ReadLine());
            //persons.ForEach(p => p.IncreaseSalary(percentage));
            //persons.ForEach(p => Console.WriteLine(p.ToString()));


            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team.FirstTeam.Count);
            Console.WriteLine(team.ReserveTeam.Count);
            //foreach (Person person in persons)
            //{
            //    if (person.Age < 40)
            //    {
            //        team.FirstTeam.Add(person);
            //    }
            //    else
            //    {
            //        team.ReserveTeam(person);
            //    }
            //}

        }

    }
}