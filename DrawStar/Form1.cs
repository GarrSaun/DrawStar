using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        public void DrawStar (Pen pen, float x, float y, float size)
        {
            float scale = size / (83 - 1);

            float x1 = (1+x)*scale;
            float y1 = (34 + y) * scale;
            float x2 = (33 + x) * scale;
            float y2 = (33 + y) * scale;
            float x3 = (43 + x) * scale;
            float y3 = (1 + y) * scale;
            float x4 = (53 + x) * scale;
            float y4 = (33 + y) * scale;
            float x5 = (83 + x) * scale;
            float y5 = (34 + y) * scale;
            float x6 = (60 + x) * scale;
            float y6 = (54 + y) * scale;
            float x7 = (70 + x) * scale;
            float y7 = (84 + y) * scale;
            float x8 = (44 + x ) * scale;
            float y8 = (65 + y) * scale;
            float x9 = (16 + x) * scale;
            float y9 = (84 + y) * scale;
            float x10 = (27 + x) * scale;
            float y10 = (54 + y) * scale;

            Graphics formGraphics = this.CreateGraphics();

            formGraphics.DrawLine(pen, x1, y1, x2, y2);
            formGraphics.DrawLine(pen, x2, y2, x3, y3);
            formGraphics.DrawLine(pen, x3, y3, x4, y4);
            formGraphics.DrawLine(pen, x4, y4, x5, y5);
            formGraphics.DrawLine(pen, x5, y5, x6, y6);
            formGraphics.DrawLine(pen, x6, y6, x7, y7);
            formGraphics.DrawLine(pen, x7, y7, x8, y8);
            formGraphics.DrawLine(pen, x8, y8, x9, y9);
            formGraphics.DrawLine(pen, x9, y9, x10, y10);
            formGraphics.DrawLine(pen, x10, y10, x1, y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen drawPen = new Pen(Color.Red, 1);

            DrawStar(drawPen,30, 150, 100);
        }
    }
}
