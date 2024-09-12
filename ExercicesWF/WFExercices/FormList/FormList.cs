using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassWinForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormList
{
    public partial class FormList : Form
    {
        private int parsedInt;

        public FormList()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!FormControls.CheckNameValidity(textBoxNewElem.Text))
            {
                errorProvider1.SetError(textBoxNewElem, "Nom invalide");
            }
            else
            {
                if (listBox1.Items.Contains(textBoxNewElem.Text))
                {
                    errorProvider1.SetError(textBoxNewElem, "Nom déjà présent dans la liste");
                }
                else
                {
                    errorProvider1.SetError(textBoxNewElem, string.Empty);
                    listBox1.Items.Add(textBoxNewElem.Text);
                    textBoxNewElem.Text = "";
                    textBoxItemCount.Text = listBox1.Items.Count.ToString();
                }     
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxItemCount.Text = listBox1.Items.Count.ToString();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (!FormControls.CheckIfInt(textBoxIndexElem.Text, out parsedInt))
            {
                errorProvider1.SetError(textBoxIndexElem, "L'index doit être un nombre");
            }
            else
            {
                if (parsedInt < 0 || parsedInt > listBox1.Items.Count -1)
                {
                    errorProvider1.SetError(textBoxIndexElem, "L'index est hors limites de la liste");
                }
                else
                {
                    errorProvider1.SetError(textBoxIndexElem, string.Empty);
                    textBoxSelectedIndex.Text = parsedInt.ToString();
                    textBoxText.Text = listBox1.Items[parsedInt].ToString();
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = listBox1.SelectedIndex.ToString();
            textBoxText.Text = listBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxItemCount.Text = listBox1.Items.Count.ToString();
        }
    }
}
