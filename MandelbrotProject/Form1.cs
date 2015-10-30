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
            //fits the X value within the max and min for the plot
            double range = maxR - minR;

            return x * (range / width) + minR;
        }

        double fitInIRange(int y, int width, double minI, double maxI)
        {
            //fits the Y value within the max and min for the plot
            double range = maxI - minI;

            return y * (range / width) + minI; ;
        }

        int findMandelbrot(double cr, double ci, int maxN)
        {
            //calculates Zn+1 = Z^2 + c
            //where c is the current pixel the form x + y*i

            int i = 0;
            double zr = 0, zi = 0;

            //if the radius of the complex number is greater than 2 the number escapes
            //returns the number of iterations it takes for the pixel to escape withing a range of maxN
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
            //Clears screen at the beginning of each render
            Renderer.CreateGraphics().Clear(System.Drawing.Color.White);

            //minimum x and y values in the complex number of form x+y*i
            double minR = System.Convert.ToDouble(MinR.Value);
            double maxR = System.Convert.ToDouble(MaxR.Value);
            double minI = System.Convert.ToDouble(MaxI.Value);
            double maxI = System.Convert.ToDouble(MinI.Value);

            //maximum iterations before it determines if the number is inside or outside a radius of 2
            // see http://arachnoid.com/mandelbrot_set/resources/orbit_0.3520x0.3520.png
            int maxN = System.Convert.ToInt32(Iterations.Value);

            //The Brush used to render Mandelbrot set
            SolidBrush MandelColor = new SolidBrush(System.Drawing.Color.Tomato);

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
                        if (Color_Box.Checked == true) MandelColor.Color = System.Drawing.Color.FromArgb(System.Convert.ToInt32(9 * (1 - t) * t * t * t * 255), System.Convert.ToInt32(15 * (1 - t) * (1 - t) * t * t * 255), System.Convert.ToInt32(8.5 * (1 - t) * (1 - t) * (1 - t) * t * 255));
                        else if (n == maxN) MandelColor.Color = MandelColor_Dialog.Color;
                        else MandelColor.Color = BackgroundColor_Dialog.Color;

                        //Rendering the color at the exact pixel the for loop is on
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
            //Sets all the values to default values
            MaxI.Value = 1;
            MinI.Value = -1;
            MaxR.Value = 1;
            MinR.Value = System.Convert.ToDecimal(-2.5);
            Iterations.Value = 250;
            MandelColor_Dialog.Color = Color.Black;
            BackgroundColor_Dialog.Color = Color.Transparent;
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

        private void Color_Box_CheckedChanged(object sender, EventArgs e)
        {
            //shows the background and mandelbrot color boxes based on the state of the checkbox
            if (Color_Box.Checked == true)
            {
                Custom_Back.Visible = false;
                Custom_Mandelbrot.Visible = false;
            }
            else
            {
                Custom_Back.Visible = true;
                Custom_Mandelbrot.Visible = true;
            }
        }

        private void Custom_Back_Click(object sender, EventArgs e)
        {
            //shows color dialog box for the background color
            BackgroundColor_Dialog.ShowDialog();
        }

        private void Custom_Mandelbrot_Click(object sender, EventArgs e)
        {
            //Shoes color dialog box for the color of the mandelbrot
            MandelColor_Dialog.ShowDialog();
        }
    }
}
