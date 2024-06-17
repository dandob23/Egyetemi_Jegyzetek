using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Allapotok
{
    public class ClosedGateState : GateState
    {
        private Gate gate; //objektum összetétel

        public ClosedGateState(Gate gate)
        { 
            this.gate = gate; //felelősség beinjektálása
        }

        public void Enter(){Console.WriteLine("A kapu zárva, kérem fizessen...");}

        public void Pay()
        {
            Console.WriteLine("Fizetés feldolgozása...");
            this.gate.ChangeState(new OpenGateState(this.gate)); //felelősség átadása és állapot váltás
            Console.WriteLine("Sikeres fizetés, a kapu most nyitva van!");
        }

        public void PayOk(){Console.WriteLine("Sikeres fizetés, a kapu nyílik");}
        public void PayFailed(){Console.WriteLine("Sikertelen fizetés, a kapu zárva marad");}
    }
}
