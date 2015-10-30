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
        double fitInRRange(int x, int width, double minR, double maxR)
        {
            double range = maxR - minR;

            return x * (range / width) + minR;
        }

        double fitInIRange(int y, int width, double minI, double maxI)
        {
            double range = maxI - minI;

            return y * (range / width) + minI; ;
        }

        int findMandelbrot(double cr, double ci, int maxN)
        {
            int i = 0;
            double zr = 0, zi = 0;

            while (i < maxN && zr * zr + zi * zi < 4.0)
            {
                double temp = zr * zr - zi * zi + cr;
                zi = 2.0 * zr * zi + ci;
                zr = temp;

                i++;

            }
            return i;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renderer.CreateGraphics().Clear(Color.White);


            double minR = System.Convert.ToDouble(MinR.Value);
            double maxR = System.Convert.ToDouble(MaxR.Value);
            double minI = System.Convert.ToDouble(MaxI.Value);
            double maxI = System.Convert.ToDouble(MinI.Value);
            int maxN = System.Convert.ToInt32(Iterations.Value);

            SolidBrush MandelColor = new SolidBrush(Color.Red);

            using (var graphics = Renderer.CreateGraphics())
            { 
                for (int y = 0; y < Renderer.Height; y++)
                {
                    for (int x = 0; x < Renderer.Width; x++)
                    {

                        double cr = fitInRRange(x, Renderer.Width, minR, maxR);
                        double ci = fitInIRange(y, Renderer.Height, minI, maxI);

                        int n = findMandelbrot(cr, ci, maxN);

                        double t = ((n + 0.0) / (maxN + 0.0));

                        MandelColor.Color = Color.FromArgb(System.Convert.ToInt32(9 * (1 - t) * t * t * t * 255), System.Convert.ToInt32(15 * (1 - t) * (1 - t) * t * t * 255), System.Convert.ToInt32(8.5 * (1 - t) * (1 - t) * (1 - t) * t * 255));

                        graphics.FillRectangle(MandelColor, x, y, 1, 1);


                    }
                }
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
