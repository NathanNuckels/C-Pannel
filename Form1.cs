using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text="DrawXXX(); demo";
            this.Size = new Size(450,400);
            this.Paint += new PaintEventHandler(Draw_Graphics);
        }
        public void Draw_Graphics(object sender, PaintEventArgs e){
            Graphics g = e.Graphics;
            Pen penline = new Pen(Color.Red, 5);
            Pen penelipse = new Pen(Color.Blue,5);
            Pen penpie = new Pen(Color.Tomato,3);
            Pen penpolygon = new Pen(Color.Maroon,4);

            //posible values: Dash, DashDot, DashDotDot Dot, Solid
            penline.DashStyle=DashStyle.DashDotDot;
            penelipse.DashStyle=DashStyle.DashDotDot;
            penpie.DashStyle=DashStyle.Dot;

            g.DrawLine(penline,50,50,100,200);
            g.DrawEllipse(penelipse,15,15,50,50);
            g.DrawPie(penpie,90,80,140,40,120,100);
            g.DrawPolygon(penpolygon, new Point[] {
                new Point(270,250),
                new Point(110,240),
                new Point(200,170),
                new Point(70,350),
                new Point(50,200)
            });
        }

    }
}
