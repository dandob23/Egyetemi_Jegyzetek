using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_12
{
    internal class Ingatlan
    {
		private string helyrajziSzam;

		public string HelyrajziSzam
		{
			get { return helyrajziSzam; }
			private set 
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("A helyrajzi szám nem megfelelő");

				foreach (char karakter in value)
				{
					if (!(char.IsNumber(karakter)||karakter=='/'))
					{
						throw new Exception("A helyrajzi szám csak számokat, illetve '/' karaktert tartalmazhat!");
					}
				}
				if (value[0]=='/')
				{
					throw new Exception("az elso karakternek szamnak kell lennie");
				}

				if (value[value.Length-1]=='/')
				{
					throw new Exception("Az utolso kar '/' nek kell lennie");
				}

				if (value[0]=='0')
				{
					throw new Exception("az elso kar nem lehet 0");
				}

				helyrajziSzam = value; 
			}
		}

		private bool szelessegBeallitva;

		private int szelesseg;

		public int Szelesseg
		{
			get { return szelesseg; }
			private set 
			{
				if (value < 4)
				{
					throw new Exception("A szelesseg erteke tul alacsony");
				}
				if (value>20)
				{
					throw new Exception("A szelesseg erteke tul nagy");
				}
				if (szelessegBeallitva==true)
				{
					throw new Exception("A szelesseg mar be lett allitva");
				}
				szelesseg = value;
				szelessegBeallitva = true;
			}
		}

		private bool hosszusagBeallitva;
		private int hosszusag;
		public int GetHosszusag()
		{
			return hosszusag;
		}
		private void SetHosszusag(int hosszusag)
		{
            if (hosszusag < 4)
            {
                throw new Exception("A hosszusag erteke tul alacsony");
            }
            if (hosszusag > 20)
            {
                throw new Exception("A hosszusag erteke tul nagy");
            }
            if (hosszusagBeallitva == true)
            {
                throw new Exception("A hosszusag mar be lett allitva");
            }
			this.hosszusag = hosszusag;
			szelessegBeallitva = true;
			
        }

		
		public Allapot Allapot
		{
			get;set;
		}
		public virtual int Alapterulet
		{
			get
			{
				return hosszusag * szelesseg;
			}
		}

		public Ingatlan(string helyrajziSzam, int szelesseg, int hossz, Allapot allapot)
		{
			this.HelyrajziSzam = helyrajziSzam;
			this.Szelesseg = szelesseg;
			this.SetHosszusag(hossz);
			this.Allapot = allapot;
		}
 
		public Ingatlan(string helyrajziSzam, int szelesseg, int hossz) : this(helyrajziSzam, szelesseg, hossz, Allapot.Ujepitesu)
		{

		}


		public int Vetelar()
		{
			switch (Allapot)
			{
				case Allapot.Ujepitesu:
					return Alapterulet * 600000;
				case Allapot.Korszerusitett:
					return Alapterulet * 500000;
				case Allapot.Felujitott:
                    return Alapterulet * 450000;
                case Allapot.Felujitando:
                    return Alapterulet * 300000;
                default:
					throw new Exception("Nincs ilyen állapot");
			}
		}

		public override string ToString()
		{
			return string.Format("Helyrajzi szám: {0}\nSzélesség: {1}\nHossz: {2}\nÁllapot: {3}\nAlapterület: {4}\nVételár: {5}",this.HelyrajziSzam, this.Szelesseg, this.GetHosszusag(),	
				this.Allapot,this.Alapterulet,this.Vetelar());	
		}

		public override bool Equals(object obj)
		{
			if (obj is null)
			{
				return false;
			}
			if (!(obj is Ingatlan))
			{
				return false;
			}
			Ingatlan ingatlan2 = obj as Ingatlan;
			return this.HelyrajziSzam == ingatlan2.HelyrajziSzam;
		}
	}
}
