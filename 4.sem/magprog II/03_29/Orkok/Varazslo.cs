using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orkok
{
    class Varazslo:Ork
    {
        public Varazslo(int id, string nev, Varazslat varazslat) : base(id, nev)
        {
            this.Varazslat = varazslat;
            this.Mana = 40;
        }

        private Varazslat varazslat;

        public Varazslat Varazslat 
        {
            get { return varazslat; }
            set { varazslat = value; }
        }

        protected int Mana { get; set; }

        private bool HasznaltVarazslatot
        {
            set { value = false; }
        }

        public override int Sebzes
        {
            get
            {
                return (int)(base.Sebzes * this.Varazslat.Szorzo);
            }
        }

        public override int Sebzodik(Varazslo varazslo, Varazslat varazslat)
        {
            if (varazslo.Mana >= varazslat.Koltseg)
            {
                _ = varazslat.Koltseg - varazslo.Mana;

                return (int)(base.Sebzes * this.Varazslat.PajzsSzorzo);
            }
        }
        

        protected override void Tamad(Ork ellenfel)
        {
            if (!ellenfel.Halott)
                base.Tamad(ellenfel);
        }

        public override void TamadAnimacio(Ork ellenfel)
        {
            if (ellenfel.Halott)
            {
                Console.WriteLine("{0} nem támadja meg {1}, mert távoll áll tőle a hullagyalázás!", this.Nev, ellenfel.Nev);
            }
            else
            {
                Console.WriteLine("{0} megtámadta egy fegyverrel {1}-t", this.Nev, ellenfel.Nev);
            }
        }


    }
}
