using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Termelo_Fogyaszto
{
    internal class KonzervGyar
    {
        private object lockObject = new object();
        private List<Konzerv> buffer = new List<Konzerv>();
        private int DobozoltKukorica = 0;
        private int DobozoltBab = 0;

        public void Termel(string tipus, double tomeg)
        {
            lock (lockObject)
            {
                while (buffer.Count == 10)
                {
                    Monitor.Wait(lockObject);
                }

                buffer.Add(new Konzerv(tipus, tomeg));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Termelő: {tipus} konzerv ({tomeg} g) készült. \n");
                Console.ForegroundColor = ConsoleColor.White;
                Monitor.Pulse(lockObject);
            }
        }


        public void Fogyaszt(string fogyasztoTipus)
        {
            lock (lockObject)
            {
                while (buffer.Count == 0)
                {
                    Monitor.Wait(lockObject);
                }

                Konzerv konzerv = buffer[0];
                buffer.RemoveAt(0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fogyasztó ({fogyasztoTipus}): {konzerv.Tipus} konzerv ({konzerv.Tomeg} g) el lett rakva.\n");
                Console.ForegroundColor = ConsoleColor.White;

                if (fogyasztoTipus == "kukorica" && konzerv.Tipus == "kukorica")
                {
                    DobozoltKukorica++;
                    if (DobozoltKukorica == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Doboz kész: {DobozoltKukorica} db kukorica konzerv\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        DobozoltKukorica = 0;
                    }
                }
                else if (fogyasztoTipus == "bab" && konzerv.Tipus == "bab")
                {
                    DobozoltBab++;
                    if (DobozoltBab == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Doboz kész: {DobozoltBab} db bab konzerv\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        DobozoltBab = 0;
                    }
                }

                Monitor.Pulse(lockObject);
            }
        }
    }
}
