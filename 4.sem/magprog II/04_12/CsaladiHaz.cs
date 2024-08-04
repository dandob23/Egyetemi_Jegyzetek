using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_12
{
    internal class CsaladiHaz:Ingatlan
    {
		private int telekSzelesseg;

		public int TelekSzelesseg
		{
			get { return telekSzelesseg; }
			private set 
			{
				if (value<10 || value >100)
				{
					throw new Exception("A telek szelessege 10 es 100 kozott legyen");
				}
				if (value<base.Szelesseg)
				{
					throw new Exception("A telek szelessege nem lehet kisebb a haz szelessegenel");
				}
				telekSzelesseg = value; 
			}
		}

		private int telekHossz;

		public int TelekHossz
		{
			get { return telekHossz; }
			private set
			{
                if (value < 10 || value > 100)
                {
                    throw new Exception("A telek hosszusaga 10 es 100 kozott legyen");
                }
                if (value < base.GetHosszusag())
                {
                    throw new Exception("A telek hosszusaga nem lehet kisebb a haz hosszusaganal");
                }

                telekHossz = value; 
			}
		}

		private int szintek;

		public int Szintek
		{
			get { return szintek; }
			set 
			{
				if (value <1 || value > 3)
				{
					throw new Exception("A szint nem lehet kisebb mint 1 vagy nagyobb mint 3 ");
				}
				this.szintek = value; 
			}
		}

		public override int Alapterulet
		{
			get { return base.Alapterulet * this.Szintek; }
		}





	}
}
