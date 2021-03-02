using System;
using System.Collections.Generic;

namespace RecursionProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog sharo = new Dog(new Dog());
            //Console.WriteLine(sharo.Friends[0]);
            //var sharoFriends = sharo.Friends;
            //sharoFriends[0] = null;
            //Console.WriteLine(sharo.Friends[0]);
        }
    }

    class Dog
    {
        private List<Dog> friends;

        public Dog(Dog friend = null)
        {
            friends = new List<Dog>()
            {
                friend,
            };
        }

        public IReadOnlyCollection<Dog> Friends
        {
            get
            {
                return this.friends.AsReadOnly();
            }
        }
    }
}
