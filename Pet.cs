using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrickW_Pets
{
    public class Pet
    {
        public string Type;
        public string Name;
        public string Owner;
        public double Weight;

        public Pet(string Type, string Name, string Owner, double Weight)
        {
            this.Type = Type;
            this.Name = Name;
            this.Owner = Owner;
            this.Weight = Weight;
        }

        public string GetTag()
        {
            Console.WriteLine("If lost, please call Jose");
            return "If lost, call " + Owner;
        }
        
    }
}
