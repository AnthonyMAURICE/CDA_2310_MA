using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAdditionneur
{
    public partial class FormAdditionneur : Form
    {
        int totalValue = 0;

        public FormAdditionneur()
        {
            InitializeComponent();
        }

        private void buttonBase_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calcBox.Text += (calcBox.Text != "" ? "+" :"") + button.Tag;
            //calcBox.Text += button.Text + "+";
            totalValue += int.Parse(button.Tag.ToString());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            totalValue = 0;
            calcBox.Clear();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            calcBox.Text += " = " + totalValue;
        }

        private void FormAdditionneur_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
