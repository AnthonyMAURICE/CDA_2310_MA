using LibraryCratesProd;
using System.Collections.ObjectModel;

namespace ToutEmbal
{
    public partial class FormProd : Form
    {
        readonly ProdLine prodLines = new();
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
                        prodLines.Prods["prod" + identifier].ItemAddedInList += ProgressEvent;
                    }
                    if (prodLines.Prods["prod" + identifier].CurrentState == Production.State.Initialized)
                    {
                        prodLines.Prods["prod" + btn.Tag.ToString()].StartProd();

                        //pour avec le timer sur l'IHM
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

        // Méthode avec Timer géré par la classe ou avec les threads
        private void ProgressEvent(object sender, EventArgs e)
        {
            Production item = (Production)sender;

            foreach(ProgressBar elem in this.Controls.OfType<ProgressBar>())
            {
                if (item.Type == elem.Tag.ToString())
                {
                    elem.Invoke(new MethodInvoker(delegate
                    {
                        elem.Value = item.GetProgress();
                    }));
                }
            }

            foreach(TabPage page in this.tabControl1.TabPages)
            {
                foreach(TextBox box in page.Controls.OfType<TextBox>())
                {
                    if (item.Type == box.Tag.ToString())
                    {
                        box.Invoke(new MethodInvoker(delegate
                        {
                            box.Text = item.GetValidCratesNumber().ToString();
                        }));
                    }
                }     
            }
            if (item.CurrentState == Production.State.Stopped)
            {
                ButtonEnabledOrNot();
                prodLines.Prods["prod" + item.Type].ItemAddedInList -= ProgressEvent;
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