using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diakok_05_04
{
    internal class Program
    {
        static Random rnd = new Random();

        static List<string> noiNevek = new List<string> { "Ágnes", "Linda", "Diána", "Lili", "Zsófia", "Klára,", "Edit", "Margit", "Klaudia", "Fanni", "Klotild", "Eszter" };

        static List<string> ferfiNevek = new List<string> { "Roland", "Tihamér", "Pál", "László", "Sándor", "József", "Benedek", "Gáspár", "Menyhért", "Péter", "Tamás" };

        static List<string> vezetekNevek = new List<string> { "Szabó", "Kovács", "Barna", "Gál", "Molnár", "Juhász", "Szakács", "Takács", "Kádár", "Kis", "Nagy" };

        static List<string> varosok = new List<string> { "Eger", "Debrecen", "Miskolc", "Őrhalom", "Hugyag", "Pécs" };




        static void Feltolt(int db, Diakok diakok)
        {
            for (int i = 0; i < db; i++)
            {
                Gender gender = (Gender)rnd.Next(3);
                string keresztNev = "";

                switch (gender)
                {
                    case Gender.Ferfi:
                        keresztNev = ferfiNevek[rnd.Next(ferfiNevek.Count)];
                        break;
                    case Gender.No:
                        keresztNev = noiNevek[rnd.Next(noiNevek.Count)];
                        break;
                    case Gender.Egyéb:
                        keresztNev = rnd.NextDouble() < 0.5 ? ferfiNevek[rnd.Next(ferfiNevek.Count)] : noiNevek[rnd.Next(noiNevek.Count)];
                        break;
                }

                Diak diak = new Diak(
                    vezetekNevek[rnd.Next(vezetekNevek.Count)],
                    keresztNev,
                    new DateTime(rnd.Next(1985, 2004), rnd.Next(1, 13), rnd.Next(1, 28)),
                    gender,
                    varosok[rnd.Next(varosok.Count)],
                    (double)rnd.Next(100, 501) / 100
                    );

                diakok.AddDiak(diak);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
