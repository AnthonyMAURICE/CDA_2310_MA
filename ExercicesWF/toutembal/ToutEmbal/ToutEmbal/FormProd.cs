using LibraryCratesProd;
using System.Collections.ObjectModel;

namespace ToutEmbal
{
    public partial class FormProd : Form
    {
        ProdLine prodLines = new ProdLine();
        //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
        //{
        //    Interval = 100
        //};

        public FormProd()
        {
            InitializeComponent();
            //timer.Tick += new System.EventHandler(OnTimerEvent);    
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
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            if (btn.Tag != null)
            {
                string identifier = btn.Tag.ToString();
                if (prodLines.Prods != null)
                {
                    if (!prodLines.Prods.ContainsKey("prod" + identifier))
                    {
                        prodLines.CreateProd(identifier);
                        prodLines.Prods["prod" + identifier].itemAddedInList += ProgressEvent;
                    }
                    if (prodLines.Prods["prod" + identifier].CurrentState == Production.State.Initialized)
                    {
                        prodLines.Prods["prod" + btn.Tag.ToString()].Start();
                        //timer.Start();
                    }
                    else if (prodLines.Prods["prod" + identifier].CurrentState == Production.State.Started)
                    {
                        prodLines.Prods["prod" + identifier].Suspend();
                    }
                    else
                    {
                        prodLines.Prods["prod" + identifier].Continue();
                    }
                    ButtonEnabledOrNot();
                }
            }
            btn.Enabled = false;
        }

        private void ButtonEnabledOrNot()
        {
            foreach (Production prod in prodLines.Prods.Values)
            {
                foreach (ToolStripMenuItem btn in toolStripMenuItemStart.DropDownItems)
                {
                    if (btn.Tag.ToString() == prod.Type)
                    {
                        btn.Enabled = prod.CurrentState == Production.State.Stopped || prod.CurrentState == Production.State.Initialized;
                    }
                }
                foreach (ToolStripMenuItem btn in toolStripMenuItemResume.DropDownItems)
                {
                    if (btn.Tag.ToString() == prod.Type)
                    {
                        btn.Enabled = prod.CurrentState == Production.State.Suspended;
                    }
                }
                foreach (ToolStripMenuItem btn in toolStripMenuItemStop.DropDownItems)
                {
                    if (btn.Tag.ToString() == prod.Type)
                    {
                        btn.Enabled = prod.CurrentState == Production.State.Started;
                    }
                }
            }
        }

        //Méthode avec Timer integré à l'IHM

        //private void OnTimerEvent(object sender, EventArgs e)
        //{
        //    foreach (Production item in prodLines.Prods.Values)
        //    {
        //        //if(item.CurrentState == Production.State.Started)
        //        //item.AddCrate();
        //        if (item.Type == "A")
        //        {
        //            progressBar1.Value = item.GetProgress();
        //            textBoxTotalA.Text = item.Crates.Count.ToString();
        //        }
        //        if (item.Type == "B")
        //        {
        //            progressBar2.Value = item.GetProgress();
        //            textBoxTotalB.Text = item.Crates.Count.ToString();
        //        }
        //        if (item.Type == "C")
        //        {
        //            progressBar3.Value = item.GetProgress();
        //            textBoxTotalC.Text = item.Crates.Count.ToString();
        //        }
        //        if (item.CurrentState == Production.State.Stopped)
        //        {
        //            ButtonEnabledOrNot();
        //            prodLines.Prods.Remove("prod" + item.Type);
        //            MessageBox.Show
        //            ("Production atteinte sur la ligne " + item.Type, "Job Done",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information,
        //            MessageBoxDefaultButton.Button1); 
        //        }
        //    }
        //}

        // Méthode avec Timer géré par la classe
        private void ProgressEvent(object sender, EventArgs e)
        {
            Production item = (Production)sender;
            if (item.Type == "A")
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Value = item.GetProgress();
                }));
                textBoxTotalA.Invoke(new MethodInvoker(delegate
                {
                    textBoxTotalA.Text = item.GetValidCratesNumber().ToString();
                }));
            }
            if (item.Type == "B")
            {
                progressBar2.Invoke(new MethodInvoker(delegate
                {
                    progressBar2.Value = item.GetProgress();
                }));
                textBoxTotalB.Invoke(new MethodInvoker(delegate
                {
                    textBoxTotalB.Text = item.GetValidCratesNumber().ToString();
                }));
            }
            if (item.Type == "C")
            {
                progressBar3.Invoke(new MethodInvoker(delegate
                {
                    progressBar3.Value = item.GetProgress();
                }));
                textBoxTotalC.Invoke(new MethodInvoker(delegate
                {
                    textBoxTotalC.Text = item.GetValidCratesNumber().ToString();
                }));
            }
            if (item.CurrentState == Production.State.Stopped)
            {
                ButtonEnabledOrNot();
                prodLines.Prods["prod" + item.Type].itemAddedInList -= ProgressEvent;
                prodLines.Prods.Remove("prod" + item.Type);
                MessageBox.Show
                ("Production atteinte sur la ligne " + item.Type, "Job Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }
        }



        private void textBoxTotal(object sender, TextBox textBoxHours, TextBox textBoxAll)
        {
            TextBox flawsBox = (TextBox)sender;
            if (prodLines.Prods.ContainsKey("prod" + flawsBox.Tag.ToString()))
            {
                decimal flawsByHour = prodLines.Prods["prod" + flawsBox.Tag.ToString()].GetLastHourFailureRate();
                decimal flaws = prodLines.Prods["prod" + flawsBox.Tag.ToString()].GetTotalFailureRate();
                textBoxHours.Text = flawsByHour.ToString("0.####");
                textBoxAll.Text = flaws.ToString("0.####");
            }
        }

        private void textBoxTotalB_TextChanged(object sender, EventArgs e)
        {
            textBoxTotal(sender, textBoxFlawsHourB, textBoxFlawsTotalB);
        }

        private void textBoxTotalA_TextChanged(object sender, EventArgs e)
        {
            textBoxTotal(sender, textBoxFlawsHoursA, textBoxFlawsTotalA);
        }

        private void textBoxTotalC_TextChanged(object sender, EventArgs e)
        {
            textBoxTotal(sender, textBoxFlawsHourC, textBoxFlawsTotalC);
        }
    }
}