using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class SumVisitor:Visitor
    {
        int sum = 0;
        public int Sum { get { return sum; } }
        public override void Visit(Fa f)
        {
            sum += f.Szám;
            if (f.Bal != null) f.Bal.AcceptVisitor(this);
            if (f.Jobb != null) f.Jobb.AcceptVisitor(this);
        }
        public override void Visit(Levél f)
        {
            sum += f.Szám;
        }

    }
}
