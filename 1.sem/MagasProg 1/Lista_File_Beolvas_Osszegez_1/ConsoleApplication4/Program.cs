using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //FONTOS A FILEKEZELESHEZ

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<int> lis = new List<int>();
            StreamReader rfile = File.OpenText("paros.txt");
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
            int sum = 0;
            for (int i = 0; i < lis.Count; i++)
            {
                sum = sum + lis[i];
            }
            Console.WriteLine();
            Console.WriteLine("{0}", sum);
        

            Console.ReadKey();

        }
    }
}
