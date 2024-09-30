using UCProd;

namespace ToutEmbal2
{
    public partial class FormProd2 : Form
    {
        public FormProd2()
        {
            InitializeComponent();
            InitializeDynamicElements();
        }

        private void InitializeDynamicElements()
        {
            int yAxis = 0;
            for (int i = 0; i < 3; i++)
            {
                UserControlProgress progress = new UserControlProgress(i, yAxis);
                UserControlTab tab = new UserControlTab();
                panelProgress.Controls.Add(progress);
                panelTab.Controls.Add(tab.TabControl);
                yAxis += 40;
            }
        }

        

        private void AddMenuItems()
        {
            foreach (ToolStripMenuItem item in productionToolStripMenuItem.DropDownItems)
            {
                
            }
        }

        private void FormProd2_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
