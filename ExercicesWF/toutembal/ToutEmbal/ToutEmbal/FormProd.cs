using LibraryCratesProd;

namespace ToutEmbal
{
    public partial class FormProd : Form
    {
        Production prod;

        public FormProd()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = sender as ToolStripMenuItem;
            prod = new Production(btn.Tag.ToString(), 10000);
            if (prod.CurrentState == Production.State.Initialized) 
            {
                prod.Start();
            }
            else if(prod.CurrentState == Production.State.Started)
            {
                prod.Suspend();
            }
            else
            {
                prod.Continue();
            }
            
            btn.Enabled = false;
        }

        private void aToolStripMenuItemStart_EnabledChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = sender as ToolStripMenuItem;
            foreach (ToolStripMenuItem item in toolStripMenuItemStop.DropDownItems)
            {
                if (item.Tag.ToString() == btn.Tag.ToString())
                {
                    item.Enabled = !btn.Enabled;
                }
            }
        }

        private void aToolStripMenuItemStop_EnabledChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = sender as ToolStripMenuItem;
            foreach (ToolStripMenuItem item in toolStripMenuItemResume.DropDownItems)
            {
                if (item.Tag.ToString() == btn.Tag.ToString())
                {
                    item.Enabled = !btn.Enabled;
                }
            }
        }
    }
}
