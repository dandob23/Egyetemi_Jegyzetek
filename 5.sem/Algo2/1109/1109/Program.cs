using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ElsoFeladat = new List<int>() {20,30,12,4};
            Torles(ElsoFeladat);
            Console.WriteLine("----------------------------");
            HozzaAdas(ElsoFeladat);

            //---------------------------------//

            int[,] MasodikFeladatTomb = { { 20,5 }, { 0,0},{ 4,-1},{ 0,0},{ 0,0},{ 30,8},{ 0,0},{ 0,0},{ 12,2},{ 0, 0} };


            Console.ReadKey();
        }
        #region ElsoFeladat
        public static void Torles(List<int> ElsoFeladat)
        {
            /*
             1.feladat:
            hozzunk létre egy listát 
            fej -> 20 -> 30 -> 12 -> 4
            a) töröljünk belőle egy elemet (12 törlése: 30 -> -12- -> 4)
            b) szúrjunk be egy új elemet a listába (10 et: fej -> 10 -> 20 -> 30) 
             */
            Console.WriteLine("Az jelenlegi lista elemek: ");
            foreach (int szam in ElsoFeladat)
            {
                Console.WriteLine(szam);
            }
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("A törlés utáni elemek: ");
            ElsoFeladat.Remove(12);
            foreach (int torlesUtan in ElsoFeladat)
            {
                Console.WriteLine(torlesUtan);
            }

        }
        public static void HozzaAdas(List<int> ElsoFeladat)
        {
            int hozzaadandoszam = 10;
            Console.WriteLine("Az jelenlegi lista elemek: ");
            foreach (int szam in ElsoFeladat)
            {
                Console.WriteLine(szam);
            }
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine("A hozzáadás utáni elemek: ");
            for (int i = 0; i < ElsoFeladat.Count; i++)
            {
                while (!(hozzaadandoszam>i))
                {
                    if (i <= hozzaadandoszam)
                    {
                        ElsoFeladat.Add(hozzaadandoszam);
                    }
                    else
                    {
                        ElsoFeladat.Add(hozzaadandoszam - ElsoFeladat[i]);
                    }
                }
            }
            
            foreach (int hozzaadasUtan in ElsoFeladat)
            {
                Console.WriteLine(hozzaadasUtan);
            }
        }
        #endregion


        #region MasodikFeladat
        /*
         2.feladat:
        ugyanezt valositsuk meg egy tombbel
        
        12 torlese
        fej = 0
        kulcs 0.0 -> 20; 0.1 ->0; 0.2 -> 4; 0.3 -> 0; 0.4 -> 0; 0.5 -> 30; 0.6 -> 0; 0.7 -> 0; 0.8 -> 12; 0.9 -> 0
        kor 0.0 -> 5; 0.1 -> 0; 0.2 -> -1; 0.3 -> 0; 0.4 -> 0; 0.5 -> 8; 0.6 -> 0; 0.7 -> 0; 0.8 -> 2; 0.9 -> 0
        ha fej = -1, akkor "üres lista"
        egyebkent i = fej, ki: A[i,0]
            while ( ha i!= -1 akkor
                    i = A[i,1]
                    ki  A[i,0]

        10 beszurasa
        keressunk egy olyan j indexet hogy A[j,0]=0  j=1
        while(A[j,0]
        j = j+1
        A[j,0] = 10;
        A[j,1] = fej;
        fej=j;
         */

        public static int MasodikFeladatTorles(int[,] MasodikFeladatTomb)
        {
            int fej = 0;
            for (int i = 0; i < MasodikFeladatTomb.Length; i++)
            {
                if (fej == -1)
                {
                    return MasodikFeladatTomb[0,0];
                }
                else if (i == fej)
                {
                    return MasodikFeladatTomb[i, 1];
                }
                while (i != -1)
                {
                    i = MasodikFeladatTomb[i, 1];
                    return MasodikFeladatTomb[i, 0];
                }
            }            
        }

        public static int MasodikFeladatHozzaadas(int[,] MasodikFeladatTomb)
        {

        }

        #endregion
    }

}

