namespace FormRange
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelRed = new Label();
            labelGreen = new Label();
            labelBlue = new Label();
            numericUpDownRed = new NumericUpDown();
            numericUpDownGreen = new NumericUpDown();
            numericUpDownBlue = new NumericUpDown();
            hScrollBarRed = new HScrollBar();
            hScrollBarGreen = new HScrollBar();
            hScrollBarBlue = new HScrollBar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBoxColorized = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).BeginInit();
            SuspendLayout();
            // 
            // labelRed
            // 
            labelRed.AutoSize = true;
            labelRed.Location = new Point(16, 39);
            labelRed.Name = "labelRed";
            labelRed.Size = new Size(41, 15);
            labelRed.TabIndex = 0;
            labelRed.Text = "Rouge";
            // 
            // labelGreen
            // 
            labelGreen.AutoSize = true;
            labelGreen.Location = new Point(16, 80);
            labelGreen.Name = "labelGreen";
            labelGreen.Size = new Size(27, 15);
            labelGreen.TabIndex = 1;
            labelGreen.Text = "Vert";
            // 
            // labelBlue
            // 
            labelBlue.AutoSize = true;
            labelBlue.Location = new Point(16, 124);
            labelBlue.Name = "labelBlue";
            labelBlue.Size = new Size(30, 15);
            labelBlue.TabIndex = 2;
            labelBlue.Text = "Bleu";
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.Location = new Point(340, 37);
            numericUpDownRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(52, 23);
            numericUpDownRed.TabIndex = 3;
            numericUpDownRed.Value = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownRed.ValueChanged += numericUpDownRed_ValueChanged;
            // 
            // numericUpDownGreen
            // 
            numericUpDownGreen.Location = new Point(340, 78);
            numericUpDownGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownGreen.Name = "numericUpDownGreen";
            numericUpDownGreen.Size = new Size(52, 23);
            numericUpDownGreen.TabIndex = 4;
            numericUpDownGreen.ValueChanged += numericUpDownGreen_ValueChanged;
            // 
            // numericUpDownBlue
            // 
            numericUpDownBlue.Location = new Point(340, 122);
            numericUpDownBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBlue.Name = "numericUpDownBlue";
            numericUpDownBlue.Size = new Size(52, 23);
            numericUpDownBlue.TabIndex = 5;
            numericUpDownBlue.ValueChanged += numericUpDownBlue_ValueChanged;
            // 
            // hScrollBarRed
            // 
            hScrollBarRed.Location = new Point(71, 37);
            hScrollBarRed.Maximum = 264;
            hScrollBarRed.Name = "hScrollBarRed";
            hScrollBarRed.Size = new Size(238, 17);
            hScrollBarRed.TabIndex = 6;
            hScrollBarRed.Scroll += hScrollBarRed_Scroll;
            // 
            // hScrollBarGreen
            // 
            hScrollBarGreen.Location = new Point(71, 78);
            hScrollBarGreen.Maximum = 264;
            hScrollBarGreen.Name = "hScrollBarGreen";
            hScrollBarGreen.Size = new Size(238, 17);
            hScrollBarGreen.TabIndex = 7;
            hScrollBarGreen.Scroll += hScrollBarGreen_Scroll;
            // 
            // hScrollBarBlue
            // 
            hScrollBarBlue.Location = new Point(71, 122);
            hScrollBarBlue.Maximum = 264;
            hScrollBarBlue.Name = "hScrollBarBlue";
            hScrollBarBlue.Size = new Size(238, 17);
            hScrollBarBlue.TabIndex = 8;
            hScrollBarBlue.Scroll += hScrollBarBlue_Scroll;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Red;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(425, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(81, 16);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Green;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Location = new Point(425, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(81, 16);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Blue;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Location = new Point(425, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(81, 16);
            textBox3.TabIndex = 11;
            // 
            // textBoxColorized
            // 
            textBoxColorized.Enabled = false;
            textBoxColorized.Location = new Point(16, 174);
            textBoxColorized.Multiline = true;
            textBoxColorized.Name = "textBoxColorized";
            textBoxColorized.Size = new Size(490, 135);
            textBoxColorized.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 333);
            Controls.Add(textBoxColorized);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(hScrollBarBlue);
            Controls.Add(hScrollBarGreen);
            Controls.Add(hScrollBarRed);
            Controls.Add(numericUpDownBlue);
            Controls.Add(numericUpDownGreen);
            Controls.Add(numericUpDownRed);
            Controls.Add(labelBlue);
            Controls.Add(labelGreen);
            Controls.Add(labelRed);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRed;
        private Label labelGreen;
        private Label labelBlue;
        private NumericUpDown numericUpDownRed;
        private NumericUpDown numericUpDownGreen;
        private NumericUpDown numericUpDownBlue;
        private HScrollBar hScrollBarRed;
        private HScrollBar hScrollBarGreen;
        private HScrollBar hScrollBarBlue;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBoxColorized;
    }
}
