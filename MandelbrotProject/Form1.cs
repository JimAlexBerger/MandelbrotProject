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

            //minimum x and y values in the complex number of form x+y*i
            double minR = System.Convert.ToDouble(MinR.Value);
            double maxR = System.Convert.ToDouble(MaxR.Value);
            double minI = System.Convert.ToDouble(MaxI.Value);
            double maxI = System.Convert.ToDouble(MinI.Value);

            //maximum iterations before it determines if the number is inside or outside a radius of 2
            // see http://arachnoid.com/mandelbrot_set/resources/orbit_0.3520x0.3520.png
            int maxN = System.Convert.ToInt32(Iterations.Value);

            //The Brush used to render Mandelbrot set
            SolidBrush MandelColor = new SolidBrush(Color.Tomato);

            //moving Renderer.CreateGraphics() outside the for loops
            using (var graphics = Renderer.CreateGraphics())
            { 
                //runs on every pixel in the Renderer
                for (int y = 0; y < Renderer.Height; y++)
                {
                    for (int x = 0; x < Renderer.Width; x++)
                    {

                        //fits the x and y value within the minR/I and MaxR/I Value
                        double cr = fitInRRange(x, Renderer.Width, minR, maxR);
                        double ci = fitInIRange(y, Renderer.Height, minI, maxI);

                        //Figures out how many iterations the complex number x+y*i takes before it becomes bigger than 2
                        int n = findMandelbrot(cr, ci, maxN);

                        //A value usen in color function, figures out where the N value lies withing a range of 0 and the maxN value
                        double t = ((n + 0.0) / (maxN + 0.0));
                        
                        //if the color box is checked it runs an function to calculate the color of the pixel, 
                        //else it renders only the non-escaping part black and everything else white.
                        if (Color_Box.Checked == true) MandelColor.Color = Color.FromArgb(System.Convert.ToInt32(9 * (1 - t) * t * t * t * 255), System.Convert.ToInt32(15 * (1 - t) * (1 - t) * t * t * 255), System.Convert.ToInt32(8.5 * (1 - t) * (1 - t) * (1 - t) * t * 255));
                        else if (n == maxN) MandelColor.Color = Color.Tomato;
                        else MandelColor.Color = Color.White;


                        //Only rendering if the color box is checked or if the mandelbrot does not escape within the maxN value
                        if (Color_Box.Checked == true || n == maxN) graphics.FillRectangle(MandelColor, x, y, 1, 1);


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
            //Sets all the values to default values
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
