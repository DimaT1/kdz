using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDZ1
{
    public partial class Form1 : Form
    {
        MyFunction f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f = new MyFunction(1, 0.01);
            Plot.Print(chart, f);   
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void paramaUpDown_ValueChanged(object sender, EventArgs e)
        {
            f.A = (int)paramaUpDown.Value;
            Plot.Print(chart, f);
        }
    }
}
