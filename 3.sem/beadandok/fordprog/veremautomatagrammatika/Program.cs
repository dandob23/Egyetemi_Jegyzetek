using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace veremautomatagrammatika
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            List<string> muvelet = new List<string>();
            List<int> szam = new List<int>();
            List<string> nyeltvtan = new List<string>();
            List<int> nullszam = new List<int>();
            int nszam = 0;
            int nmuv = 0;
            bool log = false;
            bool lognyelv = false;
            int szamolo = -1;



            //bekérés
            while (log == false)
            {
                bool intlog = false;
                do
                {
                    Console.Write("Adj meg egy számot: ");
                    string TempSzam = Console.ReadLine();
                    int intszam;
                    bool IsNumeric = int.TryParse(TempSzam, out intszam);
                    
                    if (IsNumeric==true)
                    {
                        szam.Add(intszam);
                        nszam++;
                        szamolo++;
                        intlog = true;
                    }
                    else
                    {
                        szamolo++;
                        nullszam.Add(szamolo);
                        intlog = true;
                    }
                } while (intlog!=true);
                

                bool logbekeres = false;
                const string plusz = "+";
                const string szor = "*";
                const string zaro1 = "(";
                const string zaro2 = ")";
                const string hash = "#";
                do
                {
                    Console.Write("Adj meg egy helyes műveletet ezek közül (");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" +  *  (  ) ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("): ");
                    string TempMuvelet = Console.ReadLine();

                    if (TempMuvelet == plusz || TempMuvelet == szor || TempMuvelet == zaro1 || TempMuvelet == zaro2 || TempMuvelet == hash)
                    {
                        muvelet.Add(TempMuvelet);
                        nmuv++;
                        logbekeres = true;

                    }
                    if (logbekeres == true)
                    {
                        break;
                    }

                } while (logbekeres != true && log == true);

                if (Console.ReadKey(true).Key == ConsoleKey.End)
                {
                    log = true;

                }
            }


            //nyelvtan bekérés
            while (lognyelv == false)
            {
                Console.WriteLine("Add meg a kívánt nyelvtant!: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  E  E'  T  T'  F:  ");
                Console.ForegroundColor = ConsoleColor.White;
                string tempnyelvtan = Console.ReadLine();
                if (tempnyelvtan == "E" || tempnyelvtan == "E'" || tempnyelvtan == "T" || tempnyelvtan == "T'" || tempnyelvtan == "F")
                {
                    lognyelv = true;
                }
                if (lognyelv == true)
                {
                    nyeltvtan.Add(tempnyelvtan);
                }
            }


            //null művelet eltávolítása
            for (int i = 0; i < muvelet.Count; i++)
            {
                if (muvelet[i] == null)
                {
                    muvelet[i].Remove(i);
                    nmuv--;
                }
            }


            //hashmark hozzáadása
            for (int i = 0; i < 1; i++)
            {
                if (muvelet[i] == "#")
                {
                    break;
                }
                else
                {
                    muvelet.Add("#");
                    nmuv++;
                }
            }
            int n = nszam + nmuv;


            //minden kiirasa sorrend nelkul
            Console.WriteLine("----------------------");
            for (int i = 0; i < szam.Count; i++)
            {
                Console.WriteLine(szam[i]);
            }
            Console.WriteLine("\t" + nszam + " db \r\n");
            for (int i = 0; i < muvelet.Count; i++)
            {
                Console.WriteLine(muvelet[i]);
            }
            Console.WriteLine("\t" + nmuv + " db");
            Console.WriteLine("----------------------");


            //művelet kiírás
            int maxszam = Math.Max(szam.Count, muvelet.Count);
            Console.WriteLine("\nA művelet a kövektező!: ");
            bool log1 = false;
            do
            {
                for (int i = 0; i < maxszam; i++)
                {

                    if (i < szam.Count)
                    {
                        Console.Write(szam[i]);
                    }
                    if (i < muvelet.Count)
                    {
                        Console.Write(muvelet[i]);
                    }

                    if (muvelet[i] == "#")
                    {
                        log1 = true;
                        break;
                    }
                }
                if (log1 == true)
                {
                    break;
                }
            } while (log1 != false);


            //konvertált kiirás
            List<string> konv = new List<string>();
            Console.WriteLine("\nKonvertált input: ");
            bool log2 = false;
            do
            {
                for (int j = 0; j < maxszam; j++)
                {
                    if (j < szam.Count)
                    {
                        Console.Write("i");
                        konv.Add("i");
                    }
                    if (j < muvelet.Count)
                    {
                        Console.Write(muvelet[j]);
                        konv.Add(muvelet[j]);
                    }
                    
                    if (muvelet[j] == "#")
                    {
                        log2 = true;
                        break;
                    }

                }
                if (log2 == true)
                {
                    break;
                }
            } while (log2 != false);
            Console.WriteLine(", " + nyeltvtan[0] + ", ");
            int konvszamlalo = konv.Count;

            //táblázat
            if (log == true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("|   |    +   |   *    |    (    |    )    |    i    |    #    |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| E |        |        |  TE',1  |         |  TE',1  |         |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| E'| +TE',2 |        |         |   e,3   |         |   e,3   |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| T |        |        |  FT',4  |         |  FT',4  |         |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| T'|  e,6   | *FT',5 |         |   e,6   |         |   e,6   |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| F |        |        |  (E),7  |         |   i,8   |         |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| + |  pop   |        |         |         |         |         |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| * |        |  pop   |         |         |         |         |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| ( |        |        |   pop   |         |         |         |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| ) |        |        |         |   pop   |         |         |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| i |        |        |         |         |   pop   |         |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("| # |        |        |         |         |         | elfogad |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }


            //számolás
            List<int> muveletszamok = new List<int>();
            bool szamlog = false;
            int popszamlalo = 0;
            szamolaskiiras(konv, nyeltvtan, muveletszamok);
            do
            {
                Nyelvtan(nyeltvtan, konv, muveletszamok, popszamlalo, szamlog);
            } while (szamlog != true);

            Console.ReadKey();
        }

        public static void szamolaskiiras(List<string> konv,List<string> nyeltvtan, List<int> muveletszamok)
        {
            Console.WriteLine("-------------------------------------");
            foreach (string kon in konv)
            {
                Console.Write(kon);
            }
            Console.Write(", ");
            foreach (string nyelv in nyeltvtan)
            {
                Console.Write(nyelv);
            }
            Console.Write(", ");
            foreach (int mszam in muveletszamok)
            {
                Console.Write(mszam);
            }
            Console.WriteLine("\r\n-------------------------------------");
        }
    
        public static void urese(List<string> konv, List<string> nyeltvtan, List<int> muveletszamok, int popszamlalo, bool szamlog )
        {
            if (konv[0] == "#" && nyeltvtan.Count==0)
            {
                Console.WriteLine("elfogad");
                popszamlalo++;
                szamlog = true;
            }
        }

        public static void Nyelvtan(List<string> nyeltvtan, List<string> konv, List<int> muveletszamok, int popszamlalo, bool szamlog)
        {            
            try
            {
                //---------------------------------------------------------------------------//

                if (nyeltvtan[0] == "E" && konv[0] == "(" || nyeltvtan[0] == "E" && konv[0] == "i")
                {
                    nyeltvtan.Remove("E");
                    nyeltvtan.Insert(0, "T");
                    nyeltvtan.Insert(1, "E'");
                    muveletszamok.Add(1);
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                else if (nyeltvtan[0] == "E" && konv[0] != "(" || nyeltvtan[0] == "E" && konv[0] != "i")
                {
                    nyeltvtan.Remove("E");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }

                //---------------------------------------------------------------------------//

                if (nyeltvtan[0] == "E'" && konv[0] == "+")
                {
                    nyeltvtan.Remove("E'");
                    nyeltvtan.Insert(0, "+");
                    nyeltvtan.Insert(1, "T");
                    nyeltvtan.Insert(2, "E'");
                    muveletszamok.Add(2);
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                else if (nyeltvtan[0] == "E'" && konv[0] == ")" || nyeltvtan[0] == "E'" && konv[0] == "#")
                {
                    nyeltvtan.Remove("E'");
                    muveletszamok.Add(3);
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                else if (nyeltvtan[0] == "E'" && konv[0] != ")" || nyeltvtan[0] == "E'" && konv[0] != "#" || nyeltvtan[0] == "E'" && konv[0] != "+")
                {
                    nyeltvtan.Remove("E'");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                
                //---------------------------------------------------------------------------//

                if (nyeltvtan[0] == "T" && konv[0] == "(" || nyeltvtan[0] == "T" && konv[0] == "i")
                {
                    nyeltvtan.Remove("T");
                    nyeltvtan.Insert(0, "F");
                    nyeltvtan.Insert(1, "T'");
                    muveletszamok.Add(4);
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                else if (nyeltvtan[0] == "T" && konv[0] != "(" || nyeltvtan[0] == "T" && konv[0] != "i")
                {
                    nyeltvtan.Remove("T");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                
                //---------------------------------------------------------------------------//

                if (nyeltvtan[0] == "T'" && konv[0] == "+" || nyeltvtan[0] == "T'" && konv[0] == ")" || nyeltvtan[0] == "T'" && konv[0] == "#")
                {
                    nyeltvtan.Remove("T'");
                    muveletszamok.Add(6);
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                else if (nyeltvtan[0] == "T'" && konv[0] == "*")
                {
                    nyeltvtan.Remove("T'");
                    nyeltvtan.Insert(0, "*");
                    nyeltvtan.Insert(1, "F");
                    nyeltvtan.Insert(2, "T'");
                    muveletszamok.Add(5);
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                else if (nyeltvtan[0] == "T'" && konv[0] != "+" || nyeltvtan[0] == "T'" && konv[0] != ")" || nyeltvtan[0] == "T'" && konv[0] != "#" || nyeltvtan[0] == "T'" && konv[0] != "*")
                {
                    nyeltvtan.Remove("T'");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                
                //---------------------------------------------------------------------------//

                if (nyeltvtan[0] == "F" && konv[0] == "(")
                {
                    nyeltvtan.Remove("F");
                    nyeltvtan.Insert(0, "(");
                    nyeltvtan.Insert(1, "E");
                    nyeltvtan.Insert(2, ")");
                    muveletszamok.Add(7);
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                else if (nyeltvtan[0] == "F" && konv[0] == "i")
                {
                    nyeltvtan.Remove("F");
                    nyeltvtan.Insert(0, "i");
                    muveletszamok.Add(8);
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                else if (nyeltvtan[0] == "F" && konv[0] != "(" || nyeltvtan[0] == "F" && konv[0] != "i")
                {
                    nyeltvtan.Remove("F");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                
                //---------------------------------------------------------------------------//
                
                if (nyeltvtan[0] == "+" && konv[0] == "+")
                {
                    nyeltvtan.Remove("+");
                    konv.Remove("+");
                    Console.WriteLine("pop");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                    popszamlalo++;
                }
                else if (nyeltvtan[0] == "+" && konv[0] != "+")
                {
                    nyeltvtan.Remove("+");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                
                //---------------------------------------------------------------------------//

                if (nyeltvtan[0] == "*" && konv[0] == "*")
                {
                    nyeltvtan.Remove("*");
                    konv.Remove("*");
                    Console.WriteLine("pop");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                    popszamlalo++;
                }
                else if (nyeltvtan[0] == "*" && konv[0] != "*")
                {
                    nyeltvtan.Remove("*");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                
                //---------------------------------------------------------------------------//

                if (nyeltvtan[0] == "(" && konv[0] == "(")
                {
                    nyeltvtan.Remove("(");
                    konv.Remove("(");
                    Console.WriteLine("pop");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                    popszamlalo++;
                }
                else if (nyeltvtan[0] == "(" && konv[0] != "(")
                {
                    nyeltvtan.Remove("(");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
               
                //---------------------------------------------------------------------------//

                if (nyeltvtan[0] == ")" && konv[0] == ")")
                {
                    nyeltvtan.Remove(")");
                    konv.Remove(")");
                    Console.WriteLine("pop");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                    popszamlalo++;
                }
                else if (nyeltvtan[0] == ")" && konv[0] != ")")
                {
                    nyeltvtan.Remove(")");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
                
                //---------------------------------------------------------------------------//


                if (nyeltvtan[0] == "i" && konv[0] == "i")
                {
                    nyeltvtan.Remove("i");
                    konv.Remove("i");
                    Console.WriteLine("pop");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                    popszamlalo++;
                }
                else if (nyeltvtan[0] == "i" && konv[0] != "i")
                {
                    nyeltvtan.Remove("i");
                    szamolaskiiras(konv, nyeltvtan, muveletszamok);
                    urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                szamlog = true;
                return;
            }


        }
    }
}

