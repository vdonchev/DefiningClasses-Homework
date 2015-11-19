namespace _4.SoftwareUniversityLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Models.Students;

    public class ProgramMain
    {
        public static void Main(string[] args)
        {
            var persons = new List<Person>()
            {
                new DropoutStudent("Dimitar", "Berbatov", 35, 159, 4.55, "Да играе футбол"),
                new DropoutStudent("Ivan", "Ivanov", 18, 19, 2.70, "Да ходи на село"),
                new OnsiteStudent("Videlin", "Donchev", 30, 9877, 5.55, "OOP", 69),
                new OnsiteStudent("Petar", "Stoyanov", 80, 977, 2.01, "C# Basic", 1),
                new OnlineStudent("Ivaylo", "Tokiev", 33, 897, 4.90, "OOP"),
                new GraduateStudent("Ivancho", "Mariikin", 16, 159, 2.55),
                new GraduateStudent("Pesho", "Goshev", 2, 159, 6.00),
                new SeniorTrainer("Svetlin", "Nakov", 50),
                new JuniorTrainer("Koicho", "Koichev", 99),
            };

            persons
                .OfType<CurrentStudent>()
                .OrderByDescending(student => student.AverageGrade)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}