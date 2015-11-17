namespace _4.SoftwareUniversityLearningSystem.Models.Students
{
    using System;

    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits) : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of visits can't be negative number.");
                }

                this.numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Visits: {this.NumberOfVisits}";
        }
    }
}