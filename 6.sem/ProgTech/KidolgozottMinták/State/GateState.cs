using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //kapu állapotok
    public interface GateState
    {
        void Enter(); // belépés
        void Pay(); // fizetés
        void PayOk(); // sikeres fizetés
        void PayFailed(); // sikertelen fizetés
         
    }
}
