using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diakok_05_04
{
    class Diakok:IEnumerable
    {
        private List<Diak> diakok = new List<Diak>();

        public IEnumerator GetEnumerator()
        {
            yield return diak.Clone() as Diak;

        }

        public void AddDiak(Diak diak)
        {
            diakok.Add(diak.Clone());
        }
    }
}
