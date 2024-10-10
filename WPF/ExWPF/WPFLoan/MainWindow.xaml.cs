using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfClassLibrary;
using WPFLoan.ViewModels;

namespace WPFLoan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Loan loan = Loan.LoadData();
        LoanViewModel loanVM = new();
        public MainWindow()
        {
            
            InitializeComponent();
            this.DataContext = loanVM;
            textBoxName.Focus();
            listBoxTime.SelectedIndex = loanVM.Periodicity;
            CheckRadioButtons();
            durationText.Text = durationSlider.Value.ToString();
            loanVM.CalcRate(loanVM.RefundDivider);
            textBoxCapital.Text = loanVM.Amount.ToString();
            textBoxName.Text = loanVM.Name;
        }

        private void DurationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SetScrollvalue((int)durationSlider.Value, loanVM.RefundDivider);
            durationText.Text = durationSlider.Value.ToString();
            loanVM.Months = (int)durationSlider.Value;
            loan.RefundDivider = (int)durationSlider.Value / SetPeriodicity();
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private void RadioRate_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            loanVM.Rate = Double.Parse(radio.Tag.ToString());
            CheckRadioButtons();
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private void DisplayResults()
        {
            SetRefundNumber();
            loanVM.CalcRefunds();
            if (labelRefundAmount != null) 
            {
                labelRefundAmount.Text = loanVM.Refunds.ToString() + " €";
            }   
        }

        private void SetRefundNumber()
        {
            if (refundsNumber != null)
            {
                refundsNumber.Text = (loanVM.Months / SetPeriodicity()).ToString();
            } 
        }

        private void CheckRadioButtons()
        {
            switch (loanVM.Rate)
            {
                case 7:
                    RadioRateSeven.IsChecked = true;
                    break;
                case 8:
                    RadioRateEight.IsChecked = true;
                    break;
                case 9:
                    RadioRateNine.IsChecked = true;
                    break;
                default:
                    RadioRateSeven.IsChecked = true;
                    loanVM.Rate = Double.Parse(RadioRateSeven.Tag.ToString());
                    break;
            }
        }

        private void SetScrollvalue(int change, int divider)
        {
            while (change % divider != 0 && durationSlider.Value > 12)
            {
                change--;
            }
            durationSlider.Value = change;
            loanVM.Months = change;
        }

        private void listBoxTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loanVM.Periodicity = listBoxTime.SelectedIndex;
            loanVM.RefundDivider = SetPeriodicity();
            durationSlider.LargeChange = SetPeriodicity();
            durationSlider.SmallChange = SetPeriodicity();
            AdjustScrollBar();
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }


        private void AdjustScrollBar()
        {
            durationSlider.Minimum = loanVM.RefundDivider;
            durationSlider.Value = loanVM.Months;
            durationSlider.Value = durationSlider.Value <= loanVM.RefundDivider ? loanVM.RefundDivider : loanVM.Months;
            durationText.Text = durationSlider.Value.ToString();
            loanVM.Periodicity = listBoxTime.SelectedIndex;
            SetScrollvalue((int)durationSlider.Value, loanVM.RefundDivider);

            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private int SetPeriodicity()
        {
            return (int)loanVM.Periodicity switch
            {
                0 => 1,
                1 => 2,
                2 => 3,
                3 => 6,
                4 => 12,
                _ => 1,
            };
        }

        private void textBoxCapital_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Controls.CheckAmountValidity(textBoxCapital.Text, out double parsedAmount))
            {
                loanVM.Amount = parsedAmount;
                DisplayResults();
            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text = loan.Name;
            textBoxCapital.Text = loan.Amount.ToString();
            listBoxTime.SelectedIndex = (int)loan.Periodicity;
            durationSlider.Value = loan.Months;
        }
    }
}