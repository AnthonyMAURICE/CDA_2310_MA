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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExInputControl
{
    public partial class FormInputControl : Form
    {
        private string name;
        public FormInputControl()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Regex myRegex = new Regex(@"^[a-zA-z,/.-]{1,30}$");
            Match match = myRegex.Match(textBoxName.Text);
            if (match.Success)
            {
                errorProvider1.SetError(textBoxName, "");
                name = textBoxName.Text;
            }
            else
            {
                errorProvider1.SetError(textBoxName, "Entrée invalide");
            }
        }
    }
}
