namespace _4.SoftwareUniversityLearningSystem.Models
{
    using Interfaces;
    public class JuniorTrainer : Trainer, ICreate
    {
        public JuniorTrainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }
    }
}