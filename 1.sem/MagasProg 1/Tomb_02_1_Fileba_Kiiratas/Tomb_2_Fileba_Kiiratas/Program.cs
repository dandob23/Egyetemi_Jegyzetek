using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //FONTOS A FILEKEZELESHEZ

namespace Tomb_2_Fileba_Kiiratas
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
                Console.WriteLine("{0} ", t[i]);
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
            Console.ReadKey();
        }
    }
}
