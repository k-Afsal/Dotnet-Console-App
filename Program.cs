using System;

namespace HelloWorld
{
    public class Computer
    {
        public string Motherboard {get; set;}
        public int CPUCores {get; set;}
        public bool HasWifi {get; set;}
        public bool HasLTE {get; set;}
        public DateTime ReleaseDate {get; set;}
        public decimal Price {get; set;}
        public string VideoCard {get; set;}
        
        public Computer()
        {
            if (Motherboard == null)
            {
                Motherboard = "";
            }
            if (VideoCard == null)
            {
                VideoCard = "";
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
             Computer myComputer = new Computer()
             {
                    Motherboard = "ASUS ROG Strix",
                    CPUCores = 8,
                    HasWifi = true,
                    HasLTE = false,
                    ReleaseDate = new DateTime(2023, 10, 1),
                    Price = 1499.99m,
                    VideoCard = "NVIDIA GeForce RTX 3080"
             };
        }
    }                            
}
