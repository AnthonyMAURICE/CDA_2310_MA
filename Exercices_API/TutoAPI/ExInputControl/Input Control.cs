using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExInputControl
{
    public partial class FormInputControl : Form
    {
        public FormInputControl()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Regex myRegex = new Regex(@"[A-Za-z]{1,30}$");
            Match match = myRegex.Match(textBoxName.Text);
            if (match.Success)
            {

            }
        }
    }
}
