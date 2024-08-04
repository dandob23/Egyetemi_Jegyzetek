using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Almafa ";
            string str2 = "Körtefa";
            string str3 = str1 + str2 + " Barackfa";
            Console.WriteLine(str3);
            int szokoz = str3.IndexOf(" ");
            Console.WriteLine(szokoz);
            string str4 = str3.Substring(szokoz + 1);
            Console.WriteLine(str4);
            str4 = str3.Substring(0, szokoz);
            Console.WriteLine(str4);
            str4 = str3.Substring(str3.LastIndexOf(" ") + 1);
            Console.WriteLine(str4);
            Console.ReadKey();
        }
    }
}
