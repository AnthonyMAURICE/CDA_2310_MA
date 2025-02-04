using ExAdditionneur;
using ExLoan;
using System.Windows.Forms;

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
            toolStripSplitButtonP3.Visible = loggedIn;
            toolStripSeparator2.Visible = loggedIn;
            toolStripMenuItemWindow.Visible = loggedIn;
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
            ("Quitter l’application ?", "Quitter",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void toolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            FormAdditionneur additionneur = new FormAdditionneur();
            additionneur.ShowDialog();
        }

        private void toolStripMenuItemLoan_Click(object sender, EventArgs e)
        {
            Form1 loan = new Form1();
            loan.Show();
        }
    }
}
