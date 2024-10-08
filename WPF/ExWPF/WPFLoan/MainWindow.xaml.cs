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

namespace WPFLoan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Loan loan = Loan.LoadData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DurationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            DurationText.Text = DurationSlider.Value.ToString();
        }

        private void RadioRate_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            loan.Rate = Double.Parse(radio.Tag.ToString());
            if (textBoxCapital.Text != string.Empty)
            {
                DisplayResults();
            }
        }

        private void DisplayResults()
        {
            loan.CalcRefunds();
            labelRefundAmount.Text = (labelRefundAmount.Text == string.Empty ? "Zéro" : loan.Refunds.ToString()) + " €";
        }
    }
}