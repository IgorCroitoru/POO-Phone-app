using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneClass
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public double ScreenSize { get; set; }
        public int BatteryCapacity { get; set; }
        public int CameraQuality { get; set; }
        public int Ram { get; set; }
        public int StorageCapacity { get; set; }
        public double Weight { get; set; }
        public string Sim { get; set; }
        public string OS { get; set; }
        public int Network { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public int Cores { get; set; }
        public byte[] PhotoData { get; set; }

        public Phone() { }

        public override string ToString()
        {
            return $"Brand: {Brand}\nModel: {Model}\n" +
                   $"Price: {Price:C}\nScreen Size: {ScreenSize} inches\n" +
                   $"Battery Life: {BatteryCapacity} hours\nCamera Quality: {CameraQuality}Mpx\n" + 
                   $"Ram: {Ram} GB\nStorage Capacity: {StorageCapacity} GB\n" +
                   $"Weight: {Weight} gr\nSim: {Sim}\n" +
                   $"Operating System: {OS}\nNetwork: {Network}G\n" +
                   $"Release year: {year}\nColor: {color}\n" +
                   $"Cores: {Cores}\n";
        }
    }
}
