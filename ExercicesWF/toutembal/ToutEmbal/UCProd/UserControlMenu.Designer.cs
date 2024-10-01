namespace UCProd
{
    partial class UserControlMenu
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, productionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(820, 24);
            menuStrip1.TabIndex = 0;
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
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "Production";
            // 
            // UserControlMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            Name = "UserControlMenu";
            Size = new Size(820, 24);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
    }
}
