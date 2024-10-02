using LibraryCratesProd;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace UCProd
{
    public partial class UserControlProgress : UserControl
    {
        Label label;
        ProgressBar progressBar;
        ProdLine prodLine;
        List<Production> productions = new List<Production>();

        public event EventHandler ProgressBarUpdate;

        public UserControlProgress(int count, int yAxis, ProdLine prodLine)
        {
            InitializeComponent();
            ProgressCreation(count, yAxis);
            this.prodLine = prodLine;
            this.prodLine.ProdAdded += SetListProd;
        }

        public void SetListProd(object sender, EventArgs e) 
        {
            foreach (Production prod in prodLine.Prods.Values)
            {
                prod.ItemAddedInList += Test;
                productions.Add(prod);
            }
        }

        private void ProgressCreation(int count, int yAxis)
        {
            for (int i = 0; i < count; i++)
            {
                progressBar = new ProgressBar();
                label = new Label();
                label.Text = "Production " + Production.alphabet[i];
                label.Location = new Point(10, yAxis);
                progressBar.Name = "progressBar" + i.ToString();
                progressBar.Tag = Production.alphabet[i].ToString();
                progressBar.Size = new Size(300, 20);
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Location = new Point(200, yAxis);
                
                this.Controls.Add(label);
                this.Controls.Add(progressBar);
                yAxis += 40;
            }
        }

        public void Test(object sender, EventArgs e)
        {
            foreach (ProgressBar pb in this.Controls.OfType<ProgressBar>())
            {
                foreach (Production prod in productions) 
                {
                    if(prod.Type == pb.Tag.ToString())
                    {
                        pb.Invoke(new MethodInvoker(delegate
                        {
                            pb.Value = prod.GetProgress();
                        }));
                        ProgressBarUpdate?.Invoke(pb, new EventArgs());
                    } 
                }
                
            }
        }


    }
}
