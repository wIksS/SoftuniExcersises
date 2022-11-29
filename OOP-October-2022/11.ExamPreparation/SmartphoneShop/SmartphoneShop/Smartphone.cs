namespace SmartphoneShop
{
   public class Smartphone
    {
        public Smartphone(string modelName, int maximumBatteryCharge)
        {
            this.ModelName = modelName;
            this.MaximumBatteryCharge = maximumBatteryCharge;
            this.CurrentBateryCharge = maximumBatteryCharge;
        }

        public string ModelName { get; set; }

        public int CurrentBateryCharge { get; set; }

        public int MaximumBatteryCharge { get; }
    }
}
