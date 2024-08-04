using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class OrszagkodNemTalalhatoException:Exception
    {
        public OrszagkodNemTalalhatoException(string orszagKod)
            : base("Az országkód nem található: " + orszagKod)
        {
        }
    }
}
