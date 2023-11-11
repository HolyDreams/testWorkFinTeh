using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace testWorkFinTeh
{
    public partial class pPrint : UserControl
    {
        bool leftSide = true;
        Graphics myGraph;
        public pPrint()
        {
            InitializeComponent();
        }

        private void butSide_Click(object sender, EventArgs e)
        {
            leftSide = !leftSide;
            butSide.Text = leftSide ? "Left" : "Right";
        }

        private void textX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            if (textX1.Text == "")
            {
                MessageBox.Show("Нужно ввести координату Х1");
                return;
            }
            if (textY1.Text == "")
            {
                MessageBox.Show("Нужно ввести координату Y1");
                return;
            }
            if (textX2.Text == "")
            {
                MessageBox.Show("Нужно ввести координату X2");
                return;
            }
            if (textY2.Text == "")
            {
                MessageBox.Show("Нужно ввести координату Y2");
                return;
            }
            if (textR.Text == "")
            {
                MessageBox.Show("Нужно ввести радиус");
                return;
            }

            myGraph = Graphics.FromHwnd(panelMain.Handle);
            var point1 = new PointF(int.Parse(textX1.Text), int.Parse(textY1.Text));
            var point2 = new PointF(int.Parse(textX2.Text), int.Parse(textY2.Text));

            var count = 1;
            int.TryParse(textCount.Text, out count);
            drawArc(myGraph, Pens.Red, point1, point2, int.Parse(textR.Text), leftSide, count);
        }

        private void drawArc(Graphics g, Pen pen, PointF A, PointF B, float radius, bool left, int countDots = 10)
        {
            if (A.X > B.X)
                left = !left;

            double x = B.X - A.X, y = B.Y - A.Y;
            double θ = Math.Atan2(y, x);
            var l = Math.Sqrt(x * x + y * y);
            if (2 * radius >= l)
            {
                var φ = Math.Asin(l / (2 * radius));
                var h = radius * Math.Cos(φ);
                PointF C = new PointF(
                    (float)(A.X + x / 2 - h * (y / l)),
                    (float)(A.Y + y / 2 + h * (x / l)));


                g.DrawLine(Pens.DarkGray, C, A);
                g.DrawLine(Pens.DarkGray, C, B);
                drawPoint(g, Brushes.Orange, C);

                const double to_deg = 180 / Math.PI;


                var startAngle = (float)((θ - φ) * to_deg) - 90;
                startAngle = startAngle < 0 ? startAngle + 360 : startAngle;
                var endAngle = (float)(2 * φ * to_deg) - (left ? 360 : 0);

                g.DrawArc(pen, C.X - radius, C.Y - radius, 2 * radius, 2 * radius,
                    startAngle, endAngle);

                var dot = endAngle / (countDots + 1);
                for (int i = 1; i < countDots + 1; i++)
                {
                    var angle = ((startAngle + endAngle == 360 ? startAngle + endAngle : startAngle + endAngle) - i * dot);
                    var pointX = C.X + radius * Math.Cos(angle * Math.PI / 180);
                    var pointY = C.Y + radius * Math.Sin(angle * Math.PI / 180);
                    drawPoint(myGraph, Brushes.Orange, new PointF((float)pointX, (float)pointY));
                }
            }
        }

        private void drawPoint(Graphics g, Brush brush, PointF A, float size = 8f)
        {
            g.FillEllipse(brush, A.X - size / 2, A.Y - size / 2, size, size);
            g.DrawString(string.Join(":", A.X, A.Y), butPrint.Font, brush, A.X - size / 2 + 5, A.Y - size / 2 + 5);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            myGraph = Graphics.FromHwnd(panelMain.Handle);
            for (int i = 50; i < panelMain.Height; i += 50)
            {
                var p1 = new Point(0, i);
                var p2 = Point.Add(p1, new Size(5, 0));
                myGraph.DrawLine(Pens.Green, p1, p2);
                myGraph.DrawString(i.ToString(), butPrint.Font, Brushes.Green, Point.Add(p2, new Size(-3, 0)));
            }
            for (int i = 50; i < panelMain.Width; i += 50)
            {
                var p1 = new Point(i, 0);
                var p2 = Point.Add(p1, new Size(0, 5));
                myGraph.DrawLine(Pens.Green, p1, p2);
                myGraph.DrawString(i.ToString(), butPrint.Font, Brushes.Green, Point.Add(p2, new Size(0, -3)));
            }
        }

        private void pPrint_Resize(object sender, EventArgs e)
        {
            panelMain.Refresh();
        }
    }
}
