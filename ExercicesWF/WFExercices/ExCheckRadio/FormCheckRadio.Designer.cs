namespace ExCheckRadio
{
    partial class FormCheckRadio
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
            this.labelTxtInput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxCheck = new System.Windows.Forms.GroupBox();
            this.checkBoxBack = new System.Windows.Forms.CheckBox();
            this.checkBoxChar = new System.Windows.Forms.CheckBox();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.groupBoxRadioBack = new System.Windows.Forms.GroupBox();
            this.groupBoxRadioChar = new System.Windows.Forms.GroupBox();
            this.groupBoxRadioCase = new System.Windows.Forms.GroupBox();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.groupBoxCheck.SuspendLayout();
            this.groupBoxRadioBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTxtInput
            // 
            this.labelTxtInput.AutoSize = true;
            this.labelTxtInput.Location = new System.Drawing.Point(13, 13);
            this.labelTxtInput.Name = "labelTxtInput";
            this.labelTxtInput.Size = new System.Drawing.Size(90, 13);
            this.labelTxtInput.TabIndex = 0;
            this.labelTxtInput.Text = "Tapez votre texte";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBoxCheck
            // 
            this.groupBoxCheck.Controls.Add(this.checkBoxCase);
            this.groupBoxCheck.Controls.Add(this.checkBoxChar);
            this.groupBoxCheck.Controls.Add(this.checkBoxBack);
            this.groupBoxCheck.Location = new System.Drawing.Point(550, 40);
            this.groupBoxCheck.Name = "groupBoxCheck";
            this.groupBoxCheck.Size = new System.Drawing.Size(162, 151);
            this.groupBoxCheck.TabIndex = 2;
            this.groupBoxCheck.TabStop = false;
            this.groupBoxCheck.Text = "Choix";
            // 
            // checkBoxBack
            // 
            this.checkBoxBack.AutoSize = true;
            this.checkBoxBack.Location = new System.Drawing.Point(7, 20);
            this.checkBoxBack.Name = "checkBoxBack";
            this.checkBoxBack.Size = new System.Drawing.Size(101, 17);
            this.checkBoxBack.TabIndex = 0;
            this.checkBoxBack.Text = "Couleur du fond";
            this.checkBoxBack.UseVisualStyleBackColor = true;
            // 
            // checkBoxChar
            // 
            this.checkBoxChar.AutoSize = true;
            this.checkBoxChar.Location = new System.Drawing.Point(7, 67);
            this.checkBoxChar.Name = "checkBoxChar";
            this.checkBoxChar.Size = new System.Drawing.Size(135, 17);
            this.checkBoxChar.TabIndex = 1;
            this.checkBoxChar.Text = "Couleur des caractères";
            this.checkBoxChar.UseVisualStyleBackColor = true;
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Location = new System.Drawing.Point(7, 113);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCase.TabIndex = 2;
            this.checkBoxCase.Text = "Casse";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // groupBoxRadioBack
            // 
            this.groupBoxRadioBack.Controls.Add(this.radioButtonBlue);
            this.groupBoxRadioBack.Controls.Add(this.radioButtonGreen);
            this.groupBoxRadioBack.Controls.Add(this.radioButtonRed);
            this.groupBoxRadioBack.Location = new System.Drawing.Point(45, 265);
            this.groupBoxRadioBack.Name = "groupBoxRadioBack";
            this.groupBoxRadioBack.Size = new System.Drawing.Size(189, 158);
            this.groupBoxRadioBack.TabIndex = 3;
            this.groupBoxRadioBack.TabStop = false;
            this.groupBoxRadioBack.Text = "Fond";
            this.groupBoxRadioBack.Visible = false;
            // 
            // groupBoxRadioChar
            // 
            this.groupBoxRadioChar.Location = new System.Drawing.Point(264, 270);
            this.groupBoxRadioChar.Name = "groupBoxRadioChar";
            this.groupBoxRadioChar.Size = new System.Drawing.Size(203, 152);
            this.groupBoxRadioChar.TabIndex = 4;
            this.groupBoxRadioChar.TabStop = false;
            this.groupBoxRadioChar.Text = "Caractères";
            this.groupBoxRadioChar.Visible = false;
            // 
            // groupBoxRadioCase
            // 
            this.groupBoxRadioCase.Location = new System.Drawing.Point(499, 320);
            this.groupBoxRadioCase.Name = "groupBoxRadioCase";
            this.groupBoxRadioCase.Size = new System.Drawing.Size(109, 101);
            this.groupBoxRadioCase.TabIndex = 5;
            this.groupBoxRadioCase.TabStop = false;
            this.groupBoxRadioCase.Text = "Casse";
            this.groupBoxRadioCase.Visible = false;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 37);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Rouge";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(7, 70);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(44, 17);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Vert";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(7, 105);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Bleu";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // FormCheckRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.groupBoxRadioCase);
            this.Controls.Add(this.groupBoxRadioChar);
            this.Controls.Add(this.groupBoxRadioBack);
            this.Controls.Add(this.groupBoxCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTxtInput);
            this.Name = "FormCheckRadio";
            this.Text = "CheckBox et RadioButton";
            this.groupBoxCheck.ResumeLayout(false);
            this.groupBoxCheck.PerformLayout();
            this.groupBoxRadioBack.ResumeLayout(false);
            this.groupBoxRadioBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTxtInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxCheck;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.CheckBox checkBoxChar;
        private System.Windows.Forms.CheckBox checkBoxBack;
        private System.Windows.Forms.GroupBox groupBoxRadioBack;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.GroupBox groupBoxRadioChar;
        private System.Windows.Forms.GroupBox groupBoxRadioCase;
    }
}

