namespace ExLoan
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            labelName = new Label();
            textBoxName = new TextBox();
            labelCapital = new Label();
            textBoxCapital = new TextBox();
            labelMonths = new Label();
            labelMonthNumber = new Label();
            hScrollBarMonth = new HScrollBar();
            groupBoxRate = new GroupBox();
            radioButtonNine = new RadioButton();
            radioButtonEight = new RadioButton();
            radioButtonSeven = new RadioButton();
            labelTime = new Label();
            listBoxTime = new ListBox();
            labelNbRefund = new Label();
            labelRefunds = new Label();
            labelRefundAmount = new Label();
            buttonOk = new Button();
            buttonCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBoxRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(28, 36);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nom";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(184, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(118, 23);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelCapital
            // 
            labelCapital.AutoSize = true;
            labelCapital.Location = new Point(28, 77);
            labelCapital.Name = "labelCapital";
            labelCapital.Size = new Size(99, 15);
            labelCapital.TabIndex = 2;
            labelCapital.Text = "Capital Emprunté";
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(184, 74);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(118, 23);
            textBoxCapital.TabIndex = 3;
            textBoxCapital.TextChanged += textBoxCapital_TextChanged;
            // 
            // labelMonths
            // 
            labelMonths.AutoSize = true;
            labelMonths.Location = new Point(27, 138);
            labelMonths.Name = "labelMonths";
            labelMonths.Size = new Size(100, 30);
            labelMonths.TabIndex = 4;
            labelMonths.Text = "Durée en mois du\r\nremboursement";
            // 
            // labelMonthNumber
            // 
            labelMonthNumber.AutoSize = true;
            labelMonthNumber.Location = new Point(173, 142);
            labelMonthNumber.Name = "labelMonthNumber";
            labelMonthNumber.Size = new Size(0, 15);
            labelMonthNumber.TabIndex = 5;
            // 
            // hScrollBarMonth
            // 
            hScrollBarMonth.LargeChange = 1;
            hScrollBarMonth.Location = new Point(227, 143);
            hScrollBarMonth.Maximum = 200;
            hScrollBarMonth.Minimum = 1;
            hScrollBarMonth.Name = "hScrollBarMonth";
            hScrollBarMonth.Size = new Size(181, 17);
            hScrollBarMonth.TabIndex = 6;
            hScrollBarMonth.Value = 1;
            hScrollBarMonth.Scroll += hScrollBarMonth_Scroll;
            hScrollBarMonth.ValueChanged += hScrollBarMonth_ValueChanged;
            // 
            // groupBoxRate
            // 
            groupBoxRate.Controls.Add(radioButtonNine);
            groupBoxRate.Controls.Add(radioButtonEight);
            groupBoxRate.Controls.Add(radioButtonSeven);
            groupBoxRate.Location = new Point(469, 22);
            groupBoxRate.Name = "groupBoxRate";
            groupBoxRate.Size = new Size(102, 146);
            groupBoxRate.TabIndex = 7;
            groupBoxRate.TabStop = false;
            groupBoxRate.Text = "Taux d'intérêt";
            // 
            // radioButtonNine
            // 
            radioButtonNine.AutoSize = true;
            radioButtonNine.Location = new Point(24, 105);
            radioButtonNine.Name = "radioButtonNine";
            radioButtonNine.Size = new Size(41, 19);
            radioButtonNine.TabIndex = 2;
            radioButtonNine.Tag = "9";
            radioButtonNine.Text = "9%";
            radioButtonNine.UseVisualStyleBackColor = true;
            radioButtonNine.CheckedChanged += radioButtonRate_CheckedChanged;
            // 
            // radioButtonEight
            // 
            radioButtonEight.AutoSize = true;
            radioButtonEight.Location = new Point(24, 63);
            radioButtonEight.Name = "radioButtonEight";
            radioButtonEight.Size = new Size(41, 19);
            radioButtonEight.TabIndex = 1;
            radioButtonEight.Tag = "8";
            radioButtonEight.Text = "8%";
            radioButtonEight.UseVisualStyleBackColor = true;
            radioButtonEight.CheckedChanged += radioButtonRate_CheckedChanged;
            // 
            // radioButtonSeven
            // 
            radioButtonSeven.AutoSize = true;
            radioButtonSeven.Checked = true;
            radioButtonSeven.Location = new Point(24, 22);
            radioButtonSeven.Name = "radioButtonSeven";
            radioButtonSeven.Size = new Size(41, 19);
            radioButtonSeven.TabIndex = 0;
            radioButtonSeven.TabStop = true;
            radioButtonSeven.Tag = "7";
            radioButtonSeven.Text = "7%";
            radioButtonSeven.UseVisualStyleBackColor = true;
            radioButtonSeven.CheckedChanged += radioButtonRate_CheckedChanged;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(27, 253);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(167, 15);
            labelTime.TabIndex = 8;
            labelTime.Text = "Périodicité de remboursement";
            // 
            // listBoxTime
            // 
            listBoxTime.FormattingEnabled = true;
            listBoxTime.ItemHeight = 15;
            listBoxTime.Items.AddRange(new object[] { "Mensuelle\t", "Bimestrielle", "Trimestrielle", "Semestrielle", "Annuelle" });
            listBoxTime.Location = new Point(30, 274);
            listBoxTime.Name = "listBoxTime";
            listBoxTime.Size = new Size(313, 79);
            listBoxTime.TabIndex = 9;
            listBoxTime.SelectedIndexChanged += listBoxTime_SelectedIndexChanged;
            // 
            // labelNbRefund
            // 
            labelNbRefund.AutoSize = true;
            labelNbRefund.ForeColor = Color.Red;
            labelNbRefund.Location = new Point(546, 259);
            labelNbRefund.Name = "labelNbRefund";
            labelNbRefund.Size = new Size(0, 15);
            labelNbRefund.TabIndex = 10;
            // 
            // labelRefunds
            // 
            labelRefunds.AutoSize = true;
            labelRefunds.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelRefunds.Location = new Point(571, 253);
            labelRefunds.Name = "labelRefunds";
            labelRefunds.Size = new Size(143, 21);
            labelRefunds.TabIndex = 11;
            labelRefunds.Text = "Remboursements";
            // 
            // labelRefundAmount
            // 
            labelRefundAmount.AutoSize = true;
            labelRefundAmount.ForeColor = Color.Red;
            labelRefundAmount.Location = new Point(608, 303);
            labelRefundAmount.Name = "labelRefundAmount";
            labelRefundAmount.Size = new Size(0, 15);
            labelRefundAmount.TabIndex = 12;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(663, 31);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 13;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(663, 73);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 382);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(labelRefundAmount);
            Controls.Add(labelRefunds);
            Controls.Add(labelNbRefund);
            Controls.Add(listBoxTime);
            Controls.Add(labelTime);
            Controls.Add(groupBoxRate);
            Controls.Add(hScrollBarMonth);
            Controls.Add(labelMonthNumber);
            Controls.Add(labelMonths);
            Controls.Add(textBoxCapital);
            Controls.Add(labelCapital);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxRate.ResumeLayout(false);
            groupBoxRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelCapital;
        private TextBox textBoxCapital;
        private Label labelMonths;
        private Label labelMonthNumber;
        private HScrollBar hScrollBarMonth;
        private GroupBox groupBoxRate;
        private RadioButton radioButtonNine;
        private RadioButton radioButtonEight;
        private RadioButton radioButtonSeven;
        private Label labelTime;
        private ListBox listBoxTime;
        private Label labelNbRefund;
        private Label labelRefunds;
        private Label labelRefundAmount;
        private Button buttonOk;
        private Button buttonCancel;
        private ErrorProvider errorProvider1;
    }
}
