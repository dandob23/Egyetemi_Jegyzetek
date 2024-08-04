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
            Console.WriteLine(Szamolgat(str3, " "));
            string[] strtomb = new string[Szamolgat (str3, " ")];
            strtomb = str3.Split(' ');
            foreach (string s in strtomb)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(str3.Substring(str3.IndexOf(" ") +1,str3.LastIndexOf(" ")-str3.IndexOf(" ")-1));
            Console.WriteLine(str3.Length);
            Console.WriteLine(str3.ToUpper());
            Console.WriteLine(str3.ToLower());
            Fatlanit(strtomb);
            foreach (string s in strtomb)
            {
                Console.WriteLine(s);
            }



            Console.ReadKey();
        }
        static int Szamolgat(string ben, string mit)
        {
            int count = 0;
            bool fut = true;
            int hol = ben.IndexOf(mit);
            if (hol == -1)
                fut = false;
            while (fut)
            {
                count++;
                ben = ben.Substring(hol + 1);
                hol = ben.IndexOf(mit);
                if (hol == -1)
                    fut = false;
            }
            return count;
        }
        static void Fatlanit(string[] ben)
        {
            for (int i = 0; i < ben.Length; i++)            
            {
                string s = ben[i];
                ben[i] = s.Substring(0, s.IndexOf("fa"));
            }
        }
    }
}
