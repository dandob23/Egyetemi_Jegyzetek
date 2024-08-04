using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy_Prototype
{
    internal interface IPrototype <T>
    {
        T DeepCopy ();
    }
}
