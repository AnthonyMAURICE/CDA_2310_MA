using LibraryCratesProd;

namespace ToutEmbal
{
    public partial class FormProd : Form
    {
        Production prod;
        List<Production> productions = new List<Production>();
        System.Windows.Forms.Timer timer;

        public FormProd()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            
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
            productions.Add(prod);
            if (prod.CurrentState == Production.State.Initialized) 
            {
                prod.Start();
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
            else if(prod.CurrentState == Production.State.Started)
            {
                prod.Suspend();
                timer.Stop();
            }
            else
            {
                prod.Continue();
                timer.Start();
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

        private void timer_Tick(object sender, EventArgs e)
        {
            if (prod != null)
            {
               
            }
        }
    }
}
