using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public abstract class BFa
    {
        BFa bal, jobb;
        public BFa Bal { get { return bal; } }
        public BFa Jobb { get { return jobb; } }
        public BFa(BFa bal, BFa jobb)
        {
            this.bal = bal;
            this.jobb = jobb;
        }
        public BFa() : this(null, null) { }
        public abstract void AcceptVisitor(Visitor v);

    }
}
