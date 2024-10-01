using LibraryCratesProd;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading;

namespace UCProd
{
    public partial class UserControlProgress : UserControl
    {
        Label label;
        ProgressBar progressBar;
        ProdLine prodLine;

        public UserControlProgress(int count, int yAxis, ProdLine prodLine)
        {
            InitializeComponent();
            ProgressCreation(count, yAxis);
            this.prodLine = prodLine;
            
            
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
                progressBar.Size = new Size(200, 20);
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Location = new Point(200, yAxis);
                this.Controls.Add(label);
                this.Controls.Add(progressBar);
                yAxis += 40;
            }

        }

        public void UpdateProgressBar(Production item)
        {
            int progress = 0;
            IEnumerable<ProgressBar> elem = this.Controls.OfType<ProgressBar>();
            foreach (ProgressBar pb in elem)
            {
                if (item.Type == pb.Tag.ToString())
                {
                    pb.Invoke(new MethodInvoker(delegate
                    {
                        //elem.Value = item.GetProgress();
                        pb.Value = 50;
                        pb.Update();
                        pb.Refresh();
                    }));

                }
            }
        }
    }
}
