namespace FormComboBox
{
    partial class FormCombo
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
            this.listBoxTarget = new System.Windows.Forms.ListBox();
            this.buttonAddOne = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonRemoveOne = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOrigin
            // 
            this.comboBoxOrigin.FormattingEnabled = true;
            this.comboBoxOrigin.Location = new System.Drawing.Point(76, 39);
            this.comboBoxOrigin.Name = "comboBoxOrigin";
            this.comboBoxOrigin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrigin.TabIndex = 0;
            this.comboBoxOrigin.TextChanged += new System.EventHandler(this.comboBoxOrigin_TextChanged);
            this.comboBoxOrigin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxOrigin_KeyPress);
            // 
            // listBoxTarget
            // 
            this.listBoxTarget.FormattingEnabled = true;
            this.listBoxTarget.Location = new System.Drawing.Point(316, 39);
            this.listBoxTarget.Name = "listBoxTarget";
            this.listBoxTarget.Size = new System.Drawing.Size(120, 251);
            this.listBoxTarget.TabIndex = 1;
            this.listBoxTarget.SelectedIndexChanged += new System.EventHandler(this.listBoxTarget_SelectedIndexChanged);
            // 
            // buttonAddOne
            // 
            this.buttonAddOne.Location = new System.Drawing.Point(235, 39);
            this.buttonAddOne.Name = "buttonAddOne";
            this.buttonAddOne.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOne.TabIndex = 2;
            this.buttonAddOne.Tag = "addOne";
            this.buttonAddOne.Text = ">";
            this.buttonAddOne.UseVisualStyleBackColor = true;
            this.buttonAddOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(235, 79);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAll.TabIndex = 3;
            this.buttonAddAll.Tag = "addMany";
            this.buttonAddAll.Text = ">>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonMany_Click);
            // 
            // buttonRemoveOne
            // 
            this.buttonRemoveOne.Location = new System.Drawing.Point(235, 229);
            this.buttonRemoveOne.Name = "buttonRemoveOne";
            this.buttonRemoveOne.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveOne.TabIndex = 4;
            this.buttonRemoveOne.Tag = "removeOne";
            this.buttonRemoveOne.Text = "<";
            this.buttonRemoveOne.UseVisualStyleBackColor = true;
            this.buttonRemoveOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(235, 266);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAll.TabIndex = 5;
            this.buttonRemoveAll.Tag = "removeMany";
            this.buttonRemoveAll.Text = "<<";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonMany_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Enabled = false;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(342, 308);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(25, 43);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.MoveUpClick);
            // 
            // buttonDown
            // 
            this.buttonDown.Enabled = false;
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(384, 308);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(24, 43);
            this.buttonDown.TabIndex = 7;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.MoveDownClick);
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(111, 19);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(41, 13);
            this.labelOrigin.TabIndex = 8;
            this.labelOrigin.Text = "Source";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(342, 19);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(30, 13);
            this.labelTarget.TabIndex = 9;
            this.labelTarget.Text = "Cible";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 400);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemoveOne);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.buttonAddOne);
            this.Controls.Add(this.listBoxTarget);
            this.Controls.Add(this.comboBoxOrigin);
            this.Name = "FormCombo";
            this.Text = "Les listes";
            this.Load += new System.EventHandler(this.FormCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOrigin;
        private System.Windows.Forms.ListBox listBoxTarget;
        private System.Windows.Forms.Button buttonAddOne;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonRemoveOne;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

