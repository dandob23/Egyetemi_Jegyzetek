using InterfaceAlapok.Animals;
using InterfaceAlapok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            zoo.AddAnimal(new Duck("Duck 1"));

            zoo.AddAnimal(new Duck("Duck 1"));

            zoo.AddAnimal(new GoldFish("Goldfish 1"));

            zoo.AddAnimal(new GoldFish("Goldfish 1"));

            zoo.AddAnimal(new Pelican("Pelican"));

            foreach (IAnimal animal in zoo.Animals)
            {
                Console.WriteLine(animal.Name);
            }



            Console.ReadKey();
            
        }
    }
}
