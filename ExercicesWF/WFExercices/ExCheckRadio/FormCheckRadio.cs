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
        private string originalString;
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
            groupBoxCheck.Enabled = textBox1.Text != string.Empty;
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
            if(radioButtonBackBlue.Checked || radioButtonBackGreen.Checked || radioButtonBackRed.Checked)
            {
                labelText.BackColor = Color.FromName(btn.Tag.ToString());
            }
            else
            {
                labelText.BackColor = Color.Transparent;
            }
            
        }

        private void radioButtonChara_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            if (radioButtonBackBlue.Checked || radioButtonBackGreen.Checked || radioButtonBackRed.Checked)
            {
                labelText.ForeColor = Color.FromName(btn.Tag.ToString());
            }
            else
            {
                labelText.ForeColor = Color.Black;
            }
        }

        private void groupBoxCheck_EnabledChanged(object sender, EventArgs e)
        {
            if (!groupBoxCheck.Enabled)
            {
                groupBoxRadioBack.Visible = false;
                groupBoxRadioChar.Visible = false;
                groupBoxRadioCase.Visible = false;
                checkBoxBack.Checked = false;
                checkBoxCase.Checked = false;
                checkBoxChar.Checked = false;
            }
        }

        private void groupBoxRadioBack_VisibleChanged(object sender, EventArgs e)
        {
            if (!groupBoxRadioBack.Visible)
            {
                radioButtonBackBlue.Checked = false;
                radioButtonBackGreen.Checked = false;
                radioButtonBackRed.Checked = false;
            }
        }

        private void groupBoxRadioChar_VisibleChanged(object sender, EventArgs e)
        {
            if (!groupBoxRadioChar.Visible)
            {
                radioButtonCharaBlack.Checked = false;
                radioButtonCharaWhite.Checked = false;
                radioButtonCharaBlack.Checked = false;
            } 
        }

        private void groupBoxRadioCase_VisibleChanged(object sender, EventArgs e)
        {
            if (!groupBoxRadioCase.Visible)
            {
                radioButtonLowerCase.Checked = false;
                radioButtonUpperCase.Checked = false;
            }  
        }
    }
}