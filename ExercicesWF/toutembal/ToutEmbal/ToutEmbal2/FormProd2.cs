using LibraryCratesProd;
using System.ComponentModel;
using UCProd;

namespace ToutEmbal2
{
    public partial class FormProd2 : Form
    {
        public readonly ProdLine prodLines = new();
        private readonly int elemCount = 3;

        UserControlProgress progress;
        UserControlTab tab;
        UserControlMenu menu;
        public FormProd2()
        {
            InitializeComponent();
            InitializeDynamicElements();
        }

        private void InitializeDynamicElements()
        {
            int yAxis = 0;
            for (int i = 0; i < elemCount; i++)
            {
                menu = new(elemCount, prodLines);
                progress = new UserControlProgress(elemCount, yAxis, prodLines);
                progress.ProgressBarUpdate += ProgressEvent;
                tab = new UserControlTab(elemCount, prodLines);
                panelProgress.Controls.Add(progress);
                panelTab.Controls.Add(tab.TabControl);
                yAxis += 40;
                this.Controls.Add(menu);

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
            progress.ProgressBarUpdate -= ProgressEvent;
        }

        public void ProgressEvent(object sender, EventArgs e)
        {
            this.IfStopped();
        }


        private void IfStopped()
        {
            foreach (Production prod in prodLines.Prods.Values)
            {
                if (prod.CurrentState == Production.State.Stopped)
                {
                    progress.ProgressBarUpdate -= ProgressEvent;
                    prodLines.Prods.Remove("prod" + prod.Type);
                    MessageBox.Show
                    ("Production atteinte sur la ligne " + prod.Type, "Job Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
