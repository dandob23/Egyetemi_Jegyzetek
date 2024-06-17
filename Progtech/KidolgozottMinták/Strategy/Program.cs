using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AKacsa gumiKacsa = new Kacsa (new CsipogvaHapogas(), new NemRepul()); //felelősség beinjektálása
            //késői kötések
            gumiKacsa.Hapog(); //RekedtHapogas-ból hívja meg a Hapog metódust
            gumiKacsa.Repul(); //NemRepul-ból hívja meg a Repul metódust
            
            Console.WriteLine("-------------------");

            AKacsa vadKacsa =  new Kacsa(new NormalHapogas(), new GyorsanRepul());
            vadKacsa.Hapog();
            vadKacsa.Repul();

            Console.WriteLine("-------------------");

            AKacsa serultKacsa = new Kacsa(new RekedtHapogaas(), new NemRepul());
            serultKacsa.Hapog();
            serultKacsa.Repul();

            Console.ReadLine();
        }
    }
}
/*
 Strategy (Stratégia):

lehetővé teszi, hogy egy osztály viselkedését különböző stratégiákra bontsuk
ezeket a stratégiákat dinamikusan váltjuk
osztály hierarchiában van
ebben az osztály hierarchiában egyetlen változékony metódust kiemelünk
delegációval (felelősség átadás) meghívjuk (lehetővé teszi hogy az algoritmusokat futásidőben cseréljük)
akkor alkalmazzuk, ha van egy darab változékony metódusunk
A Kacsa osztályon belül lévő Hápog metódus, ahol különböző típusú kacsák különbözőképpen hápognak (házi kacsa, néma kacsa, gumikacsa, Donald kacsa).
A változékony metódus kódját nem szabad csak úgy felülírni => OCP megsértése
Helyyette a változékony metódust kiemeljük egy külön osztályhierarchiába
az osztályt és a változékony metódust szétválasztjuk -> objektum-összetétel összerakjuk

Működése:
Az osztályhierarchia tetején egy absztrakt osztály van (csak a kiszervezett metódus fejét tartalmazza)
Az absztrakt osztály gyermekei a stratégiák, amelyek megvalósítják a változékony metódust.
Az eredeti osztály (amelyből kiszerveztük a metódust) egy referenciamezőt kap a stratégiára.
(delegálás) Az eredeti osztály a kiszervezett metódust ezen referencián keresztül hívja meg.

Előnyök:
futásidőben cserélhető algoritmusok
OCP betartása ( Az osztályok zártak a módosításra és nyitottak a bővítésre.)
a felelősségek könnyen elkülöníthetők

Hátrányok:
Növeli az osztályok számát és a kód komplexitását.
Az objektum-összetétel és delegáció miatt több helyen kell módosítani a kódot egy új stratégia hozzáadásakor.
 
 
 */
