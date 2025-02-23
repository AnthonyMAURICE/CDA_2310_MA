﻿using ExWPF.ViewModels;
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

namespace ExWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        ControlViewModel viewModel = new();
        private bool firstInput = true;
        IEnumerable<TextBox> textBoxes;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
            this.textBoxes = this.MainGrid.Children.OfType<TextBox>();
        }


        private void btnErase_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (TextBox tb in textBoxes)
            {
                tb.Text = string.Empty;
            }
        }

        private void btnValid_Click(object sender, RoutedEventArgs e)
        {
            bool notEmptyTextbox = true;
            foreach (TextBox tb in textBoxes)
            {
                if(tb.Text == string.Empty)
                {
                    notEmptyTextbox = false;
                }
            }
            if (notEmptyTextbox && viewModel.Control(nameValue.Text, dateValue.Text, amountValue.Text, zipValue.Text))
            {
                this.ShowMessage();
            }
            else
            {
                this.ShowErrorMessage();
            }
        }

        private void ShowMessage()
        {
            MessageBox.Show("Nom : " + viewModel.Name
                    + "\nDate : " + viewModel.FormatedDate
                    + "\nMontant : " + viewModel.Amount
                    + "\nCode : " + viewModel.Zipcode, "Validation effectuée");
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show("Erreur(s) dans votre saisie !", "Validation refusée");
        }

        private void dateValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                string text = textBox.Text.Replace("/", "");
                if (text.Length >= 2 && text.Length < 4)
                {
                    textBox.Text = text.Insert(2, "/");
                    textBox.Select(textBox.Text.Length, 0);
                }
                else if (text.Length >= 4)
                {
                    textBox.Text = text.Insert(2, "/").Insert(5, "/");
                    textBox.Select(textBox.Text.Length, 0);
                }
            }
        }

        private void dateValue_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstInput)
            {
                dateValue.Text = string.Empty;
                firstInput = false;
            }
        }
    }
}