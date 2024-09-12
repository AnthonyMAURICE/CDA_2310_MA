using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExCheckRadio
{
    public partial class FormCheckRadio : Form
    {
        public FormCheckRadio()
        {
            InitializeComponent();
        }

        private void checkBoxBack_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRadioBack.Visible = checkBoxBack.Checked;
        }

        private void checkBoxChar_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRadioChar.Visible = checkBoxChar.Checked;
        }

        private void checkBoxCase_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRadioCase.Visible = checkBoxCase.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            groupBoxCheck.Enabled = textBox1.Text != "";
            labelText.Text = textBox1.Text;
        }


        private void radioButtonCase_CheckedChanged(object sender, EventArgs e)
        {
            labelText.Text = radioButtonLowerCase.Checked ? labelText.Text.ToLower() : labelText.Text.ToUpper();
        }

        private void labelText_TextChanged(object sender, EventArgs e)
        {
            if(radioButtonLowerCase.Checked || radioButtonUpperCase.Checked)
            {
                labelText.Text = radioButtonLowerCase.Checked ? labelText.Text.ToLower() : labelText.Text.ToUpper();
            }
        }

        private void radioButtonBack_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            labelText.BackColor = Color.FromName(btn.Tag.ToString());
        }

        private void radioButtonChara_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            labelText.ForeColor = Color.FromName(btn.Tag.ToString());
        }

        private void groupBoxCheck_EnabledChanged(object sender, EventArgs e)
        {
            groupBoxRadioBack.Visible = groupBoxCheck.Enabled;
            groupBoxRadioChar.Visible = groupBoxCheck.Enabled;
            groupBoxRadioCase.Visible = groupBoxCheck.Enabled;
        }
    }
}