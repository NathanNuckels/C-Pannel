using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        Button b1 = new Button();
        TextBox tb = new TextBox();
        FontDialog flg = new FontDialog();
        public Form1()
        {
            b1.Click += new EventHandler(b1_click);
            b1.Text="OK";
            tb.Location = new Point(50,50);
            this.Controls.Add(b1);
            this.Controls.Add(tb);
            this.Paint += new PaintEventHandler(f1_paint);
            InitializeComponent();
        }

        public void b1_click(object sender, EventArgs eventArgs){
            cd.ShowDialog();
            tb.FontName = flg.Font;

        }

        private void f1_paint(object sender, PaintEventArgs e){
            Graphics g = e.Graphics;
            //g.DrawString("werds and crap", new Font("Veranda",20), new SolidBrush(Color.Tomato), 40, 40);
            //g.DrawRectangle(new Pen(Color.Pink, 3), 20, 20, 150, 100);
        }

    }
}
