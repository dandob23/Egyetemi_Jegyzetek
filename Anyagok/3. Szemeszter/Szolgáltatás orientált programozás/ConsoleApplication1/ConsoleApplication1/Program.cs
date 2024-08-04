using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static bool Collide(labda l1, labda l2)
        {

            if (l1.cordX == l2.cordX && l1.cordY == l2.cordY)
                return false;
            return true;
        }

        static void Main(string[] args)
        {
            labda l1 = new labda(10, 11, 1, -1);
            labda l2 = new labda(61, 20, -1, -1);
            labda l3 = new labda(50, 5, 1, 1);

            Thread th1 = new Thread(l1.mozog);
            Thread th2 = new Thread(l2.mozog);
            Thread th3 = new Thread(l3.mozog);

            th1.Start();
            th2.Start();
            th3.Start();

            Console.ReadKey();
        }
    }

    class labda
    {
        static Random rnd = new Random();

        const int MaxX = 80;
        const int MaxY = 25;

        public int moveX { get; set; }
        public int moveY { get; set; }

        public int cordX { get; private set; }
        public int cordY { get; private set; }

        public labda(int cordX, int cordY, int x, int y)
        {
            this.cordX = cordX;
            this.cordY = cordY;
            this.moveX = x;
            this.moveY = y;
        }

        public void mozog()
        {
            while (true)
            {
                lock (typeof(Program))
                {
                    Console.SetCursorPosition(cordX, cordY);
                    Console.Write(" ");
                }

                if (cordX >= MaxX || 0 >= cordX)
                    moveX *= -1;

                cordX += moveX;

                if (cordY >= MaxY || 0 >= cordY)
                    moveY *= -1;

                cordY += moveY;

                lock (typeof(Program))
                {
                    Console.SetCursorPosition(cordX, cordY);
                    Console.Write("O");
                }
                Thread.Sleep(100);
            }
        }
    }
}
