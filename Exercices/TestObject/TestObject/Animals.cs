using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObject
{
    public class Animal
    {
        public string species;

        public Animal(string _species)
        {
            this.species = _species;
        }

        public void eat()
        {
            Console.WriteLine(this.species + " mange");
        }

        public void move()
        {
            Console.WriteLine(this.species + " se déplace");
        }

       
        
        

    }
}
