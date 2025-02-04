using ClassLibrary2;
using ClassWinForm;
using System.Windows.Forms;

namespace FormComboBoxSecond
{
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void FormComboBox_Load(object sender, EventArgs e)
        {
            foreach (string country in Countries.countries)
            {
                comboBoxOrigin.Items.Add(country);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (listBoxTarget.SelectedItem != null && listBoxTarget.SelectedIndex > 0)
            {
                MoveItem(-1);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listBoxTarget.SelectedItem != null && listBoxTarget.SelectedIndex < listBoxTarget.Items.Count - 1)
            {
                MoveItem(1);
            }
        }

        private void MoveItem(int moving)
        {
            int newIndex = listBoxTarget.SelectedIndex + moving;
            object selected = listBoxTarget.SelectedItem;
            listBoxTarget.Items.Remove(selected);
            listBoxTarget.Items.Insert(newIndex, selected);
            listBoxTarget.SetSelected(newIndex, true);
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonsController();
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
                errorProvider1.SetError(comboBoxOrigin, comboBoxOrigin.Text == string.Empty ? "Saisissez quelque chose !" : "Saisie invalide !");
            }
            ButtonsController();
        }

        private void comboBoxOrigin_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(comboBoxOrigin, string.Empty);
        }

        private void comboBoxOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonsController();
        }

        private void ButtonsController()
        {
            buttonAddOne.Enabled = comboBoxOrigin.SelectedIndex >= 0;
            buttonAddAll.Enabled = comboBoxOrigin.Items.Count > 0;
            buttonRemoveOne.Enabled = listBoxTarget.SelectedIndex >= 0;
            buttonRemoveAll.Enabled = listBoxTarget.Items.Count > 0;
            buttonUp.Enabled = listBoxTarget.SelectedIndex > 0;
            buttonDown.Enabled = listBoxTarget.SelectedIndex < listBoxTarget.Items.Count - 1 && listBoxTarget.SelectedIndex >= 0;
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (string country in listBoxTarget.Items)
            {
                comboBoxOrigin.Items.Add(country);
            }
            listBoxTarget.Items.Clear();
            comboBoxOrigin.Text = string.Empty;
            ButtonsController();
        }

        private void buttonRemoveOne_Click(object sender, EventArgs e)
        {
            comboBoxOrigin.Items.Add(listBoxTarget.SelectedItem);
            listBoxTarget.Items.Remove(listBoxTarget.SelectedItem);
            comboBoxOrigin.Text = string.Empty;
            if (listBoxTarget.Items.Count > 0) 
            {
                listBoxTarget.SelectedIndex = 0;
            }
            ButtonsController();
        }

        private void buttonAddOne_Click(object sender, EventArgs e)
        {
            listBoxTarget.Items.Add(comboBoxOrigin.SelectedItem);
            comboBoxOrigin.Items.Remove(comboBoxOrigin.SelectedItem);
            comboBoxOrigin.Text = string.Empty;
            ButtonsController();
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            foreach (string country in comboBoxOrigin.Items)
            {
                listBoxTarget.Items.Add(country);
            }
            comboBoxOrigin.Items.Clear();
            comboBoxOrigin.Text = string.Empty;
            ButtonsController();
        }
    }
}
