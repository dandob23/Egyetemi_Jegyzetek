using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitestek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Csillag ujcsillag = new Csillag("Alfa Centaur", 300, CsillagOsztaly.VorosOrias, 156.34);

            Console.ReadKey();
        }
    }
}
