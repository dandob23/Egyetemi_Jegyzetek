using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AutoGyar
    {
        public abstract Alvaz CreateAlvaz();
        public abstract Motor CreateMotor();
    }
}
