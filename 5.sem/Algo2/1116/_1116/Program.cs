using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region JEGYZET
            /*
             fej = 3
            0.0 = 11, 0.1 = 7; 0.2 = 4;
            1.0 = -1; 1.1 = -1; 1.2 = -1;
            2.0 = -1; 2.1 = -1; 2.2 = -1;
            3.0 = 23; 3.1 = -1; 3.2 = 7;
            4.0 = 19; 4.1 = 3; 4.2 = -1;
            5.0 = -1; 5.1 = -1; 5.2 = -1;
            6.0 = 17; 6.1 = 0; 6.2 = 4;
            7.0 = 38; 7.1 = 3; 7.2 = 0;
            8.0 = -1; 8.1 = -1; 8.2 = -1;
            9.0 = -1; 9.1 = -1; 9.2 = -1;
             kulcs    előszó   következő

            szabad = {1,2,5,8,9}

            1) irassuk ki a listát! /következő mutató/
            23, 38, 11, 17, 19

            2) töröljük ki a 17 -et
            1.lépés i = 6 (megkeressük)
            2. lépés A[A[6;1];2] = A [6;2]
            3.lépés A[A[6;2];1] = A [6;1]
            4.lépés szabad.adat = 6
            
            3)szúrjunk be egy elemet (88)
            a) a lista elejére
            b) a lista végére
            c) egy adat helyére
            */
            #endregion

            int fej = 3;
            int[,] tabla = new int[10, 3] {
            { 11, 7, 6}, { -1, -1, -1 }, { -1, -1, -1 }, { 23, -1, 7 },
            { 19, 3, -1 }, { -1, -1, -1 }, { 17, 0, 4 }, { 38, 3, 0 },
            { -1, -1, -1 }, { -1, -1, -1 }};

            //1) feladat
            ListaKiir(tabla);

            //2) feladat
            ListaTorol(tabla, 17);

            //3) feladat
            //a)
            ListaBeszurA(tabla, 88);
            //b)
            ListaBeszurB(tabla, 88);
            //c)
            ListaBeszurC(tabla, 88, 23);


            Console.ReadKey();
        }

        public static void ListaKiir(int[,] tabla)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("A lista jelenleg: \n");
            Console.WriteLine("[\n");
            int szamlalo = 1;

            foreach (int item in tabla)
            {
                if (szamlalo ==3)
                {
                    Console.Write(item + ", ");
                    Console.WriteLine("\n");
                    szamlalo = 1;
                }
                else
                {
                    Console.Write(item + ", ");
                    szamlalo++;
                }
            }
            Console.WriteLine("]");
            Console.WriteLine("---------------------------------------");
        }

        public static void ListaTorol(int[,] tabla, int torlesSzam)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"\t2) Listából törlés ({torlesSzam})");
            ListaKiir(tabla);
            int torlesIndex = -1;
            for (int i = 0; i < 10; i++)
            {
                if (tabla[i, 0] == torlesSzam)
                {
                    torlesIndex = i;
                    break;
                }
            }
            if (torlesIndex != -1)
            {
                tabla[tabla[torlesIndex, 1], 2] = tabla[torlesIndex, 2];
                tabla[tabla[torlesIndex, 2], 1] = tabla[torlesIndex, 1];
                tabla[torlesIndex, 0] = -1;
            }
            ListaKiir(tabla);
            Console.WriteLine("\n");
            Console.WriteLine("=======================================");
        }

        public static void ListaBeszurA(int[,] tabla, int elem)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"\t3/a) A listába beszúrás az elejére ({elem})");
            ListaKiir(tabla);
            for (int i = 0; i < 10; i++)
            {
                if (tabla[i,0] == -1)
                {
                    tabla[i, 0] = elem;
                    tabla[i, 1] = -1;
                    tabla[i, 2] = tabla[0, 1];
                    tabla[0, 1] = i;
                    break;
                }
            }
            ListaKiir(tabla);
            Console.WriteLine("\n");
            Console.WriteLine("=======================================");
        }

        public static void ListaBeszurB(int[,] tabla, int elem)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"\t3/b) A listába beszúrás a végére ({elem})");
            ListaKiir(tabla);
            for (int i = 0; i < 10; i++)
            {
                if (tabla[i, 0] == -1)
                {
                    tabla[i, 0] = elem;
                    tabla[i, 1] = i -1;
                    tabla[i - 1, 2] = i;
                    tabla[i, 2] = -1;
                    break;
                }
            }
            ListaKiir(tabla);
            Console.WriteLine("=======================================");
            Console.WriteLine("\n");
        }

        public static void ListaBeszurC(int[,] tabla, int elem, int beszurUtana)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"\t3/c) A listába beszúrás egy adat helyére (ezt: {elem}, e helyére: {beszurUtana})");
            ListaKiir(tabla);
            for (int i = 0; i < 10; i++)
            {
                if (tabla[i, 0] == beszurUtana)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (tabla[j, 0] == -1)
                        {
                            tabla[j, 0] = elem;
                            tabla[j, 1] = i;
                            tabla[j, 2] = tabla[i, 2];
                            tabla[i, 2] = j;
                            break;
                        }
                    }
                    break;
                }
            }
            ListaKiir(tabla);
            Console.WriteLine("\n");
            Console.WriteLine("=======================================");
        }
    }
}
