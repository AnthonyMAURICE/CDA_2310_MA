using LibraryCratesProd;
using System;

namespace UCProd
{
    public partial class UserControlProgress : UserControl
    {
        Label label;
        ProgressBar progressBar;
        public UserControlProgress(int count, int yAxis)
        {
            InitializeComponent();
            ProgressCreation(count, yAxis);
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
                progressBar.Tag = Production.alphabet[i] as object;
                progressBar.Location = new Point(200, yAxis);
                this.Controls.Add(label);
                this.Controls.Add(progressBar);
                yAxis += 40;
            }  
        }
    }
}
