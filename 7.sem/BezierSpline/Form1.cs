using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezierSpline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Value = (decimal)lineThickness;
            numericUpDown1.ValueChanged += lineThickness_ValueChanged;
        }

        private float lineThickness = 1;
        private List<Point> controlPoints = new List<Point>();
        private int selectedPointIndex = -1;
        private bool isFinalized = false;
        private bool isColorGradient = false;
        private List<Tuple<Color, Color>> colorPairs = new List<Tuple<Color, Color>>()
        {
            new Tuple<Color, Color>(Color.Red, Color.Blue),
            new Tuple<Color, Color>(Color.Green, Color.Yellow),
            new Tuple<Color, Color>(Color.Purple, Color.Orange),
            new Tuple<Color, Color>(Color.Black, Color.White),
            new Tuple<Color, Color>(Color.Gray, Color.Pink),
            new Tuple<Color, Color>(Color.Cyan, Color.Magenta),
            new Tuple<Color, Color>(Color.DarkBlue, Color.DarkGreen),
            new Tuple<Color, Color>(Color.DarkRed, Color.DarkOrange),
            new Tuple<Color, Color>(Color.DarkViolet, Color.LightYellow),
            new Tuple<Color, Color>(Color.DarkGray, Color.DarkCyan),
            new Tuple<Color, Color>(Color.DarkMagenta, Color.DarkTurquoise),
            new Tuple<Color, Color>(Color.DarkSlateBlue, Color.DarkSlateGray),
            new Tuple<Color, Color>(Color.DarkOliveGreen, Color.DarkGoldenrod),
            new Tuple<Color, Color>(Color.DarkKhaki, Color.DarkSalmon)
        };
        private int hoveredPointIndex = -1;


        private int currentColorIndex = 0;


        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            if(controlPoints.Count>1)
            {
                DrawControlLines(e.Graphics);
            }

            if(isFinalized && controlPoints.Count>2)
            {
                DrawBezierSpline(e.Graphics);
            }

            foreach (var point in controlPoints)
            {
                Brush brush = Brushes.Black;

                if (controlPoints.IndexOf(point) == hoveredPointIndex)
                {
                    brush = Brushes.Gray;
                }

                e.Graphics.FillEllipse(brush, point.X - 5, point.Y - 5, 10, 10);
            }
        }

        private void DrawBezierSpline(Graphics g)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                /*
                Itt van egy hiba, mivel így 4 pontonként fog kirajzolni egy bézier görbét, 
                amit összeköt a korábbi görbe végpontjával.
                
                Így nem összefüggő Bézier Spline-t kapunk, hanem több különálló Bézier görbét. 
                 
                
                Megoldás: - Kivenni azt, hogy 4 pontonként rajzoljon egy Bézier görbét
                          - Az egész controlpoints listát rajzoljuk/frissítjuk minden pontnál

                 */
                for (int i = 0; i < controlPoints.Count -3; i+=3)
                {
                    path.AddBezier(controlPoints[i], controlPoints[i + 1], controlPoints[i + 2], controlPoints[i + 3]);
                }

                if (isColorGradient)
                {
                    var colors = colorPairs[currentColorIndex];

                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        new Rectangle(0,0,canvas.Width,canvas.Height),
                        colors.Item1,colors.Item2, LinearGradientMode.Horizontal))
                    {
                        g.DrawPath(new Pen(brush, lineThickness), path);
                    }
                }
                else
                {
                    g.DrawPath(new Pen(Color.Black,lineThickness),path);
                }
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int pointIndex = FindPointAtPosition(e.Location);

                //Ha a pontot megtaláljuk, akkor töröljük
                if (pointIndex != -1)
                {
                    controlPoints.RemoveAt(pointIndex);
                    canvas.Invalidate();
                }
                else
                {
                //Ha nem találjuk meg, akkor hozzáadjuk
                controlPoints.Add(e.Location);
                canvas.Invalidate();
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                //Ha bal kattintás történik, akkor kiválasztjuk a pontot
                selectedPointIndex = FindPointAtPosition(e.Location);
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Ha bal kattintás történt és van kiválasztott pont, akkor mozgatjuk
            if (selectedPointIndex != -1 && e.Button == MouseButtons.Left)
            {
                controlPoints[selectedPointIndex] = e.Location;
                canvas.Invalidate();
            }
            else
            {
                //Ha nincs kiválasztott pont, akkor megnézzük, hogy van-e olyan pont, amire rámutatunk
                hoveredPointIndex = FindPointAtPosition(e.Location);
                canvas.Invalidate();
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            //Ha bal kattintás volt, akkor a kiválasztott pontot nullázuk
            if(e.Button == MouseButtons.Left)
            {
                selectedPointIndex = -1;
            }
        }

        private int FindPointAtPosition(Point location)
        {
            //Megkeressük azt a pontot, amelyik a megadott helyen van
            for (int i = 0; i < controlPoints.Count; i++)
            {
                if (Math.Abs(controlPoints[i].X - location.X) < 10 && Math.Abs(controlPoints[i].Y - location.Y) < 10)
                {
                    return i;
                }
            }
            return -1;
        }

        private void FinalizeButton_Click(object sender, EventArgs e)
        {
            //Ha legalább 4 pont van, akkor a Bézier Spline kirajzolásra kerül
            if(controlPoints.Count>=4)
            {
                isFinalized = true;
                canvas.Invalidate();
            }
            else
            {
                MessageBox.Show("Legalább 4 pont kell a Bézier Spline kirajzolásához");
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            isColorGradient = true;

            currentColorIndex = (currentColorIndex + 1) % colorPairs.Count;

            canvas.Invalidate();
        }

        private void lineThickness_ValueChanged(object sender, EventArgs e)
        {
            lineThickness= (float)numericUpDown1.Value;
            canvas.Invalidate();
        }

        private void DrawControlLines(Graphics g)
        {
            using (Pen grayPen = new Pen(Color.Gray, 1))
            {
                for (int i = 0; i < controlPoints.Count - 1; i++)
                {
                    g.DrawLine(grayPen, controlPoints[i], controlPoints[i + 1]);
                }
            }
        }
    }
}
