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
            panelTab = new Panel();
            SuspendLayout();
            // 
            // panelProgress
            // 
            panelProgress.Location = new Point(23, 291);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(747, 138);
            panelProgress.TabIndex = 0;
            // 
            // panelTab
            // 
            panelTab.Location = new Point(370, 51);
            panelTab.Name = "panelTab";
            panelTab.Size = new Size(400, 234);
            panelTab.TabIndex = 3;
            // 
            // FormProd2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(panelTab);
            Controls.Add(panelProgress);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormProd2";
            Text = "PRODUCTION DES CAISSES";
            FormClosing += FormProd2_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProgress;
        private UCProd.UserControlProgress userControlProgress1;
        private Panel panelTab;
    }
}
