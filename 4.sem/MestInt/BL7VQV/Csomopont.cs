using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    public class Csomopont
    {
        public State Allapot { get; set; } 
        public Csomopont Szulo { get; set; } 
        public int Melyseg { get; set; } 
        public int OperatorIndex { get; set; } 
        public bool Celfeltel { get; set; } 

        public Csomopont(State allapot, Csomopont szulo, int melyseg, int operatorIndex, bool celfeltel)
        {
            Allapot = allapot;
            Szulo = szulo;
            Melyseg = melyseg;
            OperatorIndex = operatorIndex;
            Celfeltel = celfeltel;
        }

        public Csomopont(State kezdoAllapot, object value, int v1, int v2)
        {
        }

       
    }
}
