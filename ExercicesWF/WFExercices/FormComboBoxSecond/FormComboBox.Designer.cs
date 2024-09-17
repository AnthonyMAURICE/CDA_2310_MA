namespace FormComboBoxSecond
{
    partial class FormComboBox
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
            labelSource = new Label();
            comboBoxOrigin = new ComboBox();
            listBoxTarget = new ListBox();
            labelTarget = new Label();
            buttonAddOne = new Button();
            buttonAddAll = new Button();
            buttonRemoveOne = new Button();
            buttonRemoveAll = new Button();
            buttonUp = new Button();
            buttonDown = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelSource
            // 
            labelSource.AutoSize = true;
            labelSource.Location = new Point(53, 27);
            labelSource.Name = "labelSource";
            labelSource.Size = new Size(43, 15);
            labelSource.TabIndex = 0;
            labelSource.Text = "Source";
            // 
            // comboBoxOrigin
            // 
            comboBoxOrigin.FormattingEnabled = true;
            comboBoxOrigin.Location = new Point(28, 57);
            comboBoxOrigin.Name = "comboBoxOrigin";
            comboBoxOrigin.Size = new Size(121, 23);
            comboBoxOrigin.TabIndex = 1;
            comboBoxOrigin.SelectedIndexChanged += comboBoxOrigin_SelectedIndexChanged;
            comboBoxOrigin.TextChanged += comboBoxOrigin_TextChanged;
            comboBoxOrigin.KeyPress += comboBoxOrigin_KeyPress;
            // 
            // listBoxTarget
            // 
            listBoxTarget.FormattingEnabled = true;
            listBoxTarget.ItemHeight = 15;
            listBoxTarget.Location = new Point(326, 57);
            listBoxTarget.Name = "listBoxTarget";
            listBoxTarget.Size = new Size(120, 199);
            listBoxTarget.TabIndex = 2;
            listBoxTarget.SelectedIndexChanged += listBoxTarget_SelectedIndexChanged;
            // 
            // labelTarget
            // 
            labelTarget.AutoSize = true;
            labelTarget.Location = new Point(341, 30);
            labelTarget.Name = "labelTarget";
            labelTarget.Size = new Size(34, 15);
            labelTarget.TabIndex = 3;
            labelTarget.Text = "Cible";
            // 
            // buttonAddOne
            // 
            buttonAddOne.Enabled = false;
            buttonAddOne.Location = new Point(206, 57);
            buttonAddOne.Name = "buttonAddOne";
            buttonAddOne.Size = new Size(75, 23);
            buttonAddOne.TabIndex = 4;
            buttonAddOne.Tag = "addOne";
            buttonAddOne.Text = ">";
            buttonAddOne.UseVisualStyleBackColor = true;
            buttonAddOne.Click += buttonAddOne_Click;
            // 
            // buttonAddAll
            // 
            buttonAddAll.Location = new Point(206, 98);
            buttonAddAll.Name = "buttonAddAll";
            buttonAddAll.Size = new Size(75, 23);
            buttonAddAll.TabIndex = 5;
            buttonAddAll.Tag = "addMany";
            buttonAddAll.Text = ">>";
            buttonAddAll.UseVisualStyleBackColor = true;
            buttonAddAll.Click += buttonAddAll_Click;
            // 
            // buttonRemoveOne
            // 
            buttonRemoveOne.Enabled = false;
            buttonRemoveOne.Location = new Point(206, 189);
            buttonRemoveOne.Name = "buttonRemoveOne";
            buttonRemoveOne.Size = new Size(75, 23);
            buttonRemoveOne.TabIndex = 6;
            buttonRemoveOne.Tag = "removeOne";
            buttonRemoveOne.Text = "<";
            buttonRemoveOne.UseVisualStyleBackColor = true;
            buttonRemoveOne.Click += buttonRemoveOne_Click;
            // 
            // buttonRemoveAll
            // 
            buttonRemoveAll.Enabled = false;
            buttonRemoveAll.Location = new Point(206, 231);
            buttonRemoveAll.Name = "buttonRemoveAll";
            buttonRemoveAll.Size = new Size(75, 23);
            buttonRemoveAll.TabIndex = 7;
            buttonRemoveAll.Tag = "removeMany";
            buttonRemoveAll.Text = "<<";
            buttonRemoveAll.UseVisualStyleBackColor = true;
            buttonRemoveAll.Click += buttonRemoveAll_Click;
            // 
            // buttonUp
            // 
            buttonUp.Enabled = false;
            buttonUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUp.Location = new Point(341, 265);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(24, 55);
            buttonUp.TabIndex = 8;
            buttonUp.Text = "↑";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonDown
            // 
            buttonDown.Enabled = false;
            buttonDown.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDown.Location = new Point(406, 265);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(24, 55);
            buttonDown.TabIndex = 9;
            buttonDown.Text = "↓";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 401);
            Controls.Add(buttonDown);
            Controls.Add(buttonUp);
            Controls.Add(buttonRemoveAll);
            Controls.Add(buttonRemoveOne);
            Controls.Add(buttonAddAll);
            Controls.Add(buttonAddOne);
            Controls.Add(labelTarget);
            Controls.Add(listBoxTarget);
            Controls.Add(comboBoxOrigin);
            Controls.Add(labelSource);
            Name = "FormComboBox";
            Text = "Form1";
            Load += FormComboBox_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSource;
        private ComboBox comboBoxOrigin;
        private ListBox listBoxTarget;
        private Label labelTarget;
        private Button buttonAddOne;
        private Button buttonAddAll;
        private Button buttonRemoveOne;
        private Button buttonRemoveAll;
        private Button buttonUp;
        private Button buttonDown;
        private ErrorProvider errorProvider1;
    }
}
