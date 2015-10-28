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
            MessageBox.Show("Width: " + WidthInput.Text +" Height: " + HeightInput.Text + " Iterations: " + IterationsInput.Text);
            Mandelbrot_Renderer form = new Mandelbrot_Renderer();
            form.Show();
            form.Size = new System.Drawing.Size(Int32.Parse(WidthInput.Text)+16, Int32.Parse(HeightInput.Text)+39);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
