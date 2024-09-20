namespace WFMenus
{
    public partial class Form1 : Form
    {
        private bool logged = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemLogIn_Click(object sender, EventArgs e)
        {
            if (!logged)
            {
                MessageBox.Show
                ("Bienvenue", "Hello World",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                toolStripMenuItemP1.Visible = true;
                toolStripMenuItemP2.Visible = true;
                toolStripMenuItemP3.Visible = true;
                toolStripMenuItemWindows.Visible = true;
                logged = true;
            }
        }
    }
}
