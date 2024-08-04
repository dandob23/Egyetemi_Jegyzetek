using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a konstruktor private, nem lehet new kulcsszóval példányosítani
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            // Teszt: ugyanaz a példány-e a kettő?
            if (s1 == s2)
            {
                Console.WriteLine("Ugyanaz! Tehát csak egy példány van.");
            }
            Console.ReadKey();

        }
    }
}

/*
 Singleton (Egyke):

lehetővé teszi, hogy egy osztályból csak egy példány létezzen
az egyetlen példány globálisan elérhető
osztály szintű metódusokat használ az egyetlen példány elérésére
az osztálynak nincs publikus konstruktora, így az új példány létrehozása korlátozott
az osztály szintű szerezPéldány (getInstance) metódus biztosítja az egyetlen példány elérését
példányosítás a privát konstruktoron keresztül történik a szerezPéldány metódusban
amikor alkalmazzuk:
ha biztosítani akarjuk, hogy csak egy példány legyen egy osztályból, például konfigurációs beállítások vagy naplózás esetén
például egy adatbázis kapcsolat kezelése, ahol csak egy példány létezhet az erőforrások hatékony használata érdekében
nem lehet publikus konstruktora az osztálynak, így nem sérti az OCP elvet

működése:
az osztály tartalmaz egy privát statikus mezőt az egyetlen példány tárolására
a szerezPéldány metódus visszaadja ezt a példányt, létrehozva, ha még nem létezik

előnyök:
biztosítja az egyetlen példány létét
globális hozzáférési pontot biztosít

hátrányok:
nehéz tesztelni, mivel nehéz az állapotot tisztán tartani
néha túlzottan használt, ami nem mindig indokolt
 
 */
