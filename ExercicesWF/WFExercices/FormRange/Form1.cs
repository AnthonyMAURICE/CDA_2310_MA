using ClassLibrary2;

namespace FormRange
{
    public partial class Form1 : Form
    {
        public Colors currentColor = new Colors();
        public Form1()
        {
            InitializeComponent();
            
            Colors initialColor = currentColor;
            currentColor = new Colors(initialColor);
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownRed.Value = (decimal)hScrollBarRed.Value;
            
            ChangeBoxColor();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownGreen.Value = (decimal)hScrollBarGreen.Value;
            
            ChangeBoxColor();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownBlue.Value = (decimal)hScrollBarBlue.Value;
            
            ChangeBoxColor();
        }
        
        private void ChangeBoxColor()
        {
            hScrollBarGreen.Value = (int)numericUpDownGreen.Value;
            hScrollBarBlue.Value = (int)numericUpDownBlue.Value;
            hScrollBarRed.Value = (int)numericUpDownRed.Value;
            currentColor.Red = (int)numericUpDownRed.Value;
            currentColor.Green = (int)numericUpDownGreen.Value;
            currentColor.Blue = (int)numericUpDownBlue.Value;
            textBoxColorized.BackColor = Color.FromArgb(currentColor.Red, currentColor.Green, currentColor.Blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeBoxColor();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarGreen.Value = (int)numericUpDownGreen.Value;
            ChangeBoxColor();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarBlue.Value = (int)numericUpDownBlue.Value;
            ChangeBoxColor();
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarRed.Value = (int)numericUpDownRed.Value;
            ChangeBoxColor();
        }

    }
}
