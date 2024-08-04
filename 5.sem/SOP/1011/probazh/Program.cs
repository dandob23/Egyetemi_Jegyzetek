using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probazh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.CreateProducers(2);
            Controller.CreateConsumers(2);
            Controller.StartThreads();
            Console.ReadLine();
        }
    }
}
/*
Microchip gyár
két futószalag, 2 gép
egyik futószalagra 2 féle chipet gyártanak a gépek, egyik gyorsabb mint a másik
válogatás nélkül mennek a másik szalagra
a következő futószalagon a gépek elvesznek egyenként 5 azonos típusú chipet és belerakják egy dobozba

ha az egyik gép felvett egyfajta chipet a másik gép már másmilyet vehet csak fel

ha a termelő befejezte, logoljunk
ha a fogyasztó befejezte, logoljunk
 */