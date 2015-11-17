namespace _3.PCCatalog.Models
{
    using System;
    using System.Text;

    public class PCComponent
    {
        private string name;
        private string details;
        private decimal price;

        public PCComponent(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public PCComponent(string name, decimal price)
            : this(name, null, price)
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
                    throw new ArgumentException("Component name can't be null or empty.");
                }

                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("Component details can't be blank.");
                }

                this.details = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Component price can't be negative number.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            string seperator = "+" + new string('-', 15) + "+" + new string('-', 35) + "+";
            info.AppendLine(seperator);
            if (this.Details != null)
            {
                info.AppendLine($"|{"component name",15}|{this.Name + " (" + this.Details + ")",35}|");
            }
            else
            {
                info.AppendLine($"|{"component name",15}|{this.Name,35}|");
            }

            info.AppendLine($"|{"",15}|{this.Price,35:C}|");
            return info.ToString();
        }
    }
}