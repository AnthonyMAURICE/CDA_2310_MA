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

namespace ExInputControl
{
    public partial class FormInputControl : Form
    {
        
        readonly Regex nameRegex = new Regex(@"^\p{Lu}[a-zA-z,/.-]{0,30}$");
        readonly Regex timeRegex = new Regex(@"^(3[01]|[12][0-9]|0?[1-9])(\/|-)(1[0-2]|0?[1-9])\2([0-9]{2})?[0-9]{2}$");
        readonly Regex amountRegex = new Regex(@"[0-9]?[0-9]?([\.\,][0-9][0-9]?)?");
        readonly Regex zipCodeRegex = new Regex(@"^\d{5}$");
        private const string format = "dd/MM/yyyy";

        private string name;
        private DateTime date;
        private double parsedAmount;
        private string zipCode;

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
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            string errorMessage = "";
            Match match = nameRegex.Match(textBoxName.Text);
            if (match.Success)
            {
                errorProvider1.SetError(textBoxName, string.Empty);
                
            }
            else
            {
                if (!Transaction.CheckNameValidity(textBoxName.Text))
                {
                    errorMessage += "Nom trop long / ";
                    errorProvider1.SetError(textBoxName, "Nom trop long");
                }
                errorMessage += "Nom invalide";
                errorProvider1.SetError(textBoxName, errorMessage);
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxDate, string.Empty);
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            Match match = nameRegex.Match(textBoxName.Text);
            if (match.Success)
            {
                errorProvider1.SetError(textBoxName, string.Empty);
                name = textBoxName.Text;
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "Nom invalide");
            }
        }

        private void textBoxDate_Validating(object sender, CancelEventArgs e)
        {
            Match match = timeRegex.Match(textBoxDate.Text);
            if (match.Success)
            {
                date = DateTime.ParseExact(textBoxDate.Text, format, CultureInfo.CurrentCulture); // voir tryparseexact
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxDate, "Date invalide");
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxAmount, string.Empty);
        }

        private void textBoxAmount_Validating(object sender, CancelEventArgs e)
        {
            if (!Double.TryParse(textBoxAmount.Text.Replace('.', ','), out double amount))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxAmount, "Montant invalide");
            }
            else
            {
                parsedAmount = amount;
            }
        }

        private void textBoxZipCode_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxZipCode, string.Empty);
            if(textBoxZipCode.Text.Length == 5)
            {
                Match match = zipCodeRegex.Match(textBoxZipCode.Text);
                if (match.Success)
                {
                    zipCode = textBoxZipCode.Text;
                    buttonValidate.Enabled = true;
                }
                else
                {
                    errorProvider1.SetError(textBoxZipCode, "Code postal invalide");
                }
            }
            else
            {
                buttonValidate.Enabled = false;
            }
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {  
            textBoxName.Text = string.Empty;
            textBoxZipCode.Text = string.Empty;
            textBoxDate.Text = string.Empty;
            textBoxAmount.Text = string.Empty;
            errorProvider1.SetError(textBoxName, string.Empty);
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (!Transaction.CheckNameValidity(name))
            {
                errorProvider1.SetError(textBoxName, "Nom trop long");
            }
            else if (!Transaction.CheckDateValidity(date))
            {
                errorProvider1.SetError(textBoxDate, "Date invalide");
            }
            else if (!Transaction.CheckAmountValidity(parsedAmount))
            {
                errorProvider1.SetError(textBoxAmount, "Montant invalide");
            }
            else
            {
                Transaction transaction = new Transaction(name, date, parsedAmount, zipCode);
                MessageBox.Show
                ("Nom : " + transaction.Name + "\nDate : " + transaction.Date.ToString(format) + "\nMontant : " + transaction.Amount + "\nCode : " + transaction.Zipcode, "Validation effectuée",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1);
            }
        }
    }
}
