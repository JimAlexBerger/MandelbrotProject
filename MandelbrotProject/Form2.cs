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

             for (int y = 0; y < height; y++)
             {
                 for (int x = 0; x < width; x++)
                 {
                    Color clr = new Color();

                    clr = Color.FromArgb(255, 255, 255);

              
                    bmp.SetPixel(x, y, clr);
                 }
             }
             

            



            bmp.Save(textBox1.Text);
            
         }
    }
}            
