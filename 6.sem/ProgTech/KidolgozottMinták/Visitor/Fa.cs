using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Fa:BFa
    {
        int szám;
        public int Szám { get { return szám; } }
        public Fa(int szám, BFa bal, BFa jobb) : base(bal, jobb)
        {
            this.szám = szám;
        }
        public override void AcceptVisitor(Visitor v)
        {
            v.Visit(this);
        }

    }
}
