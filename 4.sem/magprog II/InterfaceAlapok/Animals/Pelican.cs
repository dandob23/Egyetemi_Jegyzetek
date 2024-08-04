using InterfaceAlapok.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlapok.Animals
{
    internal class Pelican:IAnimal, ICanFly, ICanSwim
    {
        public Pelican(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void CanFly()
        {
            Console.WriteLine("The pelican can fly");
        }

        public void ICanSwim()
        {
            Console.WriteLine("The pelican can swim");        
        }
    }
}
