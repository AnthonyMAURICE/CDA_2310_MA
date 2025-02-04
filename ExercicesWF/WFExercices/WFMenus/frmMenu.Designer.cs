namespace WFMenus
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            menuStrip1 = new MenuStrip();
            toolStripMenuItemID = new ToolStripMenuItem();
            toolStripMenuItemLogIn = new ToolStripMenuItem();
            toolStripMenuItemQuit = new ToolStripMenuItem();
            toolStripMenuItemP1 = new ToolStripMenuItem();
            toolStripMenuItemP2 = new ToolStripMenuItem();
            toolStripMenuItemP3 = new ToolStripMenuItem();
            toolStripMenuItemWindows = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButtonID = new ToolStripButton();
            connexionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemID, toolStripMenuItemP1, toolStripMenuItemP2, toolStripMenuItemP3, toolStripMenuItemWindows });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            // toolStripMenuItemWindows
            // 
            toolStripMenuItemWindows.Name = "toolStripMenuItemWindows";
            toolStripMenuItemWindows.Size = new Size(63, 20);
            toolStripMenuItemWindows.Text = "Fenêtres";
            toolStripMenuItemWindows.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(27, 17);
            toolStripStatusLabel1.Text = "Test";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonID });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonID
            // 
            toolStripButtonID.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonID.Image = (Image)resources.GetObject("toolStripButtonID.Image");
            toolStripButtonID.ImageTransparentColor = Color.Magenta;
            toolStripButtonID.Name = "toolStripButtonID";
            toolStripButtonID.Size = new Size(67, 22);
            toolStripButtonID.Text = "S'identifier";
            toolStripButtonID.Click += toolStripMenuItemLogIn_Click;
            // 
            // connexionToolStripMenuItem
            // 
            connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            connexionToolStripMenuItem.Size = new Size(132, 22);
            connexionToolStripMenuItem.Text = "Connexion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Créer des formulaires";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem toolStripMenuItemID;
        private ToolStripMenuItem toolStripMenuItemP1;
        private ToolStripMenuItem toolStripMenuItemP2;
        private ToolStripMenuItem toolStripMenuItemP3;
        private ToolStripMenuItem toolStripMenuItemWindows;
        private ToolStripMenuItem toolStripMenuItemLogIn;
        private ToolStripMenuItem toolStripMenuItemQuit;
        private ToolStripMenuItem connexionToolStripMenuItem;
        private ToolStripButton toolStripButtonID;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
