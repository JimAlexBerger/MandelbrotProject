using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbrotProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point currentPoint = new Point(10, 10);
            for (int i = 0; i < Renderer.Height; i++)
            {
                Renderer.CreateGraphics().FillRectangle(new SolidBrush(Color.Violet), 0+i, 0+i, 1, 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaxI.Value = 1;
            MinI.Value = -1;
            MaxR.Value = 1;
            MinR.Value = System.Convert.ToDecimal(-2.5);
            Iterations.Value = 250;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MinR_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Iterations_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
