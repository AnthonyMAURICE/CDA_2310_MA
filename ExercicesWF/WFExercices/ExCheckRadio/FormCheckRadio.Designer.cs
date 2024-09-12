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
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.checkBoxChar = new System.Windows.Forms.CheckBox();
            this.checkBoxBack = new System.Windows.Forms.CheckBox();
            this.groupBoxRadioBack = new System.Windows.Forms.GroupBox();
            this.radioButtonBackBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonBackGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBackRed = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioChar = new System.Windows.Forms.GroupBox();
            this.radioButtonCharaBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonCharaWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonCharaRed = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioCase = new System.Windows.Forms.GroupBox();
            this.radioButtonUpperCase = new System.Windows.Forms.RadioButton();
            this.radioButtonLowerCase = new System.Windows.Forms.RadioButton();
            this.labelText = new System.Windows.Forms.Label();
            this.groupBoxCheck.SuspendLayout();
            this.groupBoxRadioBack.SuspendLayout();
            this.groupBoxRadioChar.SuspendLayout();
            this.groupBoxRadioCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTxtInput
            // 
            this.labelTxtInput.AutoSize = true;
            this.labelTxtInput.Location = new System.Drawing.Point(42, 25);
            this.labelTxtInput.Name = "labelTxtInput";
            this.labelTxtInput.Size = new System.Drawing.Size(90, 13);
            this.labelTxtInput.TabIndex = 0;
            this.labelTxtInput.Text = "Tapez votre texte";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxCheck
            // 
            this.groupBoxCheck.Controls.Add(this.checkBoxCase);
            this.groupBoxCheck.Controls.Add(this.checkBoxChar);
            this.groupBoxCheck.Controls.Add(this.checkBoxBack);
            this.groupBoxCheck.Enabled = false;
            this.groupBoxCheck.Location = new System.Drawing.Point(486, 25);
            this.groupBoxCheck.Name = "groupBoxCheck";
            this.groupBoxCheck.Size = new System.Drawing.Size(162, 151);
            this.groupBoxCheck.TabIndex = 2;
            this.groupBoxCheck.TabStop = false;
            this.groupBoxCheck.Text = "Choix";
            this.groupBoxCheck.EnabledChanged += new System.EventHandler(this.groupBoxCheck_EnabledChanged);
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
            this.checkBoxCase.CheckedChanged += new System.EventHandler(this.checkBoxCase_CheckedChanged);
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
            this.checkBoxChar.CheckedChanged += new System.EventHandler(this.checkBoxChar_CheckedChanged);
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
            this.checkBoxBack.CheckedChanged += new System.EventHandler(this.checkBoxBack_CheckedChanged);
            // 
            // groupBoxRadioBack
            // 
            this.groupBoxRadioBack.Controls.Add(this.radioButtonBackBlue);
            this.groupBoxRadioBack.Controls.Add(this.radioButtonBackGreen);
            this.groupBoxRadioBack.Controls.Add(this.radioButtonBackRed);
            this.groupBoxRadioBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRadioBack.Location = new System.Drawing.Point(45, 171);
            this.groupBoxRadioBack.Name = "groupBoxRadioBack";
            this.groupBoxRadioBack.Size = new System.Drawing.Size(189, 135);
            this.groupBoxRadioBack.TabIndex = 3;
            this.groupBoxRadioBack.TabStop = false;
            this.groupBoxRadioBack.Text = "Fond";
            this.groupBoxRadioBack.Visible = false;
            // 
            // radioButtonBackBlue
            // 
            this.radioButtonBackBlue.AutoSize = true;
            this.radioButtonBackBlue.Location = new System.Drawing.Point(7, 105);
            this.radioButtonBackBlue.Name = "radioButtonBackBlue";
            this.radioButtonBackBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBackBlue.TabIndex = 2;
            this.radioButtonBackBlue.TabStop = true;
            this.radioButtonBackBlue.Tag = "Blue";
            this.radioButtonBackBlue.Text = "Bleu";
            this.radioButtonBackBlue.UseVisualStyleBackColor = true;
            this.radioButtonBackBlue.CheckedChanged += new System.EventHandler(this.radioButtonBack_CheckedChanged);
            // 
            // radioButtonBackGreen
            // 
            this.radioButtonBackGreen.AutoSize = true;
            this.radioButtonBackGreen.Location = new System.Drawing.Point(7, 70);
            this.radioButtonBackGreen.Name = "radioButtonBackGreen";
            this.radioButtonBackGreen.Size = new System.Drawing.Size(44, 17);
            this.radioButtonBackGreen.TabIndex = 1;
            this.radioButtonBackGreen.TabStop = true;
            this.radioButtonBackGreen.Tag = "Green";
            this.radioButtonBackGreen.Text = "Vert";
            this.radioButtonBackGreen.UseVisualStyleBackColor = true;
            this.radioButtonBackGreen.CheckedChanged += new System.EventHandler(this.radioButtonBack_CheckedChanged);
            // 
            // radioButtonBackRed
            // 
            this.radioButtonBackRed.AutoSize = true;
            this.radioButtonBackRed.Location = new System.Drawing.Point(7, 37);
            this.radioButtonBackRed.Name = "radioButtonBackRed";
            this.radioButtonBackRed.Size = new System.Drawing.Size(57, 17);
            this.radioButtonBackRed.TabIndex = 0;
            this.radioButtonBackRed.TabStop = true;
            this.radioButtonBackRed.Tag = "Red";
            this.radioButtonBackRed.Text = "Rouge";
            this.radioButtonBackRed.UseVisualStyleBackColor = true;
            this.radioButtonBackRed.CheckedChanged += new System.EventHandler(this.radioButtonBack_CheckedChanged);
            // 
            // groupBoxRadioChar
            // 
            this.groupBoxRadioChar.Controls.Add(this.radioButtonCharaBlack);
            this.groupBoxRadioChar.Controls.Add(this.radioButtonCharaWhite);
            this.groupBoxRadioChar.Controls.Add(this.radioButtonCharaRed);
            this.groupBoxRadioChar.Location = new System.Drawing.Point(260, 171);
            this.groupBoxRadioChar.Name = "groupBoxRadioChar";
            this.groupBoxRadioChar.Size = new System.Drawing.Size(203, 135);
            this.groupBoxRadioChar.TabIndex = 4;
            this.groupBoxRadioChar.TabStop = false;
            this.groupBoxRadioChar.Text = "Caractères";
            this.groupBoxRadioChar.Visible = false;
            // 
            // radioButtonCharaBlack
            // 
            this.radioButtonCharaBlack.AutoSize = true;
            this.radioButtonCharaBlack.Location = new System.Drawing.Point(7, 100);
            this.radioButtonCharaBlack.Name = "radioButtonCharaBlack";
            this.radioButtonCharaBlack.Size = new System.Drawing.Size(44, 17);
            this.radioButtonCharaBlack.TabIndex = 2;
            this.radioButtonCharaBlack.Tag = "Black";
            this.radioButtonCharaBlack.Text = "Noir";
            this.radioButtonCharaBlack.UseVisualStyleBackColor = true;
            this.radioButtonCharaBlack.CheckedChanged += new System.EventHandler(this.radioButtonChara_CheckedChanged);
            // 
            // radioButtonCharaWhite
            // 
            this.radioButtonCharaWhite.AutoSize = true;
            this.radioButtonCharaWhite.Location = new System.Drawing.Point(7, 65);
            this.radioButtonCharaWhite.Name = "radioButtonCharaWhite";
            this.radioButtonCharaWhite.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCharaWhite.TabIndex = 1;
            this.radioButtonCharaWhite.Tag = "White";
            this.radioButtonCharaWhite.Text = "Blanc";
            this.radioButtonCharaWhite.UseVisualStyleBackColor = true;
            this.radioButtonCharaWhite.CheckedChanged += new System.EventHandler(this.radioButtonChara_CheckedChanged);
            // 
            // radioButtonCharaRed
            // 
            this.radioButtonCharaRed.AutoSize = true;
            this.radioButtonCharaRed.Location = new System.Drawing.Point(7, 32);
            this.radioButtonCharaRed.Name = "radioButtonCharaRed";
            this.radioButtonCharaRed.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCharaRed.TabIndex = 0;
            this.radioButtonCharaRed.Tag = "Red";
            this.radioButtonCharaRed.Text = "Rouge";
            this.radioButtonCharaRed.UseVisualStyleBackColor = true;
            this.radioButtonCharaRed.CheckedChanged += new System.EventHandler(this.radioButtonChara_CheckedChanged);
            // 
            // groupBoxRadioCase
            // 
            this.groupBoxRadioCase.Controls.Add(this.radioButtonUpperCase);
            this.groupBoxRadioCase.Controls.Add(this.radioButtonLowerCase);
            this.groupBoxRadioCase.Location = new System.Drawing.Point(486, 203);
            this.groupBoxRadioCase.Name = "groupBoxRadioCase";
            this.groupBoxRadioCase.Size = new System.Drawing.Size(109, 103);
            this.groupBoxRadioCase.TabIndex = 5;
            this.groupBoxRadioCase.TabStop = false;
            this.groupBoxRadioCase.Text = "Casse";
            this.groupBoxRadioCase.Visible = false;
            // 
            // radioButtonUpperCase
            // 
            this.radioButtonUpperCase.AutoSize = true;
            this.radioButtonUpperCase.Location = new System.Drawing.Point(6, 68);
            this.radioButtonUpperCase.Name = "radioButtonUpperCase";
            this.radioButtonUpperCase.Size = new System.Drawing.Size(78, 17);
            this.radioButtonUpperCase.TabIndex = 1;
            this.radioButtonUpperCase.TabStop = true;
            this.radioButtonUpperCase.Text = "Majuscules";
            this.radioButtonUpperCase.UseVisualStyleBackColor = true;
            this.radioButtonUpperCase.CheckedChanged += new System.EventHandler(this.radioButtonCase_CheckedChanged);
            // 
            // radioButtonLowerCase
            // 
            this.radioButtonLowerCase.AutoSize = true;
            this.radioButtonLowerCase.Location = new System.Drawing.Point(7, 33);
            this.radioButtonLowerCase.Name = "radioButtonLowerCase";
            this.radioButtonLowerCase.Size = new System.Drawing.Size(78, 17);
            this.radioButtonLowerCase.TabIndex = 0;
            this.radioButtonLowerCase.Text = "Minuscules";
            this.radioButtonLowerCase.UseVisualStyleBackColor = true;
            this.radioButtonLowerCase.CheckedChanged += new System.EventHandler(this.radioButtonCase_CheckedChanged);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Location = new System.Drawing.Point(45, 92);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(0, 13);
            this.labelText.TabIndex = 6;
            this.labelText.TextChanged += new System.EventHandler(this.labelText_TextChanged);
            // 
            // FormCheckRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 331);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.groupBoxRadioCase);
            this.Controls.Add(this.groupBoxRadioChar);
            this.Controls.Add(this.groupBoxRadioBack);
            this.Controls.Add(this.groupBoxCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTxtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCheckRadio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox et RadioButton";
            this.groupBoxCheck.ResumeLayout(false);
            this.groupBoxCheck.PerformLayout();
            this.groupBoxRadioBack.ResumeLayout(false);
            this.groupBoxRadioBack.PerformLayout();
            this.groupBoxRadioChar.ResumeLayout(false);
            this.groupBoxRadioChar.PerformLayout();
            this.groupBoxRadioCase.ResumeLayout(false);
            this.groupBoxRadioCase.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButtonBackBlue;
        private System.Windows.Forms.RadioButton radioButtonBackGreen;
        private System.Windows.Forms.RadioButton radioButtonBackRed;
        private System.Windows.Forms.GroupBox groupBoxRadioChar;
        private System.Windows.Forms.GroupBox groupBoxRadioCase;
        private System.Windows.Forms.RadioButton radioButtonCharaBlack;
        private System.Windows.Forms.RadioButton radioButtonCharaWhite;
        private System.Windows.Forms.RadioButton radioButtonCharaRed;
        private System.Windows.Forms.RadioButton radioButtonUpperCase;
        private System.Windows.Forms.RadioButton radioButtonLowerCase;
        private System.Windows.Forms.Label labelText;
    }
}

