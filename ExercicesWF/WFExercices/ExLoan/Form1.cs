using ClassLibrary2;
using ClassWinForm;
using Microsoft.VisualBasic.Devices;

namespace ExLoan
{


    public partial class Form1 : Form
    {
        private Loan loan = new();
        private int refundDivider;
        private double refunds = 0;
        private int rate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
            radioButtonSeven.Checked = true;
            listBoxTime.SelectedIndex = 0;
            hScrollBarMonth.Value = 1;
            labelMonthNumber.Text = hScrollBarMonth.Value.ToString();
            labelNbRefund.Text = (hScrollBarMonth.Value / refundDivider).ToString();
            loan.Rate = RateCalc(radioButtonSeven.Tag.ToString());
        }

        private void hScrollBarMonth_ValueChanged(object sender, EventArgs e)
        {
            labelMonthNumber.Text = hScrollBarMonth.Value.ToString();
            labelNbRefund.Text = (hScrollBarMonth.Value / refundDivider).ToString();
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
                    refundDivider = 1;
                    break;
                case 1:
                    hScrollBarMonth.LargeChange = 2;
                    hScrollBarMonth.SmallChange = 2;
                    hScrollBarMonth.Maximum = 201;
                    refundDivider = 2;
                    break;
                case 2:
                    hScrollBarMonth.LargeChange = 3;
                    hScrollBarMonth.SmallChange = 3;
                    hScrollBarMonth.Maximum = 202;
                    refundDivider = 3;
                    break;
                case 3:
                    hScrollBarMonth.LargeChange = 6;
                    hScrollBarMonth.SmallChange = 6;
                    hScrollBarMonth.Maximum = 205;
                    refundDivider = 6;
                    break;
                case 4:
                    hScrollBarMonth.LargeChange = 12;
                    hScrollBarMonth.SmallChange = 12;
                    hScrollBarMonth.Maximum = 211;
                    refundDivider = 12;
                    break;
                default:
                    labelRefundAmount.Text = "Hé, c'est du vol ça !";
                    labelNbRefund.Text = string.Empty;
                    buttonOk.Enabled = false;
                    break;
            }
            hScrollBarMonth.Minimum = refundDivider;
            hScrollBarMonth.Value = hScrollBarMonth.Minimum;
            if(hScrollBarMonth.Value <= refundDivider)
            {
                hScrollBarMonth.Value = refundDivider;
                labelMonthNumber.Text = hScrollBarMonth.Value.ToString();
            }
            loan.SetPeriodicity(listBoxTime.SelectedIndex);
            SetScrollvalue(hScrollBarMonth.Value, refundDivider);
            if (textBoxCapital.Text != string.Empty && listBoxTime.SelectedIndex != 5)
            {
                DisplayResults();
            }

        }

        private double RateCalc(string tag)
        {
            FormControls.CheckAmountValidity(tag, out double parsedRate);
            double calcedRate = parsedRate / 12 * refundDivider / 100;
            return calcedRate;
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
            loan.CalcRefunds(hScrollBarMonth.Value / refundDivider);
            labelRefundAmount.Text = Math.Round(loan.Refunds, 2).ToString() + " €";
        }

        private void SetScrollvalue(int change, int divider)
        {
            while (change % divider != 0 && hScrollBarMonth.Value > 12)
            {
                change--;
            }
            hScrollBarMonth.Value = change;
        }

        private void radioButtonRate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            loan.Rate = RateCalc(radio.Tag.ToString());
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
    }
}
