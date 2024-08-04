using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        // statikus mező az egyetlen példány számára
        private static Singleton uniqueInstance = null;
        // privát konstruktor, hogy ne lehessen 'new' kulcsszóval példányosítani
        private Singleton() { }
        // biztosítja számunkra a példányosítást és egyben visszaadja a példányt
        // mindenkinek ugyanazt
        public static Singleton GetInstance()
        {
            if (uniqueInstance == null) // megvizsgálja, hogy létezik-e már egy példány
            {
                uniqueInstance = new Singleton(); // ha nem, akkor létrehozza azt
            }
            // visszaadja a példányt
            return uniqueInstance;
        }
    }
}
