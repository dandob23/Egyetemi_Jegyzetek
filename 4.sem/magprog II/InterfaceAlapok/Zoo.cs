using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlapok
{
    internal class Zoo
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public List<IAnimal> Animals
        {
            get
            {
                //klonozas

                return animals;
            }
        }

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);

        }
    }
}
