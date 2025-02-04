using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonSayHello_Click(object sender, EventArgs e)
        {
            FormMood formMood = new FormMood();
            DialogResult dr = formMood.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            //textBox.Text = textBox1.Text;

            string newText = textBox1.Text;
        }
    }
}
