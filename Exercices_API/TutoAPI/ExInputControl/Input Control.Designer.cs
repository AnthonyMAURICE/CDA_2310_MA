namespace ExInputControl
{
    partial class FormInputControl
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.labelDateFormat = new System.Windows.Forms.Label();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nom";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 92);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 133);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(46, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Montant";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Location = new System.Drawing.Point(12, 171);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(64, 13);
            this.labelZipCode.TabIndex = 3;
            this.labelZipCode.Text = "Code Postal";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(98, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(98, 89);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 5;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(98, 130);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 6;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(98, 168);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxZipCode.TabIndex = 7;
            // 
            // labelDateFormat
            // 
            this.labelDateFormat.AutoSize = true;
            this.labelDateFormat.Location = new System.Drawing.Point(216, 92);
            this.labelDateFormat.Name = "labelDateFormat";
            this.labelDateFormat.Size = new System.Drawing.Size(79, 13);
            this.labelDateFormat.TabIndex = 8;
            this.labelDateFormat.Text = "(JJ/MM/AAAA)";
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(220, 248);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 23);
            this.buttonErase.TabIndex = 9;
            this.buttonErase.Tag = "erase";
            this.buttonErase.Text = "Effacer";
            this.buttonErase.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(220, 219);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 10;
            this.buttonValidate.Tag = "validate";
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 300);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.labelDateFormat);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormInputControl";
            this.Text = "Les contrôles";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label labelDateFormat;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

