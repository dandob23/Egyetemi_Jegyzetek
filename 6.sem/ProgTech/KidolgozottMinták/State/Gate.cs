using State.Allapotok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Gate
    {
        private GateState state; //objektum összetétel

        public Gate()
        {
            this.state = new ClosedGateState(this); // alapértelmezetten zárva van
        }

        public void Enter()
        {
            this.state.Enter(); //delegáció (felelősség átadása)
        }

        public void Pay()
        {
            this.state.Pay(); 
        }

        public void PayOk()
        {
            this.state.PayOk();
        }

        public void PayFailed()
        {
            this.state.PayFailed();
        }

        public void ChangeState(GateState state)
        {
            this.state = state; //felelősség beinjektálása: állapot váltás
        }
    }
}
