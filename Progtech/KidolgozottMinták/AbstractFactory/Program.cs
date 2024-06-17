using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoGyar gyár = new OpelGyar();
            Alvaz alváz1 = gyár.CreateAlvaz();
            Motor motor1 = gyár.CreateMotor();
            Console.WriteLine("Létrehozott egy {0} alvázat és egy {1} motort.", alváz1.GetType().Name, motor1.GetType().Name);
            Console.ReadLine();

        }
    }
}

/*
 Abstract Factory (Absztrakt gyár):

létrehozási tervezési minta, amely több, egymással együttműködő objektumot gyárt
több létrehozásra alkalmas metódust tartalmaz
amikor alkalmazzuk:
ha egyszerre több dolgot gyártunk, amelyeknek összeépíthetőnek kell lenniük
például: operációs rendszerhez (Windows, Mac, Linux) tartozó gombok és ablakok gyártása

működése:
az absztrakt gyár tartalmazza a gyártásra szolgáló metódusokat
a konkrét gyárak implementálják ezeket a metódusokat

előnyök:
biztosítja az összefüggő objektumok létrehozását
könnyen bővíthető új termékcsaládokkal

hátrányok:
növeli az osztályok számát és a kód komplexitását
 */
