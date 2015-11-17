namespace _4.SoftwareUniversityLearningSystem.Models.Students
{
    using System;

    public abstract class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        protected Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Student number can't be negative.");
                }

                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Student average grade should be in range [2..6].");
                }

                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Avg. grade: {this.AverageGrade:F2}";
        }
    }
}