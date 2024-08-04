using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlapok.Interfaces
{
    internal class Duck : IAnimal, ICanFly
    {
        public Duck(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void CanFly()
        {
            Console.WriteLine("The duck is flying");
        }
    }
}
