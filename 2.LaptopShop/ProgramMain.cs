namespace _2.LaptopShop
{
    using System;
    using Models;

    public class ProgramMain
    {
        public static void Main(string[] args)
        {
            Laptop laptop = new Laptop(
                "Lenovo Yoga 2 Pro", 
                "Lenovo", 
                "Intel Core i5-4210U",
                "8 GB",
                "Intel HD Graphics 4400",
                "128GB SSD",
                "13.3\"(33.78 cm) – 3200 x 1800 (QHD)", 
                new Battery(4, 2550, BatteryType.LiIon),
                4.5, 
                2259M);

            Laptop laptop2 = new Laptop("Acer Aspire V5", 1699M);

            Console.WriteLine(laptop);
            Console.WriteLine(laptop2);
        }
    }
}
