using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //if (textX1.Text == "")
            //{
            //    MessageBox.Show("Нужно ввести координату Х1");
            //    return;
            //}
            //if (textY1.Text == "")
            //{
            //    MessageBox.Show("Нужно ввести координату Y1");
            //    return;
            //}
            //if (textX2.Text == "")
            //{
            //    MessageBox.Show("Нужно ввести координату X2");
            //    return;
            //}
            //if (textY2.Text == "")
            //{
            //    MessageBox.Show("Нужно ввести координату Y2");
            //    return;
            //}
            //if (textR.Text == "")
            //{
            //    MessageBox.Show("Нужно ввести радиус");
            //    return;
            //}
            myGraph = Graphics.FromHwnd(panelMain.Handle);
            var rad = int.Parse(textR.Text);
            myGraph.DrawArc(new Pen(Brushes.Red), 0, 0, rad, rad, 0, 300);
            myGraph.Save();
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void textCount_TextChanged(object sender, EventArgs e)
        {
        }

        private void pPrint_Load(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            myGraph = e.Graphics;
            var linePen = new Pen(Brushes.Green);
            var pointPen = new Pen(Brushes.Green, 3);
            myGraph.DrawLine(linePen, 0, 200, 400, 200);
            myGraph.DrawLine(linePen, 200, 0, 200, 400);
            var p1 = new Point(50, 195);
            var p2 = Point.Add(p1, new Size(0, 11));
            myGraph.DrawLine(pointPen, p1, p2);
            myGraph.DrawString("-150", butPrint.Font, Brushes.Green, Point.Add(p1, new Size(-15, -15)));
            for (int i = 100; i < 400; i += 50)
            {
                var p3 = new Point(i, 195);
                var p4 = Point.Add(p3, new Size(0, 11));
                myGraph.DrawLine(pointPen, p3, p4);
                myGraph.DrawString((i - 200).ToString(), butPrint.Font, Brushes.Green, Point.Add(p3, new Size(-15, -15)));
            }
            for (int i = 50; i < 400; i += 50)
            {
                var p3 = new Point(195, i);
                var p4 = Point.Add(p3, new Size(11, 0));
                myGraph.DrawLine(pointPen, p3, p4);
                if (i == 200)
                    continue;
                myGraph.DrawString((i - 200).ToString(), butPrint.Font, Brushes.Green, Point.Add(p3, new Size(10, -15)));
            }
        }
    }
}
