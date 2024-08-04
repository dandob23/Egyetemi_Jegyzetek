using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Levél:BFa
    {
        int szám;
        public int Szám { get { return szám; } }
        public Levél(int szám) : base()
        {
            this.szám = szám;
        }
        public override void AcceptVisitor(Visitor v)
        {
            v.Visit(this);
        }

    }
}
