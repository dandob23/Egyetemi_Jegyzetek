using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak.Interfaces
{
    public interface OperatorGenerator
    {
        List<Operator> GenerateOperators(Node node); 
    }

}
