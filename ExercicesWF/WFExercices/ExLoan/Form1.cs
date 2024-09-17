using ClassLibrary2;
using ClassWinForm;

namespace ExLoan
{
    public partial class Form1 : Form
    {
        private double refundDivider;
        private double refunds = 0;
        private double rate;
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
            hScrollBarMonth.Value = 1;
        }

        private void textBoxCapital_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCapital.Text != string.Empty && FormControls.CheckAmountValidity(textBoxCapital.Text, out double amount))
            {
                calcRefund(amount);
            }
        }

        private void calcRefund(double amount)
        {
            FormControls.CheckAmountValidity(hScrollBarMonth.Value.ToString(), out double parsedMonth);
            double timedRate = rate / (12 / refundDivider);
            double nbeRefunds = parsedMonth / refundDivider;

            if (amount == 150000)
            {
                refunds = amount * (timedRate / (1- Loan.Power(timedRate, nbeRefunds)));
            }
        }

        private void radioButtonRate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            FormControls.CheckIfInt(btn.Tag.ToString(), out int parsedRate);
            rate = parsedRate;
        }
    }
}
