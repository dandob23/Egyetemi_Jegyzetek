using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BFa fa = new Fa(5, new Levél(8), new Levél(3));
            SumVisitor sumv = new SumVisitor();
            MaxVisitor maxv = new MaxVisitor();
            fa.AcceptVisitor(sumv);
            fa.AcceptVisitor(maxv);
            Console.WriteLine("A fában lévő számok összege: {0}", sumv.Sum);
            Console.WriteLine("A fában lévő legnagyobb szám: {0}", maxv.Max);
            Console.ReadLine();

        }
    }
}
/*
 Visitor (Látogató):

viselkedési tervezési minta, amely egy vagy több változékony metódust szervez ki egy másik osztály hierarchiába
az adatszerkezetek feldolgozását különválasztja az adatszerkezettől
amikor alkalmazzuk:
ha egy kiforrott adatszerkezetet akarunk feldolgozni, és könnyen bővíteni akarjuk az algoritmusok sorát
például: egy bináris fa vagy lista feldolgozása különböző látogatók segítségével

működése:
az adatszerkezet tartalmaz egy látogató fogadás metódust
a látogató implementálja a feldolgozó metódusokat

előnyök:
könnyen bővíthető új látogatókkal
az adatszerkezet és a feldolgozó metódusok szétválasztása

hátrányok:
ha megváltozik az adatszerkezet, az összes látogatót frissíteni kell
növeli az osztályok számát és a kód komplexitását
 */
