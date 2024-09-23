namespace WinFormsMenu
{
    public partial class FrmMenu : Form
    {
        private bool loggedIn = false;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemLogIn_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                loggedIn = true;
            }
            MessageBox.Show
            ("Bienvenue ! ", "Hello World",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
            toolStripMenuItemP1.Visible = loggedIn;
            toolStripMenuItemP2.Visible = loggedIn;
            toolStripMenuItemP3.Visible = loggedIn;
            toolStripMenuItemWindow.Visible = loggedIn;
        }
    }
}
