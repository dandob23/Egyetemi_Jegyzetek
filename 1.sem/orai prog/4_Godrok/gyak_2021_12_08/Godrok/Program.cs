using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Godrok
{
    class Gödör
    {
        public int mélység;
        public double térfogat;
        public int gödkezd;
        public int végződik;
    }
    class Program
    {

        static string[] forrás;

    static List<Gödör> lista = new List<Gödör>();
        static void Main(string[] args)
        {
            beolv();

            lépmely();
            szazalek();

            
            Console.ReadLine();
        }
        static void beolv()
        {
            forrás = File.ReadAllLines("melyseg.txt");
            Console.WriteLine("elemű: {0} ",forrás.Length);
        }
        static void lépmely()
        {
            Console.WriteLine("adj egy számot: ");
            int szám = int.Parse(Console.ReadLine());

            Console.WriteLine(forrás[szám-1]);

            
        }
        static void szazalek ()
        {
            double összmez =forrás.Length;
            double érintetlen =0;
            for (int i = 0; i < forrás.Length; i++)
            {
                if (forrás[i]=="0")
                {
                    érintetlen++;
                }
            }
            double kiszam = (érintetlen % összmez) ;
            Console.WriteLine(kiszam);
        }

    }
}
