using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClassWinForm;
using System.Security.Policy;

namespace ExInputControl
{
    public partial class FormInputControl : Form
    {
        
        private string name = "";
        private DateTime date;
        private double parsedAmount;
        private string zipCode = "";

        public FormInputControl()
        {
            InitializeComponent();
        }

        private void FormInputControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
            ("Fin de l’application ?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, FormControls.ErrorName(textBoxName.Text));
        }


        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxAmount, string.Empty);
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxZipCode, string.Empty);
        }


        private void textBoxName_Leave(object sender, EventArgs e)
        {
            name = textBoxName.Text;
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            FormControls.CheckAmountValidity(textBoxAmount.Text, out parsedAmount);
            errorProvider1.SetError(textBoxAmount, FormControls.ErrorAmount(textBoxAmount.Text));
        }

        private void textBoxZipCode_Leave(object sender, EventArgs e)
        {
            zipCode = textBoxZipCode.Text;
            errorProvider1.SetError(textBoxZipCode, FormControls.ErrorZipCode(zipCode));
        }

        private void maskedTextBoxDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider1.SetError(maskedTextBoxDate, "Format de date incorrect");
        }

        private void maskedTextBoxDate_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBoxDate.Text.Length == 10)
            {
                errorProvider1.SetError(maskedTextBoxDate, FormControls.ErrorDate(maskedTextBoxDate.Text));
            }
        }

        private void maskedTextBoxDate_Leave(object sender, EventArgs e)
        {
            FormControls.CheckDateValidity(maskedTextBoxDate.Text, out date);
            errorProvider1.SetError(maskedTextBoxDate, FormControls.FutureDate(date));  
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (FormControls.CheckNameValidity(name) && (FormControls.CheckDateValidity(maskedTextBoxDate.Text, out date) || !FormControls.DateIsFuture(date)) && FormControls.CheckAmountValidity(textBoxAmount.Text , out parsedAmount) && FormControls.CheckZipCodeValidity(zipCode)){
                Transaction transaction = new Transaction(name, date, parsedAmount, zipCode);
                MessageBox.Show
                ("Nom : " + transaction.Name 
                + "\nDate : " + transaction.Date.ToString("dd/MM/yyyy") 
                + "\nMontant : " + transaction.Amount 
                + "\nCode : " + transaction.Zipcode, 
                "Validation effectuée",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                errorProvider1.SetError(textBoxName, FormControls.ErrorName(name));
                errorProvider1.SetError(maskedTextBoxDate, FormControls.FutureDate(date));
                errorProvider1.SetError(textBoxAmount, FormControls.ErrorAmount(textBoxAmount.Text));
                errorProvider1.SetError(textBoxZipCode, FormControls.ErrorZipCode(zipCode));
            }
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxZipCode.Text = string.Empty;
            maskedTextBoxDate.Text = string.Empty;
            textBoxAmount.Text = string.Empty;
            errorProvider1.SetError(textBoxName, string.Empty);
            errorProvider1.SetError(maskedTextBoxDate, string.Empty);
            errorProvider1.SetError(textBoxAmount, string.Empty);
            errorProvider1.SetError(textBoxZipCode, string.Empty);
        }  
    }
}
