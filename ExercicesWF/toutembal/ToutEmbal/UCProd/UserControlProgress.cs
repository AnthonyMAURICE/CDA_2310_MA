namespace UCProd
{
    public partial class UserControlProgress : UserControl
    {
        public readonly static char[] alphabet = Enumerable.Range('A', 26).Select(asciiCode => (char)asciiCode).ToArray();
        public UserControlProgress(int i)
        {
            InitializeComponent();
            label1.Text = "Production " + alphabet[i];
        }
    }
}
