using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea:Ital
    {
        protected override void főz()
        {
            // ezt ki kell dolgozni, hiszen másképp főzök teát, mint kávét
            Console.WriteLine("Belógatom és tunkolom a tea filtert");
        }
        protected override void édesít()
        {
            Console.WriteLine("Kis cukor, és egy kis citrom ízlés szerint");
        }

    }
}
