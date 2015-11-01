namespace MandelbrotProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.heightVal = new System.Windows.Forms.NumericUpDown();
            this.widthValue = new System.Windows.Forms.Label();
            this.widthVal = new System.Windows.Forms.NumericUpDown();
            this.heightValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heightVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthVal)).BeginInit();
            this.SuspendLayout();
            // 
            // heightVal
            // 
            this.heightVal.Location = new System.Drawing.Point(180, 25);
            this.heightVal.Maximum = new decimal(new int[] {
            2160,
            0,
            0,
            0});
            this.heightVal.Name = "heightVal";
            this.heightVal.Size = new System.Drawing.Size(69, 20);
            this.heightVal.TabIndex = 0;
            // 
            // widthValue
            // 
            this.widthValue.AutoSize = true;
            this.widthValue.Location = new System.Drawing.Point(9, 9);
            this.widthValue.Name = "widthValue";
            this.widthValue.Size = new System.Drawing.Size(35, 13);
            this.widthValue.TabIndex = 1;
            this.widthValue.Text = "Width";
            this.widthValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // widthVal
            // 
            this.widthVal.Location = new System.Drawing.Point(12, 25);
            this.widthVal.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.widthVal.Name = "widthVal";
            this.widthVal.Size = new System.Drawing.Size(72, 20);
            this.widthVal.TabIndex = 2;
            // 
            // heightValue
            // 
            this.heightValue.AutoSize = true;
            this.heightValue.Location = new System.Drawing.Point(177, 9);
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(38, 13);
            this.heightValue.TabIndex = 3;
            this.heightValue.Text = "Height";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Render";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 153);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.heightValue);
            this.Controls.Add(this.widthVal);
            this.Controls.Add(this.widthValue);
            this.Controls.Add(this.heightVal);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.heightVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown heightVal;
        private System.Windows.Forms.Label widthValue;
        private System.Windows.Forms.NumericUpDown widthVal;
        private System.Windows.Forms.Label heightValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}