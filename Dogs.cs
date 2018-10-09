using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatrickW_Pets
{
    public class Dog : Pet
    {
        public Dog(string Name, string Owner, double weight) : base("dog", Name, Owner, Weight)
        {
        }
        
        public string bark(int count)
        {
            string barks = "";
            for (int i = 0; i < count; i++)
            {
                barks += "bark!";
            }
            return barks;

        }
    }
}
