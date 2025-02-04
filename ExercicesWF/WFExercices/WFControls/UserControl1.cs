using System.ComponentModel;

namespace WFControls
{
    public partial class UserControl1 : UserControl
    {
        string errorText;
        public UserControl1()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [DefaultValue("Identifiant ou Mot de passe incorrect.")]
        public string ErrorText { get; set; }

        private void InitializeComponent()
        {
            labelID = new Label();
            labelPass = new Label();
            textBoxLogin = new TextBox();
            textBoxPass = new TextBox();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(70, 33);
            labelID.Name = "labelID";
            labelID.Size = new Size(61, 15);
            labelID.TabIndex = 0;
            labelID.Text = "Identifiant";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(72, 86);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(77, 15);
            labelPass.TabIndex = 1;
            labelPass.Text = "Mot de passe";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(159, 30);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(100, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(159, 83);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(100, 23);
            textBoxPass.TabIndex = 3;
            // 
            // UserControl1
            // 
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLogin);
            Controls.Add(labelPass);
            Controls.Add(labelID);
            Name = "UserControl1";
            Size = new Size(366, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelID;
        private Label labelPass;
        private TextBox textBoxLogin;
        private TextBox textBoxPass;
    }
}
