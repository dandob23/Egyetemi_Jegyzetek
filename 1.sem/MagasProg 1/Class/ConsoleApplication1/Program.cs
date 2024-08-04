using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Beosztott
    {
        public string nev;
        public byte kor;
        public int fizetes;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Beosztott beoszt = new Beosztott();
            beoszt.nev = "Béla";
            beoszt.kor = 28;


            Console.WriteLine(beoszt.nev);
            Console.WriteLine(beoszt.kor);
            Console.ReadKey();

        }
    }
}
