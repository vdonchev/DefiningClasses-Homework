namespace _1.Persons.Models
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new System.ArgumentException(string.Format(ModelsConstants.StringCannotBeNullOrEmpty, "Name"));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new System.ArgumentException(string.Format(ModelsConstants.NumberIsNotInRange, "Age", 1, 100));
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
                {
                    throw new System.ArgumentException(ModelsConstants.WrongEmailFormat);
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            if (this.email != null)
            {
                return $"Hi, my name is {this.Name}, I am {this.Age} years old and my e-mail address is: {this.Email}.";
            }

            return $"Hi, my name is {this.Name} and I am {this.Age} years old.";
        }
    }
}