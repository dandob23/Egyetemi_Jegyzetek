using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OpelGyar : AutoGyar
    {
        public override Alvaz CreateAlvaz()
        {
            return new OpelAlvaz();
        }

        public override Motor CreateMotor()
        {
            return new OpelMotor();
        }
    }
}
