using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Termelo_Fogyaszto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KonzervGyar gyar = new KonzervGyar();

            #region THREADEK
            Thread termelo1 = new Thread(() =>
            {
                Random rnd = new Random();
                while (true)
                {
                    gyar.Termel("kukorica", rnd.Next(150, 201));
                    Thread.Sleep(3000);
                }
            });

            Thread termelo2 = new Thread(() =>
            {
                Random rnd = new Random();
                while (true)
                {
                    gyar.Termel("bab", rnd.Next(350, 401));
                    Thread.Sleep(5000);
                }
            });


            Thread fogyasztoKukorica = new Thread(() =>
            {
                while (true)
                {
                    gyar.Fogyaszt("kukorica");
                    Thread.Sleep(1000);
                }
            });

            Thread fogyasztoBab = new Thread(() =>
            {
                while (true)
                {
                    gyar.Fogyaszt("bab");
                    Thread.Sleep(1500);
                }
            });
            #endregion
                   
            termelo1.Start();
            termelo2.Start();
            fogyasztoKukorica.Start();
            fogyasztoBab.Start();

            termelo1.Join();
            termelo2.Join();
            fogyasztoKukorica.Join();
            fogyasztoBab.Join();
        }
    }
}
