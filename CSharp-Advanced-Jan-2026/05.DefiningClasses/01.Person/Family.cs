using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldest = members.OrderByDescending(p => p.Age).FirstOrDefault();

            return oldest;
        }

        public List<Person> FilterMembers(Func<Person, bool> filter)
        {
            //List<Person> filteredMembers = new List<Person>();
            //foreach (var person in members)
            //{
            //    if (filter(person))
            //    {
            //        filteredMembers.Add(person);
            //    }
            //}

            return members.Where(filter).ToList();
        }

        public List<Person> SortMembers(List<Person> members)
        {
            return members.OrderBy(person => person.Name).ToList();
        }

        public void PrintMembers(int ageThreshold)
        {
            List<Person> filteredMembers = 
                FilterMembers(p => p.Age > ageThreshold);

            filteredMembers = SortMembers(filteredMembers);

            foreach (var member in filteredMembers)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
