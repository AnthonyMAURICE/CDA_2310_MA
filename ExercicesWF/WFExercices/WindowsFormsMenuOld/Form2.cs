using ExCheckRadio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMenuOld
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text != string.Empty) 
            {
                FormCheckRadio formCheckRadio = new FormCheckRadio();
                formCheckRadio.textBox1.Text = textBoxInput.Text;
                formCheckRadio.MdiParent = Form1.ActiveForm;
                formCheckRadio.Show();
                this.Close();
            }
            else
            {
                errorProvider1.SetError(textBoxInput, "Saisissez du texte");
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxInput, string.Empty);
        }
    }
}
