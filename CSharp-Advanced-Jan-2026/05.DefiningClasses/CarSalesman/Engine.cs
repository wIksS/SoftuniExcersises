using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power, int? displacement= null, string efficiency = null)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int? Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"  {Model}:");
            result.AppendLine($"    Power: {Power}");
            if(Displacement != null)
            {
                result.AppendLine($"    Displacement: {Displacement}");
            }
            else
            {
                result.AppendLine($"    Displacement: n/a");
            }
            if (Efficiency != null)
            {
                result.AppendLine($"    Efficiency: {Efficiency}");
            }
            else
            {
                result.AppendLine($"    Efficiency: n/a");
            }

            return result.ToString().TrimEnd();
        }
    }
}