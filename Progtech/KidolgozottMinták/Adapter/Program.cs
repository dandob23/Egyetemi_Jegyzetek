using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot R2D2 = new Robot("R2D2", 80000);
            Ember R2D2wrapper = new Robot2Ember(R2D2);
            Console.WriteLine("Neve: {0}", R2D2wrapper.GetNév());
            Console.WriteLine("IQ-ja: {0}", R2D2wrapper.GetIQ());
            Console.ReadLine();

        }
    }
}

/*
 Adapter (Illesztő):

szerkezeti tervezési minta, amely átalakítja a becsomagolt objektum felületét a kívánt felületre
nem átlátszó becsomagolást használ
célja, hogy egy meglévő osztály felületét hozzáigazítsuk az elvárásainkhoz
amikor alkalmazzuk:
ha egy régebben megírt osztályt akarunk újrahasznosítani egy új osztályhierarchiában
például: európai/angol/amerikai konnektor adapterek

működése:
az illesztő becsomagolja az illesztendő objektumot
az illesztő objektum az új felületet biztosítja

előnyök:
lehetővé teszi a meglévő osztályok újrahasznosítását
könnyen integrálható a meglévő kódhoz

hátrányok:
növeli a kód komplexitását
az illesztő és az illesztendő közötti kompozíció néha bonyolult lehet
 */
