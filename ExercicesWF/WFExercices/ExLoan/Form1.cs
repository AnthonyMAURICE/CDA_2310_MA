using ClassLibrary2;
using ClassWinForm;
using Microsoft.VisualBasic.Devices;
using System.Text.Json;

namespace ExLoan
{


    public partial class Form1 : Form
    {
        private Loan loan = Loan.LoadData();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
            hScrollBarMonth.Value = loan.Months;
            labelMonthNumber.Text = hScrollBarMonth.Value.ToString();
            labelNbRefund.Text = (hScrollBarMonth.Value / loan.RefundDivider).ToString();
            loan.CalcRate(loan.RefundDivider);
            textBoxCapital.Text = loan.Amount.ToString();
            listBoxTime.SelectedIndex = loan.Periodicity;
            textBoxName.Text = loan.Name;
            CheckRadioButtons();
        }

        private void hScrollBarMonth_ValueChanged(object sender, EventArgs e)
        {
            SetScrollvalue(hScrollBarMonth.Value, loan.RefundDivider);
            labelMonthNumber.Text = hScrollBarMonth.Value.ToString();
            labelNbRefund.Text = (hScrollBarMonth.Value / loan.RefundDivider).ToString();
        }

        private void listBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRefundAmount.Text = string.Empty;
            buttonOk.Enabled = true;
            switch (listBoxTime.SelectedIndex)
            {
                case 0:
                    hScrollBarMonth.LargeChange = 1;
                    hScrollBarMonth.SmallChange = 1;
                    hScrollBarMonth.Maximum = 200;
                    loan.RefundDivider = 1;
                    break;
                case 1:
                    hScrollBarMonth.LargeChange = 2;
                    hScrollBarMonth.SmallChange = 2;
                    hScrollBarMonth.Maximum = 201;
                    loan.RefundDivider = 2;
                    break;
                case 2:
                    hScrollBarMonth.LargeChange = 3;
                    hScrollBarMonth.SmallChange = 3;
                    hScrollBarMonth.Maximum = 202;
                    loan.RefundDivider = 3;
                    break;
                case 3:
                    hScrollBarMonth.LargeChange = 6;
                    hScrollBarMonth.SmallChange = 6;
                    hScrollBarMonth.Maximum = 205;
                    loan.RefundDivider = 6;
                    break;
                case 4:
                    hScrollBarMonth.LargeChange = 12;
                    hScrollBarMonth.SmallChange = 12;
                    hScrollBarMonth.Maximum = 211;
                    loan.RefundDivider = 12;
                    break;
                default:
                    labelRefundAmount.Text = "Hé, c'est du vol ça !";
                    labelNbRefund.Text = string.Empty;
                    buttonOk.Enabled = false;
                    break;
            }
            AdjustScrollBar();
        }

        private void CheckRadioButtons()
        {
            switch (loan.Rate)
            {
                case 7:
                    radioButtonSeven.Checked = true;
                    break;
                case 8:
                    radioButtonEight.Checked = true;
                    break;
                case 9:
                    radioButtonNine.Checked = true;
                    break;
                default:
                    radioButtonSeven.Checked = true;
                    break;
            }

        }

        private void AdjustScrollBar()
        {
            hScrollBarMonth.Minimum = loan.RefundDivider;
            if (hScrollBarMonth.Value <= loan.RefundDivider)
            {
                hScrollBarMonth.Value = loan.RefundDivider;
                labelMonthNumber.Text = hScrollBarMonth.Value.ToString();
            }
            loan.Periodicity = listBoxTime.SelectedIndex;
            SetScrollvalue(hScrollBarMonth.Value, loan.RefundDivider);

            if (textBoxCapital.Text != string.Empty && listBoxTime.SelectedIndex != 5)
            {
                DisplayResults();
            }
        }

        private void textBoxCapital_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = true;
            errorProvider1.SetError(textBoxCapital, string.Empty);
            FormControls.CheckAmountValidity(textBoxCapital.Text, out double amount);
            loan.Amount = amount;
            if (textBoxCapital.Text != string.Empty && FormControls.CheckIfInt(textBoxCapital.Text, out int parsedInt))
            {
                if (!FormControls.CheckLength(textBoxCapital.Text))
                {
                    buttonOk.Enabled = false;
                    errorProvider1.SetError(textBoxCapital, "Nombre trop long");
                }
                else
                {
                    DisplayResults();
                }
            }
            else
            {
                buttonOk.Enabled = false;
                errorProvider1.SetError(textBoxCapital, textBoxCapital.Text != string.Empty ? "Entrez un nombre" : "Format incorrect");
            }
        }

        private void DisplayResults()
        {
            loan.CalcRefunds(hScrollBarMonth.Value / loan.RefundDivider);
            labelRefundAmount.Text = (labelRefundAmount.Text == string.Empty? "Zéro" : loan.Refunds.ToString()) + " €";
        }

        private void SetScrollvalue(int change, int divider)
        {
            while (change % divider != 0 && hScrollBarMonth.Value > 12)
            {
                change--;
            }
            hScrollBarMonth.Value = change;
            loan.Months = change;
        }

        private void radioButtonRate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            loan.Rate = Double.Parse(radio.Tag.ToString());
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private void hScrollBarMonth_Scroll(object sender, ScrollEventArgs e)
        {
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxCapital.Text != string.Empty)
            {
                loan.SaveData();
            }
            else
            {
                errorProvider1.SetError(textBoxCapital, "Entrez un montant à emprunter");
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            loan.Name = textBoxName.Text;
        }
    }
}
