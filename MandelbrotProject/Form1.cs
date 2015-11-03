using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MandelbrotProject
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clears screen at the beginning of each render
            //Renderer.CreateGraphics().Clear(System.Drawing.Color.White);

            //minimum x and y values in the complex number of form x+y*i
            decimal minR = MinR.Value;
            decimal maxR = MaxR.Value;
            decimal minI = MaxI.Value;
            decimal maxI = MinI.Value;

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
                        decimal cr = fitInRRange(x, Renderer.Width, minR, maxR);
                        decimal ci = fitInIRange(y, Renderer.Height, minI, maxI);

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
                   
        private void saveParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the save file dialog
            SaveFileDialog SaveSettings = new SaveFileDialog();
            //settings for the open file dialog
            SaveSettings.Filter = "Text File|*.txt";
            SaveSettings.FileName = "Profile";
            SaveSettings.Title = "Save current settings";
            if (SaveSettings.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //saves the settings to the chosen filepath
                string filePath = SaveSettings.FileName;
                TextWriter tw = File.CreateText(filePath);
                tw.WriteLine(Iterations.Value);
                tw.WriteLine(MaxI.Value);
                tw.WriteLine(MinI.Value);
                tw.WriteLine(MaxR.Value);
                tw.WriteLine(MinR.Value);
                //Closes the textwriter
                tw.Flush();
                tw.Close();
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens the open file dialog
            OpenFileDialog LoadSettings = new OpenFileDialog();
            //Settings for open file dialog
            LoadSettings.Filter = "Text file|*.txt";
            LoadSettings.Title = "Load settings";
            if (LoadSettings.ShowDialog() == DialogResult.OK)

            {
                //reads the settings file
                var settingsFile = LoadSettings.FileName;

                string iterVal = File.ReadLines(settingsFile).Take(1).First();
                Iterations.Value = decimal.Parse(iterVal);

                string maxiVal = File.ReadLines(settingsFile).Skip(1).Take(1).First();
                MaxI.Value = decimal.Parse(maxiVal);

                string miniVal = File.ReadLines(settingsFile).Skip(2).Take(1).First();
                MinI.Value = decimal.Parse(miniVal);

                string maxrVal = File.ReadLines(settingsFile).Skip(3).Take(1).First();
                MaxR.Value = decimal.Parse(maxrVal);

                string minrVal = File.ReadLines(settingsFile).Skip(4).Take(1).First();
                MinR.Value = decimal.Parse(minrVal);

                button1_Click(sender, e);

            }
        }

        private void Renderer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //the point in the renderer
            Point p = Renderer.PointToClient(Cursor.Position);
            
            //values for mouse position
            int TestX = p.X;
            int TestY = p.Y;

            //Creating temporary values for min and max I and R
            decimal minR_temp = MinR.Value;
            decimal maxR_temp = MaxR.Value;
            decimal minI_temp = MinI.Value;
            decimal maxI_temp = MaxI.Value;

            //Level of zoom, here 2 means dividing width and height by 2.
            //bigger number = less zoom
            int zoom = 2;

            //finding the width and height of the parameters
            decimal RRange = System.Convert.ToDecimal(MaxR.Value - MinR.Value);
            decimal IRange = System.Convert.ToDecimal(MaxI.Value - MinI.Value);

            //calculating zoom based on old parameters and mouse position
            MaxR.Value = System.Convert.ToDecimal(fitInRRange(TestX, Renderer.Width, minR_temp, maxR_temp)) + ((RRange / zoom) / 2);
            MinR.Value = System.Convert.ToDecimal(fitInRRange(TestX, Renderer.Width, minR_temp, maxR_temp)) - ((RRange / zoom) / 2);
            MaxI.Value = System.Convert.ToDecimal(fitInIRange(TestY, Renderer.Height, minI_temp, maxI_temp)) - ((IRange / zoom) / 2);
            MinI.Value = System.Convert.ToDecimal(fitInIRange(TestY, Renderer.Height, minI_temp, maxI_temp)) + ((IRange / zoom) / 2);

            button1_Click(sender, e);
        }

        private void Renderer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 export1 = new Form2();
            export1.Show();
            
        }
    }
}
