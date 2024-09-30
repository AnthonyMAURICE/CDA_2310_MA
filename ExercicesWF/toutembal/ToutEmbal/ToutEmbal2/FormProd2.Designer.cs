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
            panelProgress = new Panel();
            tabControl = new TabControl();
            SuspendLayout();
            // 
            // panelProgress
            // 
            panelProgress.Location = new Point(23, 237);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(747, 192);
            panelProgress.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Location = new Point(379, 31);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(391, 190);
            tabControl.TabIndex = 1;
            // 
            // FormProd2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Controls.Add(panelProgress);
            Name = "FormProd2";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProgress;
        private UCProd.UserControlProgress userControlProgress1;
        private TabControl tabControl;
    }
}
