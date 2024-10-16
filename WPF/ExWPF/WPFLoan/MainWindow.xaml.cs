using System.IO;
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
using WpfClassLibrary.Models;
using WPFLoan.ViewModels;

namespace WPFLoan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoanViewModel loanVM = new();

        public MainWindow()
        {
            InitializeComponent();
            SetIfLoaded();
            this.DataContext = loanVM;
            textBoxName.Focus();
        }

        private void SetIfLoaded()
        {
            loanVM.LoadFromDb();
            durationSlider.Value = loanVM.Months;
            listBoxTime.SelectedIndex = loanVM.Periodicity;
            CheckRadioButtons();
            SetRefundDivider();
            durationText.Text = durationSlider.Value.ToString();
            textBoxCapital.Text = loanVM.Amount.ToString();
            textBoxName.Text = loanVM.Name;
            textBoxCapital.Text = loanVM.Amount.ToString();
        }

        private void DurationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            durationText.Text = durationSlider.Value.ToString();
            SetScrollvalue((int)durationSlider.Value, SetRefundDivider());
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private void RadioRate_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            loanVM.Rate = Double.Parse(radio.Tag.ToString() ?? "0");
            CheckRadioButtons();
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private void DisplayResults()
        {
            SetRefundNumber();
            loanVM.CalculateRefunds();
            if (labelRefundAmount != null) 
            {
                labelRefundAmount.Text = loanVM.Refunds.ToString() + " €";
            }   
        }

        private void SetRefundNumber()
        {
            if (refundsNumber != null)
            {
                refundsNumber.Text = (loanVM.Months / SetRefundDivider()).ToString();
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
                    loanVM.Rate = Double.Parse(RadioRateSeven.Tag.ToString() ?? "0");
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
            loanVM.RefundDivider = SetRefundDivider();
            AdjustScrollBar();
        }

        private void AdjustScrollBar()
        {
            durationSlider.Minimum = loanVM.RefundDivider;
            durationSlider.LargeChange = SetRefundDivider();
            durationSlider.SmallChange = SetRefundDivider();
            durationSlider.Value = durationSlider.Value <= loanVM.RefundDivider ? durationSlider.Minimum : loanVM.Months;
            durationText.Text = durationSlider.Value.ToString();
            loanVM.Periodicity = listBoxTime.SelectedIndex;
            SetScrollvalue((int)durationSlider.Value, SetRefundDivider());
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private int SetRefundDivider()
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
            if (Controls.CheckNameValidity(textBoxName.Text) && Controls.CheckAmountValidity(textBoxCapital.Text, out double _))
            {
                string messageBoxText = "Sauvegarde locale effectuée !";
                string caption = "Job Done !";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                loanVM.Save();
            }
            else
            {
                string messageBoxText = "Erreurs dans la saisie !";
                string caption = "Warning : Error made of errors";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }  

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text = loanVM.Loan.LoanName;
            textBoxCapital.Text = "1";
            listBoxTime.SelectedIndex = 0;
            durationSlider.Value = 1;
            loanVM.Rate = 7;
            CheckRadioButtons();
        }

        private void localLoad_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(Loan.savePath + "save.json"))
            {
                loanVM = loanVM.LoadAfterSave();
                SetIfLoaded();
            }
            else
            {
                string messageBoxText = "Aucune sauvegarde locale présente";
                string caption = "Warning !";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Controls.CheckNameValidity(textBoxName.Text) && Controls.CheckAmountValidity(textBoxCapital.Text, out double _))
            {
                loanVM.SaveInDb();
            }
        }
    }
}