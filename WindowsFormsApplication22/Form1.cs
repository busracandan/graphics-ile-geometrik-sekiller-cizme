using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bm);
            Pen p1 = new Pen(Brushes.Red);
            Pen p2 = new Pen(Brushes.Black);
            Rectangle rn1 = new Rectangle(0, 0, 40, 80);
            g.DrawEllipse(p1,rn1);
            Point po1 = new Point(20, 0);
            Point po2 = new Point(0,40);
            Point po3 = new Point(20, 80);
            Point po4= new Point(40, 40);
            g.DrawLine(p2, po1, po2);
            g.DrawLine(p2, po2, po3);
            g.DrawLine(p2, po3, po4);
            g.DrawLine(p2, po4, po1);

            pictureBox1.Image = bm;
        }
    }
}
