namespace ToutEmbal
{
    partial class FormProd
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItemFile = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemProd = new ToolStripMenuItem();
            toolStripMenuItemStart = new ToolStripMenuItem();
            aToolStripMenuItemStart = new ToolStripMenuItem();
            bToolStripMenuItemStart = new ToolStripMenuItem();
            cToolStripMenuItemStart = new ToolStripMenuItem();
            toolStripMenuItemStop = new ToolStripMenuItem();
            aToolStripMenuItemStop = new ToolStripMenuItem();
            bToolStripMenuItemStop = new ToolStripMenuItem();
            cToolStripMenuItemStop = new ToolStripMenuItem();
            toolStripMenuItemResume = new ToolStripMenuItem();
            aToolStripMenuItemContinue = new ToolStripMenuItem();
            bToolStripMenuItemContinue = new ToolStripMenuItem();
            cToolStripMenuItemContinue = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPageA = new TabPage();
            textBoxFlawsTotalA = new TextBox();
            textBoxFlawsHoursA = new TextBox();
            textBoxTotalA = new TextBox();
            labelTotalFlaws = new Label();
            labelFlawsHour = new Label();
            labelTotal = new Label();
            tabPageB = new TabPage();
            textBoxFlawsTotalB = new TextBox();
            textBoxFlawsHourB = new TextBox();
            textBoxTotalB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabPageC = new TabPage();
            textBoxFlawsTotalC = new TextBox();
            textBoxFlawsHourC = new TextBox();
            textBoxTotalC = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelProd1 = new Label();
            labelProd2 = new Label();
            labelProd3 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageA.SuspendLayout();
            tabPageB.SuspendLayout();
            tabPageC.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuItemProd });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(776, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { quitterToolStripMenuItem });
            toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            toolStripMenuItemFile.Size = new Size(54, 20);
            toolStripMenuItemFile.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(111, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // toolStripMenuItemProd
            // 
            toolStripMenuItemProd.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemStart, toolStripMenuItemStop, toolStripMenuItemResume });
            toolStripMenuItemProd.Name = "toolStripMenuItemProd";
            toolStripMenuItemProd.Size = new Size(78, 20);
            toolStripMenuItemProd.Text = "Production";
            // 
            // toolStripMenuItemStart
            // 
            toolStripMenuItemStart.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItemStart, bToolStripMenuItemStart, cToolStripMenuItemStart });
            toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            toolStripMenuItemStart.Size = new Size(129, 22);
            toolStripMenuItemStart.Text = "Démarrer";
            // 
            // aToolStripMenuItemStart
            // 
            aToolStripMenuItemStart.Name = "aToolStripMenuItemStart";
            aToolStripMenuItemStart.Size = new Size(82, 22);
            aToolStripMenuItemStart.Tag = "A";
            aToolStripMenuItemStart.Text = "A";
            aToolStripMenuItemStart.Click += aToolStripMenuItemStart_Click;
            aToolStripMenuItemStart.EnabledChanged += aToolStripMenuItemStart_EnabledChanged;
            // 
            // bToolStripMenuItemStart
            // 
            bToolStripMenuItemStart.Name = "bToolStripMenuItemStart";
            bToolStripMenuItemStart.Size = new Size(82, 22);
            bToolStripMenuItemStart.Tag = "B";
            bToolStripMenuItemStart.Text = "B";
            bToolStripMenuItemStart.Click += aToolStripMenuItemStart_Click;
            bToolStripMenuItemStart.EnabledChanged += aToolStripMenuItemStart_EnabledChanged;
            // 
            // cToolStripMenuItemStart
            // 
            cToolStripMenuItemStart.Name = "cToolStripMenuItemStart";
            cToolStripMenuItemStart.Size = new Size(82, 22);
            cToolStripMenuItemStart.Tag = "C";
            cToolStripMenuItemStart.Text = "C";
            cToolStripMenuItemStart.Click += aToolStripMenuItemStart_Click;
            cToolStripMenuItemStart.EnabledChanged += aToolStripMenuItemStart_EnabledChanged;
            // 
            // toolStripMenuItemStop
            // 
            toolStripMenuItemStop.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItemStop, bToolStripMenuItemStop, cToolStripMenuItemStop });
            toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            toolStripMenuItemStop.Size = new Size(129, 22);
            toolStripMenuItemStop.Text = "Suspendre";
            // 
            // aToolStripMenuItemStop
            // 
            aToolStripMenuItemStop.Enabled = false;
            aToolStripMenuItemStop.Name = "aToolStripMenuItemStop";
            aToolStripMenuItemStop.Size = new Size(82, 22);
            aToolStripMenuItemStop.Tag = "A";
            aToolStripMenuItemStop.Text = "A";
            aToolStripMenuItemStop.Click += aToolStripMenuItemStart_Click;
            aToolStripMenuItemStop.EnabledChanged += aToolStripMenuItemStop_EnabledChanged;
            // 
            // bToolStripMenuItemStop
            // 
            bToolStripMenuItemStop.Enabled = false;
            bToolStripMenuItemStop.Name = "bToolStripMenuItemStop";
            bToolStripMenuItemStop.Size = new Size(82, 22);
            bToolStripMenuItemStop.Tag = "B";
            bToolStripMenuItemStop.Text = "B";
            bToolStripMenuItemStop.Click += aToolStripMenuItemStart_Click;
            bToolStripMenuItemStop.EnabledChanged += aToolStripMenuItemStop_EnabledChanged;
            // 
            // cToolStripMenuItemStop
            // 
            cToolStripMenuItemStop.Enabled = false;
            cToolStripMenuItemStop.Name = "cToolStripMenuItemStop";
            cToolStripMenuItemStop.Size = new Size(82, 22);
            cToolStripMenuItemStop.Tag = "C";
            cToolStripMenuItemStop.Text = "C";
            cToolStripMenuItemStop.Click += aToolStripMenuItemStart_Click;
            cToolStripMenuItemStop.EnabledChanged += aToolStripMenuItemStop_EnabledChanged;
            // 
            // toolStripMenuItemResume
            // 
            toolStripMenuItemResume.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItemContinue, bToolStripMenuItemContinue, cToolStripMenuItemContinue });
            toolStripMenuItemResume.Name = "toolStripMenuItemResume";
            toolStripMenuItemResume.Size = new Size(129, 22);
            toolStripMenuItemResume.Text = "Continuer";
            // 
            // aToolStripMenuItemContinue
            // 
            aToolStripMenuItemContinue.Enabled = false;
            aToolStripMenuItemContinue.Name = "aToolStripMenuItemContinue";
            aToolStripMenuItemContinue.Size = new Size(82, 22);
            aToolStripMenuItemContinue.Tag = "A";
            aToolStripMenuItemContinue.Text = "A";
            aToolStripMenuItemContinue.Click += aToolStripMenuItemStart_Click;
            aToolStripMenuItemContinue.EnabledChanged += aToolStripMenuItemStart_EnabledChanged;
            // 
            // bToolStripMenuItemContinue
            // 
            bToolStripMenuItemContinue.Enabled = false;
            bToolStripMenuItemContinue.Name = "bToolStripMenuItemContinue";
            bToolStripMenuItemContinue.Size = new Size(82, 22);
            bToolStripMenuItemContinue.Tag = "B";
            bToolStripMenuItemContinue.Text = "B";
            bToolStripMenuItemContinue.Click += aToolStripMenuItemStart_Click;
            bToolStripMenuItemContinue.EnabledChanged += aToolStripMenuItemStart_Click;
            // 
            // cToolStripMenuItemContinue
            // 
            cToolStripMenuItemContinue.Enabled = false;
            cToolStripMenuItemContinue.Name = "cToolStripMenuItemContinue";
            cToolStripMenuItemContinue.Size = new Size(82, 22);
            cToolStripMenuItemContinue.Tag = "C";
            cToolStripMenuItemContinue.Text = "C";
            cToolStripMenuItemContinue.Click += aToolStripMenuItemStart_Click;
            cToolStripMenuItemContinue.EnabledChanged += aToolStripMenuItemStart_EnabledChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageA);
            tabControl1.Controls.Add(tabPageB);
            tabControl1.Controls.Add(tabPageC);
            tabControl1.Location = new Point(255, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(473, 208);
            tabControl1.TabIndex = 1;
            // 
            // tabPageA
            // 
            tabPageA.Controls.Add(textBoxFlawsTotalA);
            tabPageA.Controls.Add(textBoxFlawsHoursA);
            tabPageA.Controls.Add(textBoxTotalA);
            tabPageA.Controls.Add(labelTotalFlaws);
            tabPageA.Controls.Add(labelFlawsHour);
            tabPageA.Controls.Add(labelTotal);
            tabPageA.Location = new Point(4, 24);
            tabPageA.Name = "tabPageA";
            tabPageA.Padding = new Padding(3);
            tabPageA.Size = new Size(465, 180);
            tabPageA.TabIndex = 0;
            tabPageA.Text = "Type A";
            tabPageA.UseVisualStyleBackColor = true;
            // 
            // textBoxFlawsTotalA
            // 
            textBoxFlawsTotalA.Location = new Point(337, 126);
            textBoxFlawsTotalA.Name = "textBoxFlawsTotalA";
            textBoxFlawsTotalA.ReadOnly = true;
            textBoxFlawsTotalA.Size = new Size(100, 23);
            textBoxFlawsTotalA.TabIndex = 5;
            // 
            // textBoxFlawsHoursA
            // 
            textBoxFlawsHoursA.Location = new Point(337, 83);
            textBoxFlawsHoursA.Name = "textBoxFlawsHoursA";
            textBoxFlawsHoursA.ReadOnly = true;
            textBoxFlawsHoursA.Size = new Size(100, 23);
            textBoxFlawsHoursA.TabIndex = 4;
            // 
            // textBoxTotalA
            // 
            textBoxTotalA.Location = new Point(337, 43);
            textBoxTotalA.Name = "textBoxTotalA";
            textBoxTotalA.ReadOnly = true;
            textBoxTotalA.Size = new Size(100, 23);
            textBoxTotalA.TabIndex = 3;
            textBoxTotalA.Tag = "A";
            // 
            // labelTotalFlaws
            // 
            labelTotalFlaws.AutoSize = true;
            labelTotalFlaws.Location = new Point(29, 126);
            labelTotalFlaws.Name = "labelTotalFlaws";
            labelTotalFlaws.Size = new Size(166, 15);
            labelTotalFlaws.TabIndex = 2;
            labelTotalFlaws.Text = "Taux défaut depuis démarrage";
            // 
            // labelFlawsHour
            // 
            labelFlawsHour.AutoSize = true;
            labelFlawsHour.Location = new Point(29, 83);
            labelFlawsHour.Name = "labelFlawsHour";
            labelFlawsHour.Size = new Size(101, 15);
            labelFlawsHour.TabIndex = 1;
            labelFlawsHour.Text = "Taux défaut heure";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(29, 43);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(216, 15);
            labelTotal.TabIndex = 0;
            labelTotal.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPageB
            // 
            tabPageB.Controls.Add(textBoxFlawsTotalB);
            tabPageB.Controls.Add(textBoxFlawsHourB);
            tabPageB.Controls.Add(textBoxTotalB);
            tabPageB.Controls.Add(label1);
            tabPageB.Controls.Add(label2);
            tabPageB.Controls.Add(label3);
            tabPageB.Location = new Point(4, 24);
            tabPageB.Name = "tabPageB";
            tabPageB.Padding = new Padding(3);
            tabPageB.Size = new Size(465, 180);
            tabPageB.TabIndex = 1;
            tabPageB.Text = "Type B";
            tabPageB.UseVisualStyleBackColor = true;
            // 
            // textBoxFlawsTotalB
            // 
            textBoxFlawsTotalB.Location = new Point(336, 126);
            textBoxFlawsTotalB.Name = "textBoxFlawsTotalB";
            textBoxFlawsTotalB.ReadOnly = true;
            textBoxFlawsTotalB.Size = new Size(100, 23);
            textBoxFlawsTotalB.TabIndex = 11;
            // 
            // textBoxFlawsHourB
            // 
            textBoxFlawsHourB.Location = new Point(336, 83);
            textBoxFlawsHourB.Name = "textBoxFlawsHourB";
            textBoxFlawsHourB.ReadOnly = true;
            textBoxFlawsHourB.Size = new Size(100, 23);
            textBoxFlawsHourB.TabIndex = 10;
            // 
            // textBoxTotalB
            // 
            textBoxTotalB.Location = new Point(336, 43);
            textBoxTotalB.Name = "textBoxTotalB";
            textBoxTotalB.ReadOnly = true;
            textBoxTotalB.Size = new Size(100, 23);
            textBoxTotalB.TabIndex = 9;
            textBoxTotalB.Tag = "A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 126);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 8;
            label1.Text = "Taux défaut depuis démarrage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 83);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 7;
            label2.Text = "Taux défaut heure";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 43);
            label3.Name = "label3";
            label3.Size = new Size(216, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPageC
            // 
            tabPageC.Controls.Add(textBoxFlawsTotalC);
            tabPageC.Controls.Add(textBoxFlawsHourC);
            tabPageC.Controls.Add(textBoxTotalC);
            tabPageC.Controls.Add(label4);
            tabPageC.Controls.Add(label5);
            tabPageC.Controls.Add(label6);
            tabPageC.Location = new Point(4, 24);
            tabPageC.Name = "tabPageC";
            tabPageC.Padding = new Padding(3);
            tabPageC.Size = new Size(465, 180);
            tabPageC.TabIndex = 2;
            tabPageC.Text = "Type C";
            tabPageC.UseVisualStyleBackColor = true;
            // 
            // textBoxFlawsTotalC
            // 
            textBoxFlawsTotalC.Location = new Point(336, 126);
            textBoxFlawsTotalC.Name = "textBoxFlawsTotalC";
            textBoxFlawsTotalC.ReadOnly = true;
            textBoxFlawsTotalC.Size = new Size(100, 23);
            textBoxFlawsTotalC.TabIndex = 11;
            // 
            // textBoxFlawsHourC
            // 
            textBoxFlawsHourC.Location = new Point(336, 83);
            textBoxFlawsHourC.Name = "textBoxFlawsHourC";
            textBoxFlawsHourC.ReadOnly = true;
            textBoxFlawsHourC.Size = new Size(100, 23);
            textBoxFlawsHourC.TabIndex = 10;
            // 
            // textBoxTotalC
            // 
            textBoxTotalC.Location = new Point(336, 43);
            textBoxTotalC.Name = "textBoxTotalC";
            textBoxTotalC.ReadOnly = true;
            textBoxTotalC.Size = new Size(100, 23);
            textBoxTotalC.TabIndex = 9;
            textBoxTotalC.Tag = "A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 126);
            label4.Name = "label4";
            label4.Size = new Size(166, 15);
            label4.TabIndex = 8;
            label4.Text = "Taux défaut depuis démarrage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 83);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 7;
            label5.Text = "Taux défaut heure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 43);
            label6.Name = "label6";
            label6.Size = new Size(216, 15);
            label6.TabIndex = 6;
            label6.Text = "Nombre de caisses depuis le démarrage";
            // 
            // labelProd1
            // 
            labelProd1.AutoSize = true;
            labelProd1.Font = new Font("Segoe UI", 12F);
            labelProd1.Location = new Point(33, 312);
            labelProd1.Name = "labelProd1";
            labelProd1.Size = new Size(100, 21);
            labelProd1.TabIndex = 2;
            labelProd1.Text = "Production A";
            // 
            // labelProd2
            // 
            labelProd2.AutoSize = true;
            labelProd2.Font = new Font("Segoe UI", 12F);
            labelProd2.Location = new Point(33, 344);
            labelProd2.Name = "labelProd2";
            labelProd2.Size = new Size(99, 21);
            labelProd2.TabIndex = 3;
            labelProd2.Text = "Production B";
            // 
            // labelProd3
            // 
            labelProd3.AutoSize = true;
            labelProd3.Font = new Font("Segoe UI", 12F);
            labelProd3.Location = new Point(33, 376);
            labelProd3.Name = "labelProd3";
            labelProd3.Size = new Size(100, 21);
            labelProd3.TabIndex = 4;
            labelProd3.Text = "Production C";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(255, 310);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(469, 23);
            progressBar1.TabIndex = 5;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(255, 342);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(469, 23);
            progressBar2.TabIndex = 6;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(255, 374);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(469, 23);
            progressBar3.TabIndex = 7;
            // 
            // FormProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 450);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(labelProd3);
            Controls.Add(labelProd2);
            Controls.Add(labelProd1);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormProd";
            Text = "PRODUCTION DES CAISSES";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageA.ResumeLayout(false);
            tabPageA.PerformLayout();
            tabPageB.ResumeLayout(false);
            tabPageB.PerformLayout();
            tabPageC.ResumeLayout(false);
            tabPageC.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem toolStripMenuItemProd;
        private TabControl tabControl1;
        private TabPage tabPageA;
        private TabPage tabPageB;
        private TabPage tabPageC;
        private Label labelProd1;
        private Label labelProd2;
        private Label labelProd3;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private TextBox textBoxFlawsTotalA;
        private TextBox textBoxFlawsHoursA;
        private TextBox textBoxTotalA;
        private Label labelTotalFlaws;
        private Label labelFlawsHour;
        private Label labelTotal;
        private TextBox textBoxFlawsTotalB;
        private TextBox textBoxFlawsHourB;
        private TextBox textBoxTotalB;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFlawsTotalC;
        private TextBox textBoxFlawsHourC;
        private TextBox textBoxTotalC;
        private Label label4;
        private Label label5;
        private Label label6;
        private ToolStripMenuItem toolStripMenuItemStart;
        private ToolStripMenuItem aToolStripMenuItemStart;
        private ToolStripMenuItem bToolStripMenuItemStart;
        private ToolStripMenuItem cToolStripMenuItemStart;
        private ToolStripMenuItem toolStripMenuItemStop;
        private ToolStripMenuItem aToolStripMenuItemStop;
        private ToolStripMenuItem bToolStripMenuItemStop;
        private ToolStripMenuItem cToolStripMenuItemStop;
        private ToolStripMenuItem toolStripMenuItemResume;
        private ToolStripMenuItem aToolStripMenuItemContinue;
        private ToolStripMenuItem bToolStripMenuItemContinue;
        private ToolStripMenuItem cToolStripMenuItemContinue;
        private ToolStripMenuItem quitterToolStripMenuItem;
    }
}
