namespace _4.SoftwareUniversityLearningSystem.Models
{
    using System;
    using Interfaces;

    public class SeniorTrainer : Trainer, ICreate, IDelete
    {
        public SeniorTrainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string name)
        {
            Console.WriteLine($"{name} course has been deleted.");
        }
    }
}