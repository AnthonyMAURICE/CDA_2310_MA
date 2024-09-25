namespace ToutEmbal2
{
    partial class FormProd2
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
            panel1 = new Panel();
            userControlProgress1 = new UCProd.UserControlProgress();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(userControlProgress1);
            panel1.Location = new Point(23, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 192);
            panel1.TabIndex = 0;
            // 
            // userControlProgress1
            // 
            userControlProgress1.Dock = DockStyle.Top;
            userControlProgress1.Location = new Point(0, 0);
            userControlProgress1.Name = "userControlProgress1";
            userControlProgress1.Size = new Size(747, 69);
            userControlProgress1.TabIndex = 0;
            // 
            // FormProd2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormProd2";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private UCProd.UserControlProgress userControlProgress1;
    }
}
