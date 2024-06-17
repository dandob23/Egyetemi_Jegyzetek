using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class MaxVisitor : Visitor
    {
        int max = int.MinValue;
        public int Max { get { return max; } }
        public override void Visit(Fa f)
        {
            if (f.Szám > max) max = f.Szám;
            if (f.Bal != null) f.Bal.AcceptVisitor(this);
            if (f.Jobb != null) f.Jobb.AcceptVisitor(this);
        }
        public override void Visit(Levél f)
        {
            if (f.Szám > max) max = f.Szám;
        }

    }
}
