namespace WinFormsMenu
{
    partial class FrmMenu
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
            menuStrip = new MenuStrip();
            toolStripMenuItemID = new ToolStripMenuItem();
            toolStripMenuItemLogIn = new ToolStripMenuItem();
            toolStripMenuItemQuit = new ToolStripMenuItem();
            toolStripMenuItemP1 = new ToolStripMenuItem();
            toolStripMenuItemP2 = new ToolStripMenuItem();
            toolStripMenuItemP3 = new ToolStripMenuItem();
            toolStripMenuItemWindow = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemID, toolStripMenuItemP1, toolStripMenuItemP2, toolStripMenuItemP3, toolStripMenuItemWindow });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemID
            // 
            toolStripMenuItemID.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemLogIn, toolStripMenuItemQuit });
            toolStripMenuItemID.Name = "toolStripMenuItemID";
            toolStripMenuItemID.Size = new Size(77, 20);
            toolStripMenuItemID.Text = "Connexion";
            // 
            // toolStripMenuItemLogIn
            // 
            toolStripMenuItemLogIn.Name = "toolStripMenuItemLogIn";
            toolStripMenuItemLogIn.Size = new Size(130, 22);
            toolStripMenuItemLogIn.Text = "S'identifier";
            toolStripMenuItemLogIn.Click += toolStripMenuItemLogIn_Click;
            // 
            // toolStripMenuItemQuit
            // 
            toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            toolStripMenuItemQuit.Size = new Size(130, 22);
            toolStripMenuItemQuit.Text = "Quitter";
            // 
            // toolStripMenuItemP1
            // 
            toolStripMenuItemP1.Name = "toolStripMenuItemP1";
            toolStripMenuItemP1.Size = new Size(59, 20);
            toolStripMenuItemP1.Text = "Phase 1";
            toolStripMenuItemP1.Visible = false;
            // 
            // toolStripMenuItemP2
            // 
            toolStripMenuItemP2.Name = "toolStripMenuItemP2";
            toolStripMenuItemP2.Size = new Size(59, 20);
            toolStripMenuItemP2.Text = "Phase 2";
            toolStripMenuItemP2.Visible = false;
            // 
            // toolStripMenuItemP3
            // 
            toolStripMenuItemP3.Name = "toolStripMenuItemP3";
            toolStripMenuItemP3.Size = new Size(59, 20);
            toolStripMenuItemP3.Text = "Phase 3";
            toolStripMenuItemP3.Visible = false;
            // 
            // toolStripMenuItemWindow
            // 
            toolStripMenuItemWindow.Name = "toolStripMenuItemWindow";
            toolStripMenuItemWindow.Size = new Size(63, 20);
            toolStripMenuItemWindow.Text = "Fenêtres";
            toolStripMenuItemWindow.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FrmMenu";
            Text = "Créer des formulaires";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemID;
        private ToolStripMenuItem toolStripMenuItemP1;
        private ToolStripMenuItem toolStripMenuItemP2;
        private ToolStripMenuItem toolStripMenuItemP3;
        private ToolStripMenuItem toolStripMenuItemWindow;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem toolStripMenuItemLogIn;
        private ToolStripMenuItem toolStripMenuItemQuit;
    }
}
