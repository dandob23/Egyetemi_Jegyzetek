using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
            {
                do
                {
                    if (nyeltvtan[0] == "#")
                    {
                        if (konv[0] == "#")
                        {
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                            szamlog = true;
                        }
                    }

                    if (nyeltvtan[0] == "E")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("E");
                            break;
                        }
                        if (konv[0] == "(" || konv[0] == "i")
                        {
                            nyeltvtan.Remove("E");
                            nyeltvtan.Insert(0, "T");
                            nyeltvtan.Insert(1, "E'");
                            muveletszamok.Add(1);
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                        else
                        {
                            nyeltvtan.Remove("E");
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }



                    }
                    if (nyeltvtan[0] == "E'")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("E'");
                            muveletszamok.Add(3);
                            break;
                        }
                        if (konv[0] == "+")
                        {
                            nyeltvtan.Remove("E'");
                            nyeltvtan.Insert(0, "+");
                            nyeltvtan.Insert(1, "T");
                            nyeltvtan.Insert(2, "E'");
                            muveletszamok.Add(2);
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                        if (konv[0] == ")" || konv[0] == "#")
                        {
                            nyeltvtan.Remove("E'");
                            muveletszamok.Add(3);
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                        else
                        {
                            nyeltvtan.Remove("E'");
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                    }
                    if (nyeltvtan[0] == "T")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("T");
                            break;
                        }
                        if (konv[0] == "(" || konv[0] == "i")
                        {
                            nyeltvtan.Remove("T");
                            nyeltvtan.Insert(0, "F");
                            nyeltvtan.Insert(1, "T'");
                            muveletszamok.Add(4);
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                        else
                        {
                            nyeltvtan.Remove("T");
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                    }
                    if (nyeltvtan[0] == "T'")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("T'");
                            muveletszamok.Add(6);
                            break;
                        }
                        if (konv[0] == "+" || konv[0] == ")" || konv[0] == "#")
                        {
                            nyeltvtan.Remove("T'");
                            muveletszamok.Add(6);
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                        if (konv[0] == "*")
                        {
                            nyeltvtan.Remove("T'");
                            nyeltvtan.Insert(0, "*");
                            nyeltvtan.Insert(1, "F");
                            nyeltvtan.Insert(2, "T'");
                            muveletszamok.Add(5);
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                        else
                        {
                            nyeltvtan.Remove("T'");
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                    }
                    if (nyeltvtan[0] == "F")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("F");
                            break;
                        }
                        if (konv[0] == "(")
                        {
                            nyeltvtan.Remove("F");
                            nyeltvtan.Insert(0, "(");
                            nyeltvtan.Insert(1, "E");
                            nyeltvtan.Insert(2, ")");
                            muveletszamok.Add(7);
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                        if (konv[0] == "i")
                        {
                            nyeltvtan.Remove("F");
                            nyeltvtan.Insert(0, "i");
                            muveletszamok.Add(8);
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                        else
                        {
                            nyeltvtan.Remove("F");
                            szamolaskiiras(konv, nyeltvtan, muveletszamok);
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                        }
                    }
                    if (nyeltvtan[0] == "+")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("F");
                            break;
                        }
                        if (konv[0] == "+")
                        {
                            nyeltvtan.Remove("+");
                            konv.RemoveAt(0);
                            Console.WriteLine("pop");
                            popszamlalo++;
                        }
                    }
                    if (nyeltvtan[0] == "*")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("F");
                            break;
                        }
                        if (konv[0] == "*")
                        {
                            nyeltvtan.Remove("*");
                            konv.RemoveAt(0);
                            Console.WriteLine("pop");
                            popszamlalo++;
                        }
                    }
                    if (nyeltvtan[0] == "(")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("F");
                            break;
                        }
                        if (konv[0] == "(")
                        {
                            nyeltvtan.Remove("(");
                            konv.RemoveAt(0);
                            Console.WriteLine("pop");
                            popszamlalo++;
                        }
                    }
                    if (nyeltvtan[0] == ")")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("F");
                            break;
                        }
                        if (konv[0] == ")")
                        {
                            nyeltvtan.Remove(")");
                            konv.RemoveAt(0);
                            Console.WriteLine("pop");
                            popszamlalo++;
                        }
                    }
                    if (nyeltvtan[0] == "i")
                    {
                        if (popszamlalo + 1 == konvszamlalo && nyeltvtan.Count == 1)
                        {
                            nyeltvtan.Remove("F");
                            break;
                        }
                        if (konv[0] == "i")
                        {
                            nyeltvtan.Remove("i");
                            konv.RemoveAt(0);
                            Console.WriteLine("pop");
                            popszamlalo++;
                        }
                    }
                    if (nyeltvtan[0] == "#")
                    {
                        if (konv[0] == "#")
                        {
                            urese(konv, nyeltvtan, muveletszamok, popszamlalo, szamlog);
                            szamlog = true;
                        }
                    }


                } while (szamlog != true);

            }
        }
    }
}
