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
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            démarrerToolStripMenuItem = new ToolStripMenuItem();
            suspendreToolStripMenuItem = new ToolStripMenuItem();
            continuerToolStripMenuItem = new ToolStripMenuItem();
            panelTab = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelProgress
            // 
            panelProgress.Location = new Point(23, 237);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(747, 192);
            panelProgress.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, productionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(111, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { démarrerToolStripMenuItem, suspendreToolStripMenuItem, continuerToolStripMenuItem });
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            démarrerToolStripMenuItem.Size = new Size(180, 22);
            démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // suspendreToolStripMenuItem
            // 
            suspendreToolStripMenuItem.Name = "suspendreToolStripMenuItem";
            suspendreToolStripMenuItem.Size = new Size(180, 22);
            suspendreToolStripMenuItem.Text = "Suspendre";
            // 
            // continuerToolStripMenuItem
            // 
            continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            continuerToolStripMenuItem.Size = new Size(180, 22);
            continuerToolStripMenuItem.Text = "Continuer";
            // 
            // panelTab
            // 
            panelTab.Location = new Point(364, 44);
            panelTab.Name = "panelTab";
            panelTab.Size = new Size(406, 178);
            panelTab.TabIndex = 3;
            // 
            // FormProd2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTab);
            Controls.Add(panelProgress);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormProd2";
            Text = "Form1";
            FormClosing += FormProd2_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelProgress;
        private UCProd.UserControlProgress userControlProgress1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ToolStripMenuItem démarrerToolStripMenuItem;
        private ToolStripMenuItem suspendreToolStripMenuItem;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private Panel panelTab;
    }
}
