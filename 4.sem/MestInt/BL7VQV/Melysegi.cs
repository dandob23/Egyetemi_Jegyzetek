using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL7VQV
{
    internal class Melysegi
    {
        private int limit;

        public Melysegi(int limit)
        {
            this.limit = limit;
        }

        public override Csomopont Solver(State kezdoAllapot)
        {
            HashSet<string> allapotok = new HashSet<string>();
            Stack<Csomopont> nyiltCsucsok = new Stack<Csomopont>();
            Csomopont start = new Csomopont(kezdoAllapot, null, 0, -1);

            nyiltCsucsok.Push(start);

            while (nyiltCsucsok.Count > 0)
            {
                Csomopont aktualisCsomopont = nyiltCsucsok.Pop();
                State aktualisAllapot = aktualisCsomopont.Allapot;

                if (aktualisAllapot.IsGoalState())
                {
                    return aktualisCsomopont;
                }

                if (aktualisCsomopont.Melyseg < limit)
                {
                    List<Operator> alkalmazhatoOperatorok = OperatorokGeneralasa();

                    foreach (Operator op in alkalmazhatoOperatorok)
                    {
                        if (op.Elofeltetel(aktualisAllapot))
                        {
                            State ujAllapot = op.Atkonfiguracio(aktualisAllapot);
                            string allapotKulcs = ujAllapot.ToString();

                            if (!allapotok.Contains(allapotKulcs))
                            {
                                Csomopont ujCsomopont = new Csomopont(ujAllapot, aktualisCsomopont, aktualisCsomopont.Melyseg + 1, op. index);
                                nyiltCsucsok.Push(ujCsomopont);
                                allapotok.Add(allapotKulcs);
                            }
                        }
                    }
                }
            }

            return null;
        }

        private List<Operator> OperatorokGeneralasa()
        {
            throw new NotImplementedException();
        }
    }
