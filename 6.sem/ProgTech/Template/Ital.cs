using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Ital
    {
        public void Elkészít()
        {
            vízforraló();// kötelező és közös lépés
            főz(); // inversion of control, mert a gyermek főz metódusa fog futni
            édesít(); // kötelező és nem közös lépés
            rum();    // opcionális
            kitölt(); // kötelező és közös lépés
        }
        private void vízforraló() // kötelező közös lépés
        {// Ennek szintén nem kell felűlírhatónak lennie
            Console.WriteLine("Víz forralás folyamatban...");
            Console.WriteLine("...50%");
            Console.WriteLine("...80%");
            Console.WriteLine("...100%");
        }
        protected abstract void főz(); // Ki kell dolgoznia a konkrét osztálynak.
        protected abstract void édesít(); //kötelező nem közös lépés
        protected virtual void rum() { } // opcionális lépés (ezért hook)
        private void kitölt() // kötelező közös lépés
        {
            Console.WriteLine("Kiöntöm az italt...\n");
        }
    }
}
