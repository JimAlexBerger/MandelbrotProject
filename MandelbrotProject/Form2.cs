using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbrotProject
{ 
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        decimal fitInRRange(int x, int width, decimal minR, decimal maxR)
        {
            //fits the X value within the max and min for the plot
            decimal range = maxR - minR;

            return x * (range / width) + minR;
        }

        decimal fitInIRange(int y, int width, decimal minI, decimal maxI)
        {
            //fits the Y value within the max and min for the plot
            decimal range = (maxI - minI);

            return y * (range / width) + minI; ;
        }

        int findMandelbrot(decimal cr, decimal ci, int maxN)
        {
            //calculates Zn+1 = Z^2 + c
            //where c is the current pixel the form x + y*i

            int i = 0;
            decimal zr = 0, zi = 0;

            //if the radius of the complex number is greater than 2 the number escapes
            //returns the number of iterations it takes for the pixel to escape within a range of maxN
            while (i < maxN && zr * zr + zi * zi < 4)
            {
                decimal temp = zr * zr - zi * zi + cr;
                zi = 2 * zr * zi + ci;
                zr = temp;

                i++;

            }
            return i;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportBitmap = new SaveFileDialog();
            //settings for the open file dialog
            exportBitmap.Filter = "Bitmap|*.bmp";
            exportBitmap.FileName = "Mandelbrot_1";
            exportBitmap.Title = "Export";
            if (exportBitmap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //saves the bitmap to the chosen filepath
                string exportFile = exportBitmap.FileName;
                textBox1.Text = exportFile;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            int height, width;
            height = decimal.ToInt32(heightVal.Value);
            width = decimal.ToInt32(widthVal.Value);

            OpenFileDialog loadParameters = new OpenFileDialog();
            loadParameters.FileName = textBox2.Text;
            //reads the settings file
            var settingsFile = loadParameters.FileName;

            string iterVal = File.ReadLines(settingsFile).Take(1).First();
            int maxN = System.Convert.ToInt32(iterVal);

            string maxiVal = File.ReadLines(settingsFile).Skip(1).Take(1).First();
            decimal maxI = decimal.Parse(maxiVal);

            string miniVal = File.ReadLines(settingsFile).Skip(2).Take(1).First();
            decimal minI = decimal.Parse(miniVal);

            string maxrVal = File.ReadLines(settingsFile).Skip(3).Take(1).First();
            decimal maxR = decimal.Parse(maxrVal);

            string minrVal = File.ReadLines(settingsFile).Skip(4).Take(1).First();
            decimal minR = decimal.Parse(minrVal);

            Bitmap bmp = new Bitmap(width, height);

            Color clr = new Color();

            //here goes the rendering :^)

            for (int y = 0; y < heightVal.Value; y++)
            {
                for (int x = 0; x < widthVal.Value; x++)
                {
                    int y_Pos = (int)heightVal.Value - y;

                    decimal cr = fitInRRange(x, (int)widthVal.Value, minR, maxR);
                    decimal ci = fitInIRange(y, (int)heightVal.Value, minI, maxI);

                    //Figures out how many iterations the complex number x+y*i takes before it becomes bigger than 2
                    int n = findMandelbrot(cr, ci, maxN);


                    //A value usen in color function, figures out where the N value lies withing a range of 0 and the maxN value
                    double t = ((n + 0.0) / (maxN + 0.0));

                    clr = Color.FromArgb(System.Convert.ToInt32(9 * (1 - t) * t * t * t * 255), System.Convert.ToInt32(15 * (1 - t) * (1 - t) * t * t * 255), System.Convert.ToInt32(8.5 * (1 - t) * (1 - t) * (1 - t) * t * 255));

                    //Rendering the color at the exact pixel the for loop is on
                    bmp.SetPixel(x,y_Pos,clr);

                    
                }
                progress_Mandelbrot.Value = (int)(((double)y/(double)heightVal.Value) * 100);
            }

            bmp.Save(textBox1.Text);
            
         }

        public void MaxI_ValueChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            //opens the open file dialog
            OpenFileDialog LoadSettings = new OpenFileDialog();
            //Settings for open file dialog
            LoadSettings.Filter = "Text file|*.txt";
            LoadSettings.Title = "Load settings";
            if (LoadSettings.ShowDialog() == DialogResult.OK)

            {
                //writes filepath to textbox
                textBox2.Text = LoadSettings.FileName;
            }
        }
    }
}            
