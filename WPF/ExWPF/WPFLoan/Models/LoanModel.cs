using System;
using System.Collections.Generic;
using WpfClassLibrary;

namespace WPFLoan.Models;

interface ISave
{
    void SaveDataInDB();
    void LoadDataFromDB();
}

public partial class Loan : ISave
{
    public int LoanId { get; set; }

    public string LoanName { get; set; } = null!;

    public double Amount { get; set; }

    public double Rate { get; set; }

    public double Refunds { get; set; }

    public int RefundDivider { get; set; }

    public int Months { get; set; }

    public int Periodicity { get; set; }

    public void LoadDataFromDB()
    {
        
    }

    public void SaveDataInDB()
    {
        
    }
}
