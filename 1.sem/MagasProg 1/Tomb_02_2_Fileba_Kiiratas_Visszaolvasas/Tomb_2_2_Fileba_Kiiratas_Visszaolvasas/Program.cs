using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //FONTOS A FILEKEZELESHEZ

namespace Tomb_2_2_Fileba_Kiiratas_Visszaolvasas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[10];
            for (int i = 0; i < 10; i++)
            {
                t[i] = i * 2 + 2;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", t[i]);
            }
            //Filekez
            StreamWriter wfile = File.CreateText("szamok.txt");
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    wfile.WriteLine(t[i]);
                }
            }
            catch (IOException io)
            {
                Console.WriteLine(io.ToString());
            }
            finally
            {
                wfile.Close();
            }
            //eddig a kiiras
            //innentol a beolvasas
            Console.WriteLine();
            List<int> lis = new List<int>();
            StreamReader rfile = File.OpenText("szamok.txt");
            try
            {
                string s = rfile.ReadLine();
                while (s != null)
                {
                    lis.Add(int.Parse(s));
                    s = rfile.ReadLine();
                }
            }
            catch (IOException io)
            {
                Console.WriteLine(io.ToString());
            }
            finally
            {
                rfile.Close();
            }
            for (int i = 0; i < lis.Count; i++)
            {
                Console.Write("{0} ", lis[i]);
            }
            Console.ReadKey();
        }
    }
}
