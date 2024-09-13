using ClassWinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComboBox
{
    public partial class FormCombo : Form
    {
        private readonly string[] countries = {"France", "Belgique", "Allemagne", "Japon", "Portugal", "Grece", "Bulgarie", "Espagne"};
        public FormCombo()
        {
            InitializeComponent();
        }

        private void FormCombo_Load(object sender, EventArgs e)
        {
            foreach (string country in countries)
            {
                comboBoxOrigin.Items.Add(country);
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (comboBoxOrigin.SelectedItem != null || listBoxTarget.SelectedItem != null)
            {
                if (btn.Tag.ToString() == "addOne")
                {
                    listBoxTarget.Items.Add(comboBoxOrigin.SelectedItem);
                    comboBoxOrigin.Items.Remove(comboBoxOrigin.SelectedItem);
                }
                else
                {
                    comboBoxOrigin.Items.Add(listBoxTarget.SelectedItem);
                    listBoxTarget.Items.Remove(listBoxTarget.SelectedItem);
                }
            }
            comboBoxOrigin.Text = string.Empty;
        }

        private void buttonMany_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag.ToString() == "addMany")
            {
                foreach(string country in comboBoxOrigin.Items)
                {
                    listBoxTarget.Items.Add(country);
                }
                comboBoxOrigin.Items.Clear();
            }
            else
            {
                foreach (string country in listBoxTarget.Items)
                {
                    comboBoxOrigin.Items.Add(country);
                }
                listBoxTarget.Items.Clear();
            }
            comboBoxOrigin.Text = "";
        }

        private void MoveItem(int way) 
        {
            int newIndex = listBoxTarget.SelectedIndex + way;
            object selected = listBoxTarget.SelectedItem;
            listBoxTarget.Items.Remove(selected);
            listBoxTarget.Items.Insert(newIndex, selected);
            listBoxTarget.SetSelected(newIndex, true);
        }

        private void MoveUpClick(object sender, EventArgs e)
        {
            if (listBoxTarget.SelectedItem != null && listBoxTarget.SelectedIndex > 0)
            {
                MoveItem(-1);
            }
        }

        private void MoveDownClick(object sender, EventArgs e)
        {
            if (listBoxTarget.SelectedItem != null && listBoxTarget.SelectedIndex < listBoxTarget.Items.Count - 1)
            {
                MoveItem(1);
            }
        }

        private void comboBoxOrigin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && FormControls.CheckNameValidity(comboBoxOrigin.Text))
            {
                if (!comboBoxOrigin.Items.Contains(comboBoxOrigin.Text) && !listBoxTarget.Items.Contains(comboBoxOrigin.Text))
                {
                    comboBoxOrigin.Items.Add(comboBoxOrigin.Text);
                    comboBoxOrigin.Text = string.Empty;
                }
                else
                {
                    errorProvider1.SetError(comboBoxOrigin, comboBoxOrigin.Text == string.Empty ? "Saisissez quelque chose !" : comboBoxOrigin.Text + " est déjà présent dans une des listes !");
                }
            }
            else
            {
                errorProvider1.SetError(comboBoxOrigin, comboBoxOrigin.Text == string.Empty? "Saisissez quelque chose !" : "Saisie invalide !");
            }
        }

        private void comboBoxOrigin_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxOrigin, string.Empty);
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUp.Enabled = listBoxTarget.Items.Count > 1 && listBoxTarget.SelectedIndex > 0;
            buttonDown.Enabled = listBoxTarget.Items.Count > 1 && listBoxTarget.SelectedIndex < listBoxTarget.Items.Count -1;
        }
    }
}