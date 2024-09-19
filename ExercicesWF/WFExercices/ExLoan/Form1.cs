using ClassLibrary2;
using ClassWinForm;
using Microsoft.VisualBasic.Devices;
using System.Text.Json;

namespace ExLoan
{


    public partial class Form1 : Form
    {
        private Loan loan = new();
        private int refundDivider;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string savepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\loan\\save\\save.json";
            textBoxName.Focus();
            radioButtonSeven.Checked = true;
            listBoxTime.SelectedIndex = 0;
            refundDivider = 1;
            hScrollBarMonth.Value = 1;
            labelMonthNumber.Text = hScrollBarMonth.Value.ToString();
            labelNbRefund.Text = (hScrollBarMonth.Value / refundDivider).ToString();
            loan.CalcRate(radioButtonSeven.Tag.ToString(), refundDivider);
            if (File.Exists(savepath))
            {
                string jsonLoad = File.ReadAllText(savepath);
                Loan? savedLoan = JsonSerializer.Deserialize<Loan>(jsonLoad);
                textBoxName.Text = savedLoan.Name;
                textBoxCapital.Text = savedLoan.Amount.ToString();
            }
        }

        private void hScrollBarMonth_ValueChanged(object sender, EventArgs e)
        {
            SetScrollvalue(hScrollBarMonth.Value, refundDivider);
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
            AdjustScrollBar();
        }

        private void AdjustScrollBar()
        {
            hScrollBarMonth.Minimum = refundDivider;
            if (hScrollBarMonth.Value <= refundDivider)
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
            labelRefundAmount.Text = loan.Refunds.ToString() + " €";
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
            loan.CalcRate(radio.Tag.ToString(), refundDivider);
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
