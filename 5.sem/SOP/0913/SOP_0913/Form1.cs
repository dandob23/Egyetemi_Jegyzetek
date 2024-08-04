using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SOP_0913
{
    public partial class Form1 : Form
    {
        Graphics g;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
        }

        void DrawRandomLines()
        {
            int x1 = rnd.Next(canvas.Width);
            int y1 = rnd.Next(canvas.Height);
            int x2 = rnd.Next(canvas.Width);
            int y2 = rnd.Next(canvas.Height);
            lock (g)
            {
                g.DrawLine(Pens.Black, x1, y1, x2, y2);
            }

            Thread.Sleep(100);

            lock (g)
            {
                g.DrawLine(Pens.White, x1, y1, x2, y2);
            }
        }

        private void DrawLines_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(DrawRandomLines);
                thread.Start();
            }
        }
    }
}
