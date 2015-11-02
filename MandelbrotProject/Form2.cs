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

        private void button2_Click(object sender, EventArgs e)
        {
            int height, width;
            height = decimal.ToInt32(heightVal.Value);
            width = decimal.ToInt32(widthVal.Value);

            Bitmap bmp = new Bitmap(width, height);

           //here goes the rendering :^)
         


            bmp.Save(textBox1.Text);
            
         }

        public void MaxI_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                decimal Iterations = decimal.Parse(iterVal);

                string maxiVal = File.ReadLines(settingsFile).Skip(1).Take(1).First();
                decimal MaxI = decimal.Parse(maxiVal);

                string miniVal = File.ReadLines(settingsFile).Skip(2).Take(1).First();
                decimal MinI = decimal.Parse(miniVal);

                string maxrVal = File.ReadLines(settingsFile).Skip(3).Take(1).First();
                decimal MaxR = decimal.Parse(maxrVal);

                string minrVal = File.ReadLines(settingsFile).Skip(4).Take(1).First();
                decimal MinR = decimal.Parse(minrVal);

                textBox2.Text = LoadSettings.FileName;
            }
        }
    }
}            
