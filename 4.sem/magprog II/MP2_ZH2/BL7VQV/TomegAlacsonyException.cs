using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class TomegAlacsonyException:Exception
    {
        public TomegAlacsonyException(int tomeg)
            : base("A tömeg túl alacsony: " + tomeg)
        {
        }
    }
}
