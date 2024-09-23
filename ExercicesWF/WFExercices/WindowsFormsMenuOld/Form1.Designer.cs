namespace WindowsFormsMenuOld
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemP1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemP2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemControl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemP3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCases = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHoriz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonP3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLog,
            this.toolStripMenuItemP1,
            this.toolStripMenuItemP2,
            this.toolStripMenuItemP3,
            this.toolStripMenuItemWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemLog
            // 
            this.toolStripMenuItemLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLogIn,
            this.toolStripMenuItemQuit});
            this.toolStripMenuItemLog.Name = "toolStripMenuItemLog";
            this.toolStripMenuItemLog.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItemLog.Text = "Connexion";
            // 
            // toolStripMenuItemLogIn
            // 
            this.toolStripMenuItemLogIn.Name = "toolStripMenuItemLogIn";
            this.toolStripMenuItemLogIn.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemLogIn.Text = "S\'identifier";
            this.toolStripMenuItemLogIn.Click += new System.EventHandler(this.toolStripMenuItemLogIn_Click);
            // 
            // toolStripMenuItemQuit
            // 
            this.toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            this.toolStripMenuItemQuit.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemQuit.Text = "Quitter";
            this.toolStripMenuItemQuit.Click += new System.EventHandler(this.toolStripMenuItemQuit_Click);
            // 
            // toolStripMenuItemP1
            // 
            this.toolStripMenuItemP1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInput});
            this.toolStripMenuItemP1.Enabled = false;
            this.toolStripMenuItemP1.Name = "toolStripMenuItemP1";
            this.toolStripMenuItemP1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItemP1.Text = "Phase 1";
            this.toolStripMenuItemP1.Visible = false;
            // 
            // toolStripMenuItemInput
            // 
            this.toolStripMenuItemInput.Name = "toolStripMenuItemInput";
            this.toolStripMenuItemInput.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemInput.Text = "Saisie";
            this.toolStripMenuItemInput.Click += new System.EventHandler(this.toolStripMenuItemInput_Click);
            // 
            // toolStripMenuItemP2
            // 
            this.toolStripMenuItemP2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemControl});
            this.toolStripMenuItemP2.Enabled = false;
            this.toolStripMenuItemP2.Name = "toolStripMenuItemP2";
            this.toolStripMenuItemP2.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItemP2.Text = "Phase 2";
            this.toolStripMenuItemP2.Visible = false;
            // 
            // toolStripMenuItemControl
            // 
            this.toolStripMenuItemControl.Name = "toolStripMenuItemControl";
            this.toolStripMenuItemControl.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItemControl.Text = "Contrôle";
            this.toolStripMenuItemControl.Click += new System.EventHandler(this.toolStripMenuItemControl_Click);
            // 
            // toolStripMenuItemP3
            // 
            this.toolStripMenuItemP3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCases});
            this.toolStripMenuItemP3.Enabled = false;
            this.toolStripMenuItemP3.Name = "toolStripMenuItemP3";
            this.toolStripMenuItemP3.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItemP3.Text = "Phase 3";
            this.toolStripMenuItemP3.Visible = false;
            // 
            // toolStripMenuItemCases
            // 
            this.toolStripMenuItemCases.Name = "toolStripMenuItemCases";
            this.toolStripMenuItemCases.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItemCases.Text = "Cases";
            this.toolStripMenuItemCases.Click += new System.EventHandler(this.toolStripMenuItemCases_Click);
            // 
            // toolStripMenuItemWindow
            // 
            this.toolStripMenuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCascade,
            this.toolStripMenuItemHoriz,
            this.toolStripMenuItemVertical,
            this.toolStripSeparator3});
            this.toolStripMenuItemWindow.Enabled = false;
            this.toolStripMenuItemWindow.Name = "toolStripMenuItemWindow";
            this.toolStripMenuItemWindow.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItemWindow.Text = "Fenêtres";
            this.toolStripMenuItemWindow.Visible = false;
            // 
            // toolStripMenuItemCascade
            // 
            this.toolStripMenuItemCascade.Name = "toolStripMenuItemCascade";
            this.toolStripMenuItemCascade.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItemCascade.Text = "Cascade";
            // 
            // toolStripMenuItemHoriz
            // 
            this.toolStripMenuItemHoriz.Name = "toolStripMenuItemHoriz";
            this.toolStripMenuItemHoriz.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItemHoriz.Text = "Horizontal";
            // 
            // toolStripMenuItemVertical
            // 
            this.toolStripMenuItemVertical.Name = "toolStripMenuItemVertical";
            this.toolStripMenuItemVertical.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItemVertical.Text = "Vertical";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(126, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSplitButtonP3,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton1.Text = "S\'identifier";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripMenuItemLogIn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButtonP3
            // 
            this.toolStripSplitButtonP3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonP3.Enabled = false;
            this.toolStripSplitButtonP3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonP3.Image")));
            this.toolStripSplitButtonP3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonP3.Name = "toolStripSplitButtonP3";
            this.toolStripSplitButtonP3.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButtonP3.Text = "Phase 3";
            this.toolStripSplitButtonP3.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelDate
            // 
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(69, 17);
            this.labelDate.Text = "placeholder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogIn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemP1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemP2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemP3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWindow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonP3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInput;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCases;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHoriz;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel labelDate;
    }
}

