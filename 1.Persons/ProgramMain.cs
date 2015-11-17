namespace _1.Persons
{
    using System;
    using Models;

    class ProgramMain
    {
        static void Main(string[] args)
        {
            Person person = new Person("Pesho", 35);
            Person person2 = new Person("Gosho", 35, "gosho@abv.bg");
            Console.WriteLine(person);
            Console.WriteLine(person2);

            try
            {
                var person3 = new Person("", 35);
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            try
            {
                var person3 = new Person("Koko", -35);
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}