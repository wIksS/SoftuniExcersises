namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> universe = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int n =int.Parse(Console.ReadLine());

            List<int[]> sets = new List<int[]>();

            for (int i = 0; i < n; i++)
            {
                sets.Add(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            }

            var chosenSets = ChooseSets(sets, universe);

            Console.WriteLine($"Sets to take ({chosenSets.Count}):");

            foreach (var set in chosenSets)
            {
                Console.WriteLine($"{{ {string.Join(", ", set)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> chosenSets = new List<int[]>();
            while (universe.Count > 0)
            {
                var sortedSets = sets.OrderByDescending(s => ContainedElements(s, universe)).ToArray();

                var usedSet = sortedSets[0];
                sets.Remove(usedSet);
                chosenSets.Add(usedSet);
                foreach (var item in sortedSets[0])
                {
                    universe.Remove(item);
                }
            }
            
            return chosenSets;
        }

        public static int ContainedElements(int[] set, IList<int> list)
        {
            return list.Where(e => set.Contains(e)).Count();
        }
    }
}
