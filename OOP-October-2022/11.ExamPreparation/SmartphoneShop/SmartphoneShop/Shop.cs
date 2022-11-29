using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartphoneShop
{
    public class Shop
    {
        private List<Smartphone> phones;
        private int capacity;

        public Shop(int capacity)
        {
            this.phones = new List<Smartphone>();
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid capacity.");
                }

                this.capacity = value;
            }
        }

        public int Count => this.phones.Count;

        public void Add(Smartphone smartPhone)
        {
            if (this.phones.Any(x => x.ModelName == smartPhone.ModelName))
            {
                throw new InvalidOperationException($"The phone model {smartPhone.ModelName} already exist.");
            }
            else if (this.phones.Count == this.capacity)
            {
                throw new InvalidOperationException("The shop is full.");
            }

            this.phones.Add(smartPhone);
        }

        public void Remove(string modelName)
        {
            Smartphone currentPhone = this.phones.FirstOrDefault(x => x.ModelName == modelName);

            if (currentPhone == null)
            {
                throw new InvalidOperationException($"The phone model {modelName} doesn't exist.");
            }

            this.phones.Remove(currentPhone);
        }

        public void TestPhone(string modelName, int batteryUsage)
        {
            Smartphone currentPhone = this.phones.FirstOrDefault(x => x.ModelName == modelName);

            if (currentPhone == null)
            {
                throw new InvalidOperationException($"The phone model {modelName} doesn't exist.");
            }
            else if (currentPhone.CurrentBateryCharge < batteryUsage)
            {
                throw new InvalidOperationException($"The phone model {currentPhone.ModelName} is low on batery.");
            }

            currentPhone.CurrentBateryCharge -= batteryUsage;
        }

        public void ChargePhone(string modelName)
        {
            Smartphone currentPhone = this.phones.FirstOrDefault(x => x.ModelName == modelName);

            if (currentPhone == null)
            {
                throw new InvalidOperationException($"The phone model {modelName} doesn't exist.");
            }

            currentPhone.CurrentBateryCharge = currentPhone.MaximumBatteryCharge;
        }
    }
}
