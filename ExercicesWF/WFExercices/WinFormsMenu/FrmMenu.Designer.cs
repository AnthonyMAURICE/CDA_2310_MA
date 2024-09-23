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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            menuStrip = new MenuStrip();
            toolStripMenuItemID = new ToolStripMenuItem();
            toolStripMenuItemLogIn = new ToolStripMenuItem();
            toolStripMenuItemQuit = new ToolStripMenuItem();
            toolStripMenuItemP1 = new ToolStripMenuItem();
            toolStripMenuItemAdd = new ToolStripMenuItem();
            toolStripMenuItemP2 = new ToolStripMenuItem();
            toolStripMenuItemControl = new ToolStripMenuItem();
            toolStripMenuItemP3 = new ToolStripMenuItem();
            toolStripMenuItemWindow = new ToolStripMenuItem();
            toolStripMenuItemCascade = new ToolStripMenuItem();
            toolStripMenuItemLandscape = new ToolStripMenuItem();
            toolStripMenuItemVertical = new ToolStripMenuItem();
            toolStripMenuItemCurrentOpened = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            toolStripButtonLogIn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSplitButtonP3 = new ToolStripSplitButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItemSynthesis = new ToolStripMenuItem();
            toolStripMenuItemColors = new ToolStripMenuItem();
            toolStripMenuItemCombo = new ToolStripMenuItem();
            toolStripMenuItemList = new ToolStripMenuItem();
            toolStripMenuItemCheckRadio = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItemLoan = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            toolStripMenuItemQuit.Click += toolStripMenuItemQuit_Click;
            // 
            // toolStripMenuItemP1
            // 
            toolStripMenuItemP1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAdd });
            toolStripMenuItemP1.Name = "toolStripMenuItemP1";
            toolStripMenuItemP1.Size = new Size(59, 20);
            toolStripMenuItemP1.Text = "Phase 1";
            toolStripMenuItemP1.Visible = false;
            // 
            // toolStripMenuItemAdd
            // 
            toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            toolStripMenuItemAdd.Size = new Size(180, 22);
            toolStripMenuItemAdd.Text = "Additionneur";
            toolStripMenuItemAdd.Click += toolStripMenuItemAdd_Click;
            // 
            // toolStripMenuItemP2
            // 
            toolStripMenuItemP2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemControl });
            toolStripMenuItemP2.Name = "toolStripMenuItemP2";
            toolStripMenuItemP2.Size = new Size(59, 20);
            toolStripMenuItemP2.Text = "Phase 2";
            toolStripMenuItemP2.Visible = false;
            // 
            // toolStripMenuItemControl
            // 
            toolStripMenuItemControl.Name = "toolStripMenuItemControl";
            toolStripMenuItemControl.Size = new Size(125, 22);
            toolStripMenuItemControl.Text = "Contrôles";
            // 
            // toolStripMenuItemP3
            // 
            toolStripMenuItemP3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItemLoan });
            toolStripMenuItemP3.Name = "toolStripMenuItemP3";
            toolStripMenuItemP3.Size = new Size(59, 20);
            toolStripMenuItemP3.Text = "Phase 3";
            toolStripMenuItemP3.Visible = false;
            // 
            // toolStripMenuItemWindow
            // 
            toolStripMenuItemWindow.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemCascade, toolStripMenuItemLandscape, toolStripMenuItemVertical, toolStripMenuItemCurrentOpened });
            toolStripMenuItemWindow.Name = "toolStripMenuItemWindow";
            toolStripMenuItemWindow.Size = new Size(63, 20);
            toolStripMenuItemWindow.Text = "Fenêtres";
            toolStripMenuItemWindow.Visible = false;
            // 
            // toolStripMenuItemCascade
            // 
            toolStripMenuItemCascade.Name = "toolStripMenuItemCascade";
            toolStripMenuItemCascade.Size = new Size(180, 22);
            toolStripMenuItemCascade.Text = "Cascade";
            // 
            // toolStripMenuItemLandscape
            // 
            toolStripMenuItemLandscape.Name = "toolStripMenuItemLandscape";
            toolStripMenuItemLandscape.Size = new Size(180, 22);
            toolStripMenuItemLandscape.Text = "Horizontal";
            // 
            // toolStripMenuItemVertical
            // 
            toolStripMenuItemVertical.Name = "toolStripMenuItemVertical";
            toolStripMenuItemVertical.Size = new Size(180, 22);
            toolStripMenuItemVertical.Text = "Vertical";
            // 
            // toolStripMenuItemCurrentOpened
            // 
            toolStripMenuItemCurrentOpened.Name = "toolStripMenuItemCurrentOpened";
            toolStripMenuItemCurrentOpened.Size = new Size(180, 22);
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonLogIn, toolStripSeparator1, toolStripSplitButtonP3, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLogIn
            // 
            toolStripButtonLogIn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonLogIn.Image = (Image)resources.GetObject("toolStripButtonLogIn.Image");
            toolStripButtonLogIn.ImageTransparentColor = Color.Magenta;
            toolStripButtonLogIn.Name = "toolStripButtonLogIn";
            toolStripButtonLogIn.Size = new Size(67, 22);
            toolStripButtonLogIn.Text = "S'identifier";
            toolStripButtonLogIn.Click += toolStripMenuItemLogIn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSplitButtonP3
            // 
            toolStripSplitButtonP3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonP3.Image = (Image)resources.GetObject("toolStripSplitButtonP3.Image");
            toolStripSplitButtonP3.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonP3.Name = "toolStripSplitButtonP3";
            toolStripSplitButtonP3.Size = new Size(63, 22);
            toolStripSplitButtonP3.Text = "Phase 3";
            toolStripSplitButtonP3.Visible = false;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            toolStripSeparator2.Visible = false;
            // 
            // toolStripMenuItemSynthesis
            // 
            toolStripMenuItemSynthesis.Name = "toolStripMenuItemSynthesis";
            toolStripMenuItemSynthesis.Size = new Size(121, 22);
            toolStripMenuItemSynthesis.Text = "Synthèse";
            // 
            // toolStripMenuItemColors
            // 
            toolStripMenuItemColors.Name = "toolStripMenuItemColors";
            toolStripMenuItemColors.Size = new Size(132, 22);
            toolStripMenuItemColors.Text = "Défilement";
            // 
            // toolStripMenuItemCombo
            // 
            toolStripMenuItemCombo.Name = "toolStripMenuItemCombo";
            toolStripMenuItemCombo.Size = new Size(134, 22);
            toolStripMenuItemCombo.Text = "ComboBox";
            // 
            // toolStripMenuItemList
            // 
            toolStripMenuItemList.Name = "toolStripMenuItemList";
            toolStripMenuItemList.Size = new Size(134, 22);
            toolStripMenuItemList.Text = "Listes";
            // 
            // toolStripMenuItemCheckRadio
            // 
            toolStripMenuItemCheckRadio.Name = "toolStripMenuItemCheckRadio";
            toolStripMenuItemCheckRadio.Size = new Size(134, 22);
            toolStripMenuItemCheckRadio.Text = "Cases";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripMenuItemLoan
            // 
            toolStripMenuItemLoan.Name = "toolStripMenuItemLoan";
            toolStripMenuItemLoan.Size = new Size(180, 22);
            toolStripMenuItemLoan.Text = "Synthèse";
            toolStripMenuItemLoan.Click += toolStripMenuItemLoan_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FrmMenu";
            Text = "Créer des formulaires";
            FormClosing += FrmMenu_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStripButton toolStripButtonLogIn;
        private ToolStripMenuItem toolStripMenuItemAdd;
        private ToolStripMenuItem toolStripMenuItemControl;
        private ToolStripMenuItem toolStripMenuItemCascade;
        private ToolStripMenuItem toolStripMenuItemLandscape;
        private ToolStripMenuItem toolStripMenuItemVertical;
        private ToolStripMenuItem toolStripMenuItemCurrentOpened;
        private ToolStripMenuItem toolStripMenuItemSynthesis;
        private ToolStripMenuItem toolStripMenuItemColors;
        private ToolStripMenuItem toolStripMenuItemCombo;
        private ToolStripMenuItem toolStripMenuItemList;
        private ToolStripMenuItem toolStripMenuItemCheckRadio;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton toolStripSplitButtonP3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItemLoan;
    }
}
