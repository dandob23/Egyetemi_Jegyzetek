using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Készítünk egy helyettest és kérünk egy szolgáltatást.
            Proxy proxy = new Proxy();
            proxy.Kérés();
            Console.ReadKey();

        }
    }
}

/*
 Proxy (Helyettes):

szerkezeti tervezési minta, amely egy valamilyen szempontból érdekes példányt helyettesít
a helyettes átlátszó módon csomagolja be az érdekes objektumot
különböző típusai vannak, például virtuális proxy, távoli proxy, védelmi proxy
amikor alkalmazzuk:
ha egy drága vagy távoli objektumot akarunk helyettesíteni
például: egy proxyn keresztül megtudni, hogy mennyi az oldalszáma egy könyvnek

működése:
a helyettes és az érdekes objektum közös őse van
a helyettes az érdekes objektum szolgáltatásait biztosítja

előnyök:
csökkenti az erőforrások használatát
átlátszó módon biztosítja az objektum szolgáltatásait

hátrányok:
növeli az osztályok számát és a kód komplexitását
néha nehéz kezelni a proxy és az eredeti objektum közötti kapcsolatot
 */
