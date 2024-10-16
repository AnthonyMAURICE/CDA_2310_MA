using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfClassLibrary.Models;

public partial class Loan
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


    
}
