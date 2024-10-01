using LibraryCratesProd;
using UCProd;

namespace ToutEmbal2
{
    public partial class FormProd2 : Form
    {
        public readonly static ProdLine prodLines = new();
        private int elemCount = 3;

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
                menu.ProdlinesCreated += AddEvent;
                progress = new UserControlProgress(elemCount, yAxis, prodLines);
                tab = new UserControlTab(elemCount);
                panelProgress.Controls.Add(progress);
                panelTab.Controls.Add(tab.TabControl);
                yAxis += 40;
                

                //progress.ProgressChanged += RefreshEvent;
                this.Controls.Add(menu);
                
            }
        }

        private void AddEvent(object sender, EventArgs e)
        {
            foreach (Production prod in prodLines.Prods.Values)
            {
                prod.ItemAddedInList += ProgressEvent;
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
            foreach (Production prod in prodLines.Prods.Values)
            {
                prod.ItemAddedInList -= ProgressEvent;
            }
        }

        public void ProgressEvent(object sender, EventArgs e)
        {
            Production item = (Production)sender;

            this.progress.UpdateProgressBar(item);

            //foreach (ProgressBar elem in this.progress.Controls.OfType<ProgressBar>())// a mettre sur teams
            //{
            //    if (item.Type == elem.Tag.ToString())
            //    {
            //        elem.Invoke(new MethodInvoker(delegate
            //        {
            //            elem.Value = item.GetProgress();
            //            this.progress.Update();
            //        }));
            //    }
            //}
            //ProgressBar elem = this.Controls.OfType<ProgressBar>().Where(elem => elem.Tag.ToString() == item.Type).First();
            //elem.Invoke(new MethodInvoker(delegate
            //{
            //    elem.Update();
            //}));

            this.tab.UpdateTextBoxes(item);
            
            if (item.CurrentState == Production.State.Stopped)
            {
                menu.ButtonEnabledOrNot();
                prodLines.Prods.Remove("prod" + item.Type);
                item.ItemAddedInList -= ProgressEvent;
                MessageBox.Show
                ("Production atteinte sur la ligne " + item.Type, "Job Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
        }

        //public void RefreshEvent(object sender, EventArgs e)
        //{
        //    ProgressBar elem = (ProgressBar)sender;

        //    elem.Invoke(new MethodInvoker(delegate
        //    {
        //        elem.Refresh();
        //    }));

        //}
    }
}
