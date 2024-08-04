using InterfaceAlapok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlapok.Animals
{
    internal class GoldFish : IAnimal, ICanSwim
    {
        public GoldFish(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public void ICanSwim()
        {
            throw new NotImplementedException();
        }
    }
}
