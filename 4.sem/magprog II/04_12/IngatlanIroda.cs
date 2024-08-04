using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_12
{
    internal class IngatlanIroda
    {

		private List<Ingatlan> ingatlanok=new List<Ingatlan>();

		public List<CsaladiHaz> CsaladiHazak
		{
			get
			{
				List<CsaladiHaz> UjLista = new List<CsaladiHaz>();
				for (int i = 0; i < ingatlanok.Count; i++)
				{
					if (ingatlanok[i] is CsaladiHaz)
					{
						CsaladiHaz temp = ingatlanok[i] as CsaladiHaz;

						CsaladiHaz masolat = new CsaladiHaz(
							temp.HelyrajziSzam,
							temp.Szelesseg,
							temp.GetHosszusag(),
							temp.Allapot,
							temp.TelekSzelesseg,
							temp.TelekHossz,
							temp.Szintek);


						UjLista.Add(masolat);
					}
				}
				return UjLista;
			}
		}

		public CsaladiHaz LCSFCSH
		{
			get
			{
				CsaladiHaz nincs = null;
				bool VanCsaladiHaz;
				foreach (Ingatlan i in ingatlanok)
				{
					if (i is CsaladiHaz)
					{
						VanCsaladiHaz = true;
						if (i.Allapot == Allapot.Felujitando &&(nincs==null || i.Vetelar()<nincs.Vetelar()))
						{
							CsaladiHaz s = i as CsaladiHaz;
							nincs = new CsaladiHaz(
								s.HelyrajziSzam,
								s.Szelesseg,
								s.GetHosszusag(),
								s.Allapot,
								s.TelekSzelesseg,
								s.TelekHossz,
								s.Szintek);
						}
					}

				}
				if (nincs == null)
				{
					throw new Exception("Nincs csaladi haz a listaban");
				}

				CsaladiHaz s = new CsaladiHaz(
					nincs.HelyrajziSzam,
					nincs.Szelesseg,
					nincs.GetHosszusag(),
					nincs.Allapot,
					nincs.TelekSzelesseg,
					nincs.TelekHossz,
					nincs.Szintek);

				return s;
			}
		}

		public Ingatlan this[string index]
		{
			get
			{
				Ingatlan keresett = null;
				for (int i = 0; i < ingatlanok.Count; i++)
				{
					if (ingatlanok[i].HelyrajziSzam==index)
					{
						keresett = ingatlanok[i];
						break;
					}
				}
				if (keresett==null)
				{
					//throw new Exception("nincs ilyen helyrajzi szamu ingatlan a listaban");

					throw new IndexOutOfRangeException();
				}
				return keresett;
			}
		}

		public void AddIngatlan(Ingatlan newIngatlan)
		{
			if (ingatlanok.Contains(newIngatlan))
			{
				throw new Exception("asd");
			}
			ingatlanok.Add(newIngatlan);
		}

		public List<CsaladiHaz> CsaladiHazAdottArig(Allapot allapot, int maxAr)
		{
			List<CsaladiHaz> temp = new List<CsaladiHaz>();
			for (int i = 0; i < temp.Count; i++)
			{
				if (ingatlanok[i] is CsaladiHaz && ingatlanok[i].Allapot==allapot && ingatlanok[i].Vetelar()<maxAr)
				{
					temp.Add(ingatlanok[i] as CsaladiHaz);
				}
			}
			return temp;
		}

	}
}
