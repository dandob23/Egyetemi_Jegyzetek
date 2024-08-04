using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersenyzoDLL
{
    internal class Versenyzo : IVersenyzo
    {

        public Versenyzo(string nev, string csapat, int perc, int masodperc, int millisec)
        {
            this.Nev = nev;
            this.Csapat = csapat;
            this.KorIdo = new TimeSpan(0, 0, perc, masodperc, millisec);

        }

        public string Nev { get; }

        public string Csapat { get; }

        
        //eltelt ido
        public TimeSpan KorIdo { get; private set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new Exception("Null-al nem lehet összehasonlítani");

            }

            if (obj is Versenyzo)
            {
                throw new Exception("A kapott objekt nem versenyző");

            }

            Versenyzo masik = obj as Versenyzo;

            if (this.KorIdo < masik.KorIdo)
            {
                return -1;
            }
            else if (this.KorIdo == masik.KorIdo)
            {
                return 0;
            }
            else
            {
                return 1;
            }


        }
    }
}
