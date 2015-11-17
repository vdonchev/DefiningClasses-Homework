﻿namespace _3.PCCatalog.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Computer
    {
        private string name;
        private List<PCComponent> components;

        public Computer(string name, params PCComponent[] pcComponents)
        {
            this.Name = name;
            this.AddComponents(pcComponents);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException("PC Name can't be blank.");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.components.Sum(component => component.Price);
            }
        }

        private void AddComponents(PCComponent[] pcComponents)
        {
            this.components = new List<PCComponent>();
            foreach (var pcComponent in pcComponents)
            {
                this.components.Add(pcComponent);
            }
        }

        public override string ToString()
        {
            var info = new StringBuilder();
            string seperator = "+" + new string('-', 15) + "+" + new string('-', 35) + "+";

            info.AppendLine(seperator);
            info.AppendLine($"|{"pc name",15}|{this.Name,35}|");

            foreach (var component in this.components)
            {
                info.Append(component);
            }
            info.AppendLine(seperator);
            info.AppendLine($"|{"total price",15}|{this.Price,35:c}|");
            info.AppendLine(seperator);

            return info.ToString();
        }
    }
}