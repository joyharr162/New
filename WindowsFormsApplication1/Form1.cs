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
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics fg = this.CreateGraphics();
            SolidBrush brush = new SolidBrush (Color.Red);
            fg.FillEllipse(brush,50, 50, 200, 300);
            Rectangle r1 = new Rectangle (100, 100, 50, 50);
            Rectangle r2 = new Rectangle (50, 50, 50, 50);
            if (r1.IntersectsWith(r2))
                MessageBox.Show("Intersected!");
            else
                MessageBox.Show("Non-Intersected!");

        }
    }
}
