namespace SmartDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Device
    {
        public Device(int memoryCapacity)
        {
            this.MemoryCapacity = memoryCapacity;
            this.AvailableMemory = memoryCapacity;
            this.Photos = 0;
            this.Applications = new List<string>();
        }

        public int MemoryCapacity { get; private set; }
        public int AvailableMemory { get; private set; }

        public int Photos { get; private set; }

        public List<string> Applications { get; private set; }

        public bool TakePhoto(int photoSize)
        {
            if (photoSize <= this.AvailableMemory)
            {
                this.AvailableMemory -= photoSize;
                this.Photos++;
                return true;
            }
            return false;
        }

        public string InstallApp(string appName, int appSize)
        {
            if (appSize <= this.AvailableMemory)
            {
                this.AvailableMemory -= appSize;
                this.Applications.Add(appName);
                return $"{appName} is installed successfully. Run application?";
            }
            else
            {
                throw new InvalidOperationException("Not enough available memory to install the app.");
            }
        }

        public void FormatDevice()
        {
            this.Photos = 0;
            this.Applications = new List<string>();
            this.AvailableMemory = this.MemoryCapacity;
        }

        public string GetDeviceStatus()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Memory Capacity: {this.MemoryCapacity} MB, Available Memory: {this.AvailableMemory} MB");
            stringBuilder.AppendLine($"Photos Count: {this.Photos}");
            stringBuilder.AppendLine($"Applications Installed: {string.Join(", ", this.Applications)}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
