using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleComparable
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town, int id)
        {
            Name = name;
            Age = age;
            Town = town;
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public override bool Equals(object? obj)
        {
            Person other = (Person)obj;

            return Name.ToLower() == other.Name.ToLower() && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name.ToLower(), Age);
        }

        public int CompareTo(Person? other)
        {
            //Console.WriteLine($"Comparing: {this} with {other}");
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
                if (result == 0)
                {
                    result = Town.CompareTo(other.Town);
                }
            }

            return result;
        }

        public override string ToString()
        {
            return $"Id:{Id}| {Name} {Age} {Town}";
        }
    }
}
