using System;
using System.Collections.Generic;
using System.Windows;
using WpfClassLibrary;

namespace WPFLoan.Models;

public partial class Loan : ISaveLoad
{

    private readonly int loanId;
    private string loanName;
    private double amount;
    private double rate;
    private double refunds;
    private int refundDivider;
    private int months;
    private Periodicity periodicity;
    public static readonly string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\loanWPF\\save\\";

    public int LoanId { get => loanId ; }

    public string LoanName { get => loanName ; set => loanName = value; }

    public double Amount { get => amount; set => amount = value; }

    public double Rate { get => rate; set => rate = value; }

    public double Refunds { get => refunds; set => refunds = value; }

    public int RefundDivider { get => refundDivider; set => refundDivider = value; }

    public int Months { get => months; set => months = value; }

    public Periodicity Periodicity { get => periodicity; set => periodicity = value; }

    public Loan LoadDataFromDB()
    {
        using (DbLoanContext context = new())
        {
            try
            {
                Loan firstLoan = context.Loans.Find(2)!;
                return firstLoan;
            }
            catch (Exception ex)
            {
                string messageBoxText = ex.Message;
                string caption = "Warning !";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                return new();
            }
        }
    }

    public void SaveDataInDB()
    {
        using (DbLoanContext context = new()) 
        {
            try
            {
                context.Loans.Add(this);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string messageBoxText = ex.Message;
                string caption = "Warning !";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }
    }
}
