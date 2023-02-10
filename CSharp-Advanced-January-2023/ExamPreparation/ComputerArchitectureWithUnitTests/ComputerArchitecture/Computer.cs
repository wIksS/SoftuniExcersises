using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Capacity = capacity;
            Model = model;
            Multiprocessor = new List<CPU>();
        }

        public List<CPU> Multiprocessor { get; set; }

        public int Capacity { get; set; }

        public string Model { get; set; }

        public int Count { get { return Multiprocessor.Count; } }

        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            CPU cpuToRemove = Multiprocessor.FirstOrDefault(c => c.Brand == brand);
            if (cpuToRemove != null)
            {
                return Multiprocessor.Remove(cpuToRemove);
            }

            return false;

            //for (int i = 0; i < MultiProcessor.Count; i++)
            //{
            //    if (MultiProcessor[i].Brand == brand)
            //    {
            //        MultiProcessor.RemoveAt(i);
            //        return true;
            //    }
            //}

            //return false;
        }

        public CPU MostPowerful()
        {
            if (Multiprocessor.Count == 0)
            {
                return null;
            }

            CPU mostPowerful = Multiprocessor[0];

            foreach (var cpu in Multiprocessor)
            {
                if (cpu.Frequency > mostPowerful.Frequency)
                {
                    mostPowerful = cpu;
                }
            }

            return mostPowerful;
        }

        public CPU GetCPU(string brand)
        {
            return Multiprocessor.FirstOrDefault(c => c.Brand == brand);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var cpu in Multiprocessor)
            {
                result.AppendLine(cpu.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
