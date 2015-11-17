namespace _4.SoftwareUniversityLearningSystem.Models
{
    using System;
    using Interfaces;

    public class Trainer : Person, ICreate
    {
        public Trainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string name)
        {
            Console.WriteLine($"{name} course has been created!");
        }

        public override string ToString()
        {
            return base.ToString() + " (trainer)";
        }
    }
}