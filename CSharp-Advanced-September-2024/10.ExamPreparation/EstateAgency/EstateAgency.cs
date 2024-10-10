using System.Text;

namespace EstateAgency
{
    public class EstateAgency
    {
        public EstateAgency(int capacity)
        {
            Capacity = capacity;
            RealEstates = new List<RealEstate>();
        }

        public int Capacity { get; set; }

        public List<RealEstate> RealEstates { get; set; }

        public int Count { get { return RealEstates.Count; } }

        public void AddRealEstate(RealEstate newRe)
        {
            if (Capacity <= Count)
            {
                return;
            }

            if (RealEstates.Any(re => re.Address == newRe.Address))
            {
                return;
            }

            RealEstates.Add(newRe);
        }

        public bool RemoveRealEstate(string address)
        {
            RealEstate re = RealEstates.FirstOrDefault(re => re.Address == address);
            
            return RealEstates.Remove(re);
        }

        public List<RealEstate> GetRealEstates(string postalCode)
        {
            List<RealEstate> realEstates = RealEstates.Where(re => re.PostalCode == postalCode).ToList();

            return realEstates;
        }

        public RealEstate GetCheapest()
        {
            RealEstate cheapest = RealEstates.OrderBy(re => re.Price).First();

            return cheapest;
        }

        public double GetLargest()
        {
            RealEstate largest = RealEstates.OrderByDescending(re => re.Size).First();

            return largest.Size;
        }

        public string EstateReport()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Real estates available:");

            foreach (var re in RealEstates)
            {
                result.AppendLine(re.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
