using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class MinositesGyar
    {
        public Minosites CreateMinosites()
        {
            // itt a gyártás előtt lehet ezt-azt csinálni, pl. logolni
            return Minosit();
        }
        public abstract Minosites Minosit();

    }
}
