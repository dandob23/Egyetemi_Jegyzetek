using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW5 bmw5 = new BMW5();
            Console.WriteLine("Alap BMW5: ");
            Console.WriteLine("Alap ár: {0}, alap tesztkörök: {1}", bmw5.HirePrice, bmw5.HireLaps);

            SpecialOffer specialOffer1 = new SpecialOffer(bmw5);
            specialOffer1.Discount = 10;
            specialOffer1.ExtraLaps = 2;
            Console.WriteLine("Különleges ajánlat: ");
            Console.WriteLine("ára: {0}, {1} körre", specialOffer1.HirePrice, specialOffer1.HireLaps);

            Hireable hire1 = new Hireable(bmw5);
            hire1.Hire("Joe");

            Hireable hire2 = new Hireable(specialOffer1);
            hire2.Hire("Jim");


            CyberTruck cyberTruck = new CyberTruck();
            Console.WriteLine("Alap CyberTruck: ");
            Console.WriteLine("Alap ár: {0}, alap tesztkörök: {1}", cyberTruck.HirePrice, cyberTruck.HireLaps);

            SpecialOffer specialOffer2 = new SpecialOffer(cyberTruck);
            specialOffer2.Discount = 10;
            specialOffer2.ExtraLaps = 2;
            Console.WriteLine("Különleges ajánlat: ");
            Console.WriteLine("ára: {0}, {1} körre", specialOffer2.HirePrice, specialOffer2.HireLaps);

            Hireable hire3 = new Hireable(cyberTruck);
            hire3.Hire("Jack");

            Hireable hire4 = new Hireable(specialOffer2);
            hire4.Hire("John");
            
            Console.ReadLine();
        }
    }
}

/*
 Decorator (Díszítő):

szerkezeti tervezési minta, amely átlátszó becsomagolást használ
lehetővé teszi az objektumok dinamikus bővítését anélkül, hogy megváltoztatnánk az eredeti osztályt
az objektum-összetételben szereplő osztályok ugyanazon őstől származnak
amikor alkalmazzuk:
ha új funkciókat akarunk hozzáadni egy osztályhoz anélkül, hogy megváltoztatnánk az eredeti kódot
például: kávé bolt, ahol különböző kávék és extra kérések vannak

működése:
egy absztrakt osztályból indul ki
az absztrakt osztály gyermekei lehetnek alaposztályok és díszítőosztályok
a díszítőosztályok kibővítik a becsomagolt példány funkcionalitását

előnyök:
dinamikusan bővíthető funkcionalitás
az OCP elv betartása

hátrányok:
növeli az osztályok számát és a kód komplexitását
a díszítők láncolása nehézségeket okozhat
 
 */
