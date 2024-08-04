using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal interface IBiztositas
    {
    
        int Biztositas(int ertek);

        BiztositasTipus BiztositasTipus { get; set; }

    }
}
