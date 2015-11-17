namespace _3.PCCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class ProgramMain
    {
        public static void Main(string[] args)
        {
            PCComponent vga = new PCComponent("VGA", "Intel HD Graphics 4400", 256.6M);
            PCComponent vga2 = new PCComponent("VGA", "Intel HD Graphics 5000", 306.6M);
            PCComponent ssd = new PCComponent("SSD 250GB", "Samsung 850 EVO", 207.9M);
            PCComponent ssd2 = new PCComponent("SSD 120GB", "A-Data Pro SP920", 114.64M);
            PCComponent ram = new PCComponent("RAM", "Мноо бърза!", 199.89M);
            PCComponent cpu = new PCComponent("Processor", "Intel Core i5", 399.52M);
            PCComponent cpu2 = new PCComponent("Processor", "Intel Core i7", 499.02M);
            PCComponent kb = new PCComponent("Keyboard", "Подарък!", 0M);

            List<Computer> computers = new List<Computer>()
            {
                new Computer("Dell", cpu, ssd, kb),
                new Computer("Alienware", cpu2, ssd2, vga),
                new Computer("HP", ram, vga2, kb),
                new Computer("Apple", cpu, kb),
            };

           computers
                .OrderBy(computer => computer.Price)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}