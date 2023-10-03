using System;
using System.Collections.Generic;
using System.IO;
using PhoneAdministration;
using PhoneClass;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "C:\\Users\\Igor\\Desktop\\POO-Phone app\\Config.txt";
            PhoneDatabase database = new PhoneDatabase(filepath);

            var searchResults = database.Search(phone => phone.Sim == "Dual SIM" && phone.Brand == "Samsung");
            //searchResults = database.Search(phone => phone.BatteryCapacity >= 3100);
            // printam resulturile
            Console.WriteLine("Search Results:");
            database.PrintPhones(searchResults);

            Console.ReadLine();

        }
    }
}
    //PhoneDataExtractor extractor = new PhoneDataExtractor();
    //List<Phone> phoneList = extractor.ExtractPhoneData();


    //foreach (Phone phone in phoneList)
    //    {
    //    }
    //    Console.WriteLine($"Brand: {phone.Brand}");
    //    Console.WriteLine($"Model: {phone.Model}");
    //    Console.WriteLine($"Price: {phone.Price}");
    //    Console.WriteLine($"Screen size: {phone.ScreenSize}");
    //    Console.WriteLine($"Battery capacity: {phone.BatteryCapacity}");
    //    Console.WriteLine($"Camera quality: {phone.CameraQuality}");
    //    Console.WriteLine($"Sim: {phone.Sim}");
    //    Console.WriteLine($"OS: {phone.OS}");
    //    Console.WriteLine($"Color: {phone.color}");
    //    Console.WriteLine($"Network: {phone.Network}");
    //    Console.WriteLine($"Year of release: {phone.year}");
    //    Console.WriteLine($"Number of cores: {phone.Cores}");
    //    Console.WriteLine($"Storage capacity: {phone.StorageCapacity}");
    //    Console.WriteLine($"RAM: {phone.Ram}");
    //    Console.WriteLine($"Weight: {phone.Weight}");
    //    Console.WriteLine();
    //}


    //Console.ReadLine();
    //    }
//}