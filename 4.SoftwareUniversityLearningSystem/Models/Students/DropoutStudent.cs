namespace _4.SoftwareUniversityLearningSystem.Models.Students
{
    using System;
    using Interfaces;
    public class DropoutStudent : Student, IReapply
    {
        private string droputReason;

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string droputReason) : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DroputReason = droputReason;
        }

        public string DroputReason
        {
            get
            {
                return this.droputReason;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Droput reason can't be null or empty.");
                }

                this.droputReason = value;
            }
        }

        public void ReApply()
        {
            Console.WriteLine($"{this} Dropout reason: {this.DroputReason}");
        }
    }
}