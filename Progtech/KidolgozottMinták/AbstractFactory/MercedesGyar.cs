using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MercedesGyar:AutoGyar
    {
        public override Motor CreateMotor()
        {
            return new MercedesMotor();
        }

        public override Alvaz CreateAlvaz()
        {
            return new MercedesAlvaz();
        }
    }
}
