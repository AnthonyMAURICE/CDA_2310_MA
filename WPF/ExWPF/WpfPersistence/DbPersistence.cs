using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfPersistence.Models;

namespace WpfPersistence
{
    public class DbPersistence : Persistence, IPersistence
    {
        public void Insert(SLoan sLoan)
        {
            using (DbLoanContext context = new())
            {
                try
                {
                    Ref<SLoan> refSloan = new()
                    {
                        LoanName = sLoan.loanName,
                        Amount = sLoan.amount,
                        RefundDivider = sLoan.refundDivider,
                        Refunds = sLoan.refunds,
                        Rate = sLoan.rate,
                        Months = sLoan.months,
                        Periodicity = sLoan.periodicity
                    };
                    context.Loans.Add(refSloan);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    string messageBoxText = ex.Message;
                    string caption = "Warning !";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                }
            }
        }

        public SLoan Select()
        {
            using (DbLoanContext context = new())
            {
                try
                {
                    if (context.Loans == null)
                    {
                        return new();
                    }
                    else
                    {
                        Ref<SLoan> tempLoan = context.Loans.Find(5)!;
                        SLoan sLoan = new()
                        {
                            loanId = tempLoan.LoanId,
                            loanName = tempLoan.LoanName,
                            amount = tempLoan.Amount,
                            refunds = tempLoan.Refunds,
                            refundDivider = tempLoan.RefundDivider,
                            months = tempLoan.Months,
                            rate = tempLoan.Rate,
                            periodicity = (int)tempLoan.Periodicity
                        };
                        return sLoan;
                    }
                }
                catch (Exception ex)
                {
                    string messageBoxText = ex.Message;
                    string caption = "Warning !";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Warning;
                    MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                    return new();
                }
            }
        }
    }
}
