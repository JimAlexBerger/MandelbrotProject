namespace MandelbrotProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Render_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Custom_Mandelbrot = new System.Windows.Forms.Button();
            this.Custom_Back = new System.Windows.Forms.Button();
            this.Color_Box = new System.Windows.Forms.CheckBox();
            this.Set_To_Default = new System.Windows.Forms.Button();
            this.MinR = new System.Windows.Forms.NumericUpDown();
            this.MaxR = new System.Windows.Forms.NumericUpDown();
            this.MinI = new System.Windows.Forms.NumericUpDown();
            this.Iterations = new System.Windows.Forms.NumericUpDown();
            this.MaxI = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Renderer = new System.Windows.Forms.Panel();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MandelColor_Dialog = new System.Windows.Forms.ColorDialog();
            this.BackgroundColor_Dialog = new System.Windows.Forms.ColorDialog();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxI)).BeginInit();
            this.SuspendLayout();
            // 
            // Render_Button
            // 
            this.Render_Button.Location = new System.Drawing.Point(578, 5);
            this.Render_Button.Name = "Render_Button";
            this.Render_Button.Size = new System.Drawing.Size(114, 23);
            this.Render_Button.TabIndex = 0;
            this.Render_Button.Text = "Render Mandelbrot";
            this.Render_Button.UseVisualStyleBackColor = true;
            this.Render_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MaxI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iterations";
            this.ToolTip1.SetToolTip(this.label3, "Good strategy to try is: start with 200, and when things smooth out or craggy bla" +
        "ck areas develop, raise it to 2000. next time it gets bad try 10000, then 30000." +
        "");
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.Controls.Add(this.button2);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.Custom_Mandelbrot);
            this.Menu.Controls.Add(this.Custom_Back);
            this.Menu.Controls.Add(this.Color_Box);
            this.Menu.Controls.Add(this.Set_To_Default);
            this.Menu.Controls.Add(this.MinR);
            this.Menu.Controls.Add(this.MaxR);
            this.Menu.Controls.Add(this.MinI);
            this.Menu.Controls.Add(this.Iterations);
            this.Menu.Controls.Add(this.MaxI);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.label5);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.label3);
            this.Menu.Controls.Add(this.Render_Button);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(704, 65);
            this.Menu.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Load settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Custom_Mandelbrot
            // 
            this.Custom_Mandelbrot.Location = new System.Drawing.Point(318, 30);
            this.Custom_Mandelbrot.Name = "Custom_Mandelbrot";
            this.Custom_Mandelbrot.Size = new System.Drawing.Size(73, 23);
            this.Custom_Mandelbrot.TabIndex = 23;
            this.Custom_Mandelbrot.Text = "Mandelbrot";
            this.Custom_Mandelbrot.UseVisualStyleBackColor = true;
            this.Custom_Mandelbrot.Visible = false;
            this.Custom_Mandelbrot.Click += new System.EventHandler(this.Custom_Mandelbrot_Click);
            // 
            // Custom_Back
            // 
            this.Custom_Back.Location = new System.Drawing.Point(230, 30);
            this.Custom_Back.Name = "Custom_Back";
            this.Custom_Back.Size = new System.Drawing.Size(82, 23);
            this.Custom_Back.TabIndex = 22;
            this.Custom_Back.Text = "Background";
            this.Custom_Back.UseVisualStyleBackColor = true;
            this.Custom_Back.Visible = false;
            this.Custom_Back.Click += new System.EventHandler(this.Custom_Back_Click);
            // 
            // Color_Box
            // 
            this.Color_Box.AutoSize = true;
            this.Color_Box.Checked = true;
            this.Color_Box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Color_Box.Location = new System.Drawing.Point(347, 9);
            this.Color_Box.Name = "Color_Box";
            this.Color_Box.Size = new System.Drawing.Size(87, 17);
            this.Color_Box.TabIndex = 21;
            this.Color_Box.Text = "Default Color";
            this.Color_Box.UseVisualStyleBackColor = true;
            this.Color_Box.CheckedChanged += new System.EventHandler(this.Color_Box_CheckedChanged);
            // 
            // Set_To_Default
            // 
            this.Set_To_Default.Location = new System.Drawing.Point(440, 5);
            this.Set_To_Default.Name = "Set_To_Default";
            this.Set_To_Default.Size = new System.Drawing.Size(132, 23);
            this.Set_To_Default.TabIndex = 20;
            this.Set_To_Default.Text = "Set To Default Values";
            this.Set_To_Default.UseVisualStyleBackColor = true;
            this.Set_To_Default.Click += new System.EventHandler(this.button2_Click);
            // 
            // MinR
            // 
            this.MinR.DecimalPlaces = 12;
            this.MinR.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.MinR.Location = new System.Drawing.Point(153, 30);
            this.MinR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinR.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147418112});
            this.MinR.Name = "MinR";
            this.MinR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinR.Size = new System.Drawing.Size(58, 20);
            this.MinR.TabIndex = 19;
            this.MinR.Value = new decimal(new int[] {
            25,
            0,
            0,
            -2147418112});
            this.MinR.ValueChanged += new System.EventHandler(this.MinR_ValueChanged);
            // 
            // MaxR
            // 
            this.MaxR.DecimalPlaces = 12;
            this.MaxR.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.MaxR.Location = new System.Drawing.Point(153, 4);
            this.MaxR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxR.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147418112});
            this.MaxR.Name = "MaxR";
            this.MaxR.Size = new System.Drawing.Size(58, 20);
            this.MaxR.TabIndex = 18;
            this.MaxR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinI
            // 
            this.MinI.DecimalPlaces = 12;
            this.MinI.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.MinI.Location = new System.Drawing.Point(48, 30);
            this.MinI.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.MinI.Name = "MinI";
            this.MinI.Size = new System.Drawing.Size(58, 20);
            this.MinI.TabIndex = 17;
            this.MinI.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.MinI.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Iterations
            // 
            this.Iterations.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Iterations.Location = new System.Drawing.Point(283, 6);
            this.Iterations.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Iterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(58, 20);
            this.Iterations.TabIndex = 16;
            this.ToolTip1.SetToolTip(this.Iterations, "Good strategy to try is: start with 200, and when things smooth out or craggy bla" +
        "ck areas develop, raise it to 2000. next time it gets bad try 10000, then 30000." +
        "");
            this.Iterations.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.Iterations.ValueChanged += new System.EventHandler(this.Iterations_ValueChanged);
            // 
            // MaxI
            // 
            this.MaxI.DecimalPlaces = 12;
            this.MaxI.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.MaxI.Location = new System.Drawing.Point(48, 3);
            this.MaxI.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.MaxI.Name = "MaxI";
            this.MaxI.Size = new System.Drawing.Size(58, 20);
            this.MaxI.TabIndex = 0;
            this.MaxI.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "MinR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MaxR";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MinI";
            // 
            // Renderer
            // 
            this.Renderer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Renderer.Location = new System.Drawing.Point(0, 65);
            this.Renderer.Name = "Renderer";
            this.Renderer.Size = new System.Drawing.Size(704, 376);
            this.Renderer.TabIndex = 9;
            // 
            // ToolTip1
            // 
            this.ToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // BackgroundColor_Dialog
            // 
            this.BackgroundColor_Dialog.Color = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.Renderer);
            this.Controls.Add(this.Menu);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Mandelbrot Renderer";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Render_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Renderer;
        private System.Windows.Forms.NumericUpDown Iterations;
        private System.Windows.Forms.NumericUpDown MaxI;
        private System.Windows.Forms.NumericUpDown MinR;
        private System.Windows.Forms.NumericUpDown MaxR;
        private System.Windows.Forms.NumericUpDown MinI;
        private System.Windows.Forms.Button Set_To_Default;
        private System.Windows.Forms.CheckBox Color_Box;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Button Custom_Mandelbrot;
        private System.Windows.Forms.Button Custom_Back;
        private System.Windows.Forms.ColorDialog MandelColor_Dialog;
        private System.Windows.Forms.ColorDialog BackgroundColor_Dialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

