using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                    context.Loans.Add((new WpfClassLibrary.Loan(sLoan)));
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
            using (DbLoanContext? context = new())
            {
                try
                {
                    if (context.Loans == null)
                    {
                        return new();
                    }
                    else
                    {
                        return new(context.Loans.Find(8)!);
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
