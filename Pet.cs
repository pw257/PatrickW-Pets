using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrickW_Pets
{
    public class Pet
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public double Weight { get; set; }

        public Pet(string type, string name, string owner, double weight)
        {
            Name = name;
            Type = type;
            Owner = owner;
            Weight = weight;
        }

        public object GetTag()
        {
            Console.WriteLine("If lost, please call Jose");
            return;
        }
        
    }
}
