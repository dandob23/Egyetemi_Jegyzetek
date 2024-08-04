using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0301
{
    internal class Diak
    {

        public string nev;
        public Lakcim lakcim;
        public Tagozat tagozat;
        public DateTime szuletesnap;
        private int kezdes;
        private double atlag;

        public double GetAtlag()
        {
            return atlag;
        }

        public void SetAtlag(double Atlag)
        {
            if (atlag! <= 1 || atlag! >= 5) 
            {
                throw new Exception("Az átlag csak 1 és 5 között lehet");
            }
            else
            {
                atlag = Atlag;
            }
        }



        public int GetKezdesEve()
        {
            return kezdes;
        }
        public void SetKezdesEve(int kezdeseve)
        {
            if (kezdes<1900)
            {
                throw new Exception("A kezdés éve túl kicsi");
            }
            else
            {
                kezdes = kezdeseve;
            }
        }

        public int KezdesEve
        {
            get {
                return KezdesEve;
            }
            set 
            {
                if (value < 1900)
                {
                    throw new Exception("Nem megfelelő év");
                } 
            }
        }

        public void Kiir()
        {

            Console.WriteLine($"Név: {nev}");
            Console.WriteLine("Születés nap: {0}",szuletesnap);
            Console.WriteLine("Lakcím: {0} {1} {2}", lakcim.iranyitoszam, lakcim.utcanev, lakcim.hazszam);
            Console.WriteLine("Tagozat: {0}", tagozat);
            Console.WriteLine("Kezdés éve: {0}",kezdes);
            Console.WriteLine("______________________________");

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format($"Név: {nev}\n"));
            sb.Append(string.Format("Születés nap: {0}\n", szuletesnap));
            sb.Append(string.Format("Lakcím: {0} {1} {2}\n", lakcim.iranyitoszam, lakcim.utcanev, lakcim.hazszam));
            sb.Append(string.Format("Tagozat: {0}\n", 
                TagozatFormatter.Format(tagozat)));
            sb.Append(string.Format("Kezdés éve: {0}\n", kezdes));

            return sb.ToString();
        }
    }
}
