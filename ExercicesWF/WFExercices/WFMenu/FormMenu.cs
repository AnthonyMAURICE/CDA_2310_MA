namespace WFMenu
{
    public partial class FormMenu : Form
    {
        private bool isLogged = false;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemID_Click(object sender, EventArgs e)
        {
            if (!isLogged)
            {
                MessageBox.Show
                ("Bienvenue !", "Hello World",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                MenuItemP1.Visible = true;
                MenuItemP2.Visible = true;
                MenuItemP3.Visible = true;
                MenuItemW1.Visible = true;
                isLogged = true;
            }
        }
    }
}
