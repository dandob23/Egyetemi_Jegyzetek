using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketdimenzios_tomb_szorzotabla_mar_nem
{
    class Program
    {
        static void Main(string[] args)
        {

            int mx = 10;
            int my = 9;
            int[,] t = new int[mx, my];
            Random r = new Random();
            for (int x = 0; x < mx; x++)
            {
                for (int y = 0; y < my; y++)
                {
                    t[x,y] = (y + 1) * 10 + x;
                }
            }
            for (int x = 0; x < mx; x++)
            {
                for (int y = 0; y < my; y++)
                {
                    Console.Write("{0,4} ", t[x, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //innen a másik
            for (int x = 0; x < mx; x++)
            {
                for (int y = 0; y < my; y++)
                {
                    if (t[x,y]%11==0)
                    {
                        t[x, y] = 0; //a 11-gyel oszthatókat kinullázzuk
                    }
                }
            }
            for (int x = 0; x < mx; x++)
            {
                for (int y = 0; y < my; y++)
                {
                    Console.Write("{0,4} ", t[x, y]);
                }
                Console.WriteLine();
            }
            //innen a harmadik
            int x1 = 0;
            int y1 = 0;
            while (!((t[x1,y1]%9==0)&&(t[x1,y1]%5==0)))
            {
                y1++;
                if (y1==my)
                {
                    x1++;
                    y1=0;
                }
            }
            Console.WriteLine();
            Console.WriteLine("x={0} y={1} n={2}", x1+1, y1+1, t[x1, y1]);
            

            Console.ReadKey();
        }
    }
}
