using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Kave : Ital
    {
        protected override void főz()
        {
            // ezt ki kell dolgozni, hiszen másképp főzök teát, mint kávét
            Console.WriteLine("Leforrázom a kávét egy jó török kávé kedvéért.");
        }
        protected override void édesít()
        {
            Console.WriteLine("Kis cukor, és egy kis tej ízlés szerint");
        }

    }
}
