namespace FormList
{
    partial class FormList
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
            this.labelNew = new System.Windows.Forms.Label();
            this.labelIndexElem = new System.Windows.Forms.Label();
            this.textBoxNewElem = new System.Windows.Forms.TextBox();
            this.textBoxIndexElem = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelProperties = new System.Windows.Forms.Label();
            this.labelItemCount = new System.Windows.Forms.Label();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.labelTxt = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxItemCount = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNew.Location = new System.Drawing.Point(13, 13);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(96, 13);
            this.labelNew.TabIndex = 0;
            this.labelNew.Text = "Nouvel Élément";
            // 
            // labelIndexElem
            // 
            this.labelIndexElem.AutoSize = true;
            this.labelIndexElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexElem.Location = new System.Drawing.Point(211, 13);
            this.labelIndexElem.Name = "labelIndexElem";
            this.labelIndexElem.Size = new System.Drawing.Size(87, 13);
            this.labelIndexElem.TabIndex = 1;
            this.labelIndexElem.Text = "Index Élément";
            // 
            // textBoxNewElem
            // 
            this.textBoxNewElem.Location = new System.Drawing.Point(13, 40);
            this.textBoxNewElem.Name = "textBoxNewElem";
            this.textBoxNewElem.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewElem.TabIndex = 2;
            // 
            // textBoxIndexElem
            // 
            this.textBoxIndexElem.Location = new System.Drawing.Point(214, 40);
            this.textBoxIndexElem.Name = "textBoxIndexElem";
            this.textBoxIndexElem.Size = new System.Drawing.Size(46, 20);
            this.textBoxIndexElem.TabIndex = 3;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(296, 38);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(88, 23);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Sélectionner";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(296, 67);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Vider la Liste";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(13, 141);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(51, 13);
            this.labelList.TabIndex = 6;
            this.labelList.Text = "LstListe";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 67);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Ajout Liste";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelProperties
            // 
            this.labelProperties.AutoSize = true;
            this.labelProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProperties.Location = new System.Drawing.Point(214, 141);
            this.labelProperties.Name = "labelProperties";
            this.labelProperties.Size = new System.Drawing.Size(64, 13);
            this.labelProperties.TabIndex = 8;
            this.labelProperties.Text = "Propriétés";
            // 
            // labelItemCount
            // 
            this.labelItemCount.AutoSize = true;
            this.labelItemCount.Location = new System.Drawing.Point(214, 174);
            this.labelItemCount.Name = "labelItemCount";
            this.labelItemCount.Size = new System.Drawing.Size(63, 13);
            this.labelItemCount.TabIndex = 9;
            this.labelItemCount.Text = "Items.Count";
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Location = new System.Drawing.Point(214, 214);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(75, 13);
            this.labelSelectedIndex.TabIndex = 10;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.Location = new System.Drawing.Point(214, 255);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(28, 13);
            this.labelTxt.TabIndex = 11;
            this.labelTxt.Text = "Text";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 121);
            this.listBox1.TabIndex = 12;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // textBoxItemCount
            // 
            this.textBoxItemCount.Location = new System.Drawing.Point(296, 171);
            this.textBoxItemCount.Name = "textBoxItemCount";
            this.textBoxItemCount.ReadOnly = true;
            this.textBoxItemCount.Size = new System.Drawing.Size(44, 20);
            this.textBoxItemCount.TabIndex = 13;
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(296, 211);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.ReadOnly = true;
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(44, 20);
            this.textBoxSelectedIndex.TabIndex = 14;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(296, 252);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ReadOnly = true;
            this.textBoxText.Size = new System.Drawing.Size(88, 20);
            this.textBoxText.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.textBoxItemCount);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.labelItemCount);
            this.Controls.Add(this.labelProperties);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBoxIndexElem);
            this.Controls.Add(this.textBoxNewElem);
            this.Controls.Add(this.labelIndexElem);
            this.Controls.Add(this.labelNew);
            this.Name = "FormList";
            this.Text = "Les listes et leurs propriétés";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.Label labelIndexElem;
        private System.Windows.Forms.TextBox textBoxNewElem;
        private System.Windows.Forms.TextBox textBoxIndexElem;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelProperties;
        private System.Windows.Forms.Label labelItemCount;
        private System.Windows.Forms.Label labelSelectedIndex;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxItemCount;
        private System.Windows.Forms.TextBox textBoxSelectedIndex;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

