namespace WFMenu
{
    partial class FormMenu
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
            toolStripBtnLogin = new ToolStrip();
            statusStrip1 = new StatusStrip();
            MenuItemCo = new ToolStripMenuItem();
            toolStripMenuItemID = new ToolStripMenuItem();
            toolStripMenuItemQuit = new ToolStripMenuItem();
            MenuItemP1 = new ToolStripMenuItem();
            MenuItemP2 = new ToolStripMenuItem();
            MenuItemP3 = new ToolStripMenuItem();
            MenuItemW1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            toolStripButtonBtnLogin = new ToolStripButton();
            toolStripBtnLogin.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripBtnLogin
            // 
            toolStripBtnLogin.Items.AddRange(new ToolStripItem[] { toolStripButtonBtnLogin });
            toolStripBtnLogin.Location = new Point(0, 24);
            toolStripBtnLogin.Name = "toolStripBtnLogin";
            toolStripBtnLogin.Size = new Size(800, 25);
            toolStripBtnLogin.TabIndex = 1;
            toolStripBtnLogin.Text = "S'identifier";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // MenuItemCo
            // 
            MenuItemCo.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemID, toolStripMenuItemQuit });
            MenuItemCo.Name = "MenuItemCo";
            MenuItemCo.Size = new Size(77, 20);
            MenuItemCo.Text = "Connexion";
            // 
            // toolStripMenuItemID
            // 
            toolStripMenuItemID.Name = "toolStripMenuItemID";
            toolStripMenuItemID.Size = new Size(130, 22);
            toolStripMenuItemID.Text = "S'identifier";
            // 
            // toolStripMenuItemQuit
            // 
            toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            toolStripMenuItemQuit.Size = new Size(130, 22);
            toolStripMenuItemQuit.Text = "Quitter";
            // 
            // MenuItemP1
            // 
            MenuItemP1.Name = "MenuItemP1";
            MenuItemP1.Size = new Size(59, 20);
            MenuItemP1.Text = "Phase 1";
            MenuItemP1.Visible = false;
            // 
            // MenuItemP2
            // 
            MenuItemP2.Name = "MenuItemP2";
            MenuItemP2.Size = new Size(59, 20);
            MenuItemP2.Text = "Phase 2";
            MenuItemP2.Visible = false;
            // 
            // MenuItemP3
            // 
            MenuItemP3.Name = "MenuItemP3";
            MenuItemP3.Size = new Size(59, 20);
            MenuItemP3.Text = "Phase 3";
            MenuItemP3.Visible = false;
            // 
            // MenuItemW1
            // 
            MenuItemW1.Name = "MenuItemW1";
            MenuItemW1.Size = new Size(63, 20);
            MenuItemW1.Text = "Fenêtres";
            MenuItemW1.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuItemCo, MenuItemP1, MenuItemP2, MenuItemP3, MenuItemW1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripButtonBtnLogin
            // 
            toolStripButtonBtnLogin.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonBtnLogin.ImageTransparentColor = Color.Magenta;
            toolStripButtonBtnLogin.Name = "toolStripButtonBtnLogin";
            toolStripButtonBtnLogin.Size = new Size(67, 22);
            toolStripButtonBtnLogin.Text = "S'identifier";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStripBtnLogin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "Créer des formulaires";
            toolStripBtnLogin.ResumeLayout(false);
            toolStripBtnLogin.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStripBtnLogin;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem MenuItemCo;
        private ToolStripMenuItem MenuItemP1;
        private ToolStripMenuItem MenuItemP2;
        private ToolStripMenuItem MenuItemP3;
        private ToolStripMenuItem MenuItemW1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemID;
        private ToolStripMenuItem toolStripMenuItemQuit;
        private ToolStripButton toolStripButtonBtnLogin;
    }
}
