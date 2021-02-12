using System;

namespace VetClinic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet("Gogi", 3, "Boki");

            Console.WriteLine(pet);

            Clinic clinic = new Clinic(3);

            clinic.Add(pet);
            Console.WriteLine(clinic.GetStatistics());
            clinic.Add(new Pet("2", 3, "4"));
            Console.WriteLine(clinic.GetStatistics());

            Console.WriteLine(clinic.GetOldestPet());

            Console.WriteLine(clinic.GetPet("Gogi", "Boki"));
            Console.WriteLine(clinic.GetPet("Gogi", "Boki2"));
            Console.WriteLine(clinic.Count);
            Console.WriteLine(clinic.Remove("Gogi"));
            Console.WriteLine(clinic.Remove("Gogi"));
            Console.WriteLine(clinic.Remove("Gogi"));

            Console.WriteLine(clinic.Count);

            Console.WriteLine(clinic.GetStatistics());

            clinic.Add(new Pet("2", 3, "4"));
            clinic.Add(new Pet("2", 3, "4"));
            clinic.Add(new Pet("2", 3, "4"));
            clinic.Add(new Pet("2", 3, "4"));
            clinic.Add(new Pet("2", 3, "4"));
            clinic.Add(new Pet("2", 3, "4"));

            Console.WriteLine(clinic.Count);


            Clinic clinic2 = new Clinic(-1);

            Console.WriteLine(clinic2.Count);
            Console.WriteLine(clinic2.Remove("1"));
            Console.WriteLine(clinic2.GetPet("213", "123"));
            Console.WriteLine(clinic2.GetOldestPet());
            Console.WriteLine(clinic2.GetStatistics());
        }
    }
}
