using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinositesGyar[] minosito = new MinositesGyar[2];
            minosito[0] = new KonkretMinositesGyar1();
            minosito[1] = new KonkretMinositesGyar2();
            foreach (MinositesGyar m in minosito)
            {
                Minosites minosites = m.CreateMinosites();
                minosites.Minosit();
            }
            Console.ReadLine();

        }
    }
}

/*
 Factory Method (Gyártómetódus):

létrehozási tervezési minta, amely kiváltja a hasonló new utasításokat a kódban
az ősosztály tartalmazza a gyártás algoritmusát
a gyermekosztályok döntik el, hogy pontosan mit kell gyártani
az algoritmus háromféle lépést tartalmazhat:
gyártás közös lépései: konkrét metódusok az ősben
gyártás kötelező változó lépései: absztrakt metódusok az ősben
gyártás opcionális lépései: horog metódusok az ősben
amikor alkalmazzuk:
ha a gyártás folyamata ritkán változik, de a gyártandó objektum gyakran változik
például: Office csomag alkalmazásai, ahol az "Új" menüpont különböző típusú dokumentumokat hoz létre

működése:
az ősosztály tartalmazza a gyártómetódust, amely absztrakt metódusokat hív
a gyermekosztályok implementálják az absztrakt metódusokat

előnyök:
könnyen bővíthető új termékekkel
az OCP elv betartása

hátrányok:
növeli az osztályok számát és a kód komplexitását
 
 */
