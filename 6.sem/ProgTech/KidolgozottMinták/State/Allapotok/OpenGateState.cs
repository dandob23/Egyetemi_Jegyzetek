using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Allapotok
{
    public class OpenGateState : GateState
    {
        private Gate gate; //objektum összetétel

        public OpenGateState(Gate gate)
        {
            this.gate = gate; //felelősség beinjektálása
        }

        public void Enter()
        {
            Console.WriteLine("Felhasználó belépett, a kapu zárul");
            this.gate.ChangeState(new ClosedGateState(this.gate));
        }

        public void Pay(){Console.WriteLine("A kapu már nyitva van, nem szükséges a fizetés...");}
        public void PayOk(){Console.WriteLine("A fizetést már elfogadtuk. A kapu nyitva van...");}
        public void PayFailed(){Console.WriteLine("A fizetés elutasítva, mert a kapu már nyitva van...");}
    }
}
