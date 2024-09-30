using System;

namespace UCProd
{
    public partial class UserControlProgress : UserControl
    {
        public readonly static char[] alphabet = Enumerable.Range('A', 26).Select(asciiCode => (char)asciiCode).ToArray();
        public UserControlProgress(int i, int yAxis)
        {
            InitializeComponent();
            label1.Text = "Production " + alphabet[i];
            this.Name = "progressBar" + i.ToString();
            this.Location = new Point(0, yAxis);
        }
    }
}
