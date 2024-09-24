using ClassWinForm;
using ExAdditionneur;
using ExInputControl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsMenuOld
{
    public partial class Form1 : Form
    {
        private bool loggedIn = false;
        private int formCount;
        private FormAdditionneur additionneur;
        private FormInputControl formInputControl;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void toolStripMenuItemLogIn_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            loggedIn = formLogin.logged;
            if (loggedIn)
            {
                MessageBox.Show
                ("Bienvenue ! ", "Hello World",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                toolStripMenuItemP1.Visible = loggedIn;
                toolStripMenuItemP2.Visible = loggedIn;
                toolStripMenuItemP3.Visible = loggedIn;
                toolStripSplitButtonP3.Visible = loggedIn;
                toolStripSeparator2.Visible = loggedIn;
                toolStripMenuItemWindow.Visible = loggedIn;
                toolStripMenuItemP1.Enabled = loggedIn;
                toolStripMenuItemP2.Enabled = loggedIn;
                toolStripMenuItemP3.Enabled = loggedIn;
                toolStripSplitButtonP3.Enabled = loggedIn;
                toolStripSeparator2.Enabled = loggedIn;
                toolStripMenuItemWindow.Enabled = loggedIn;
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
           ("Quitter l’application ?", "Quitter",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void toolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemInput_Click(object sender, EventArgs e)
        {
            FormClosedEventArgs closed = new FormClosedEventArgs(CloseReason.None);

            formCount = Application.OpenForms.OfType<FormAdditionneur>().Count();
            additionneur = new FormAdditionneur();
            additionneur.Text += " N°" + formCount;
            additionneur.MdiParent = this;
            additionneur.Show();
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = additionneur.Text;
            toolStripMenuItemWindow.DropDownItems.Add(item.Text);
            additionneur.FormClosed += new FormClosedEventHandler(ChildFormClosed);
        }

        private void toolStripMenuItemControl_Click(object sender, EventArgs e)
        {
            formCount = Application.OpenForms.OfType<FormInputControl>().Count() + 1;
            formInputControl = new FormInputControl();
            formInputControl.Text += " N°" + formCount;
            formInputControl.MdiParent = this;
            formInputControl.Show();
        }

        private void toolStripMenuItemCases_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.labelDate.Text = DateTime.Now.ToString();
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            FormAdditionneur f = sender as FormAdditionneur;
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = f.Text;
            int index = 0;
            for (int i = 0; i < toolStripMenuItemWindow.DropDownItems.Count; i++)
            {
                if (toolStripMenuItemWindow.DropDownItems[i].Text == toolStripMenuItem.Text)
                {
                    index = i;
                    break;
                }
            }
            toolStripMenuItemWindow.DropDownItems.Remove(toolStripMenuItemWindow.DropDownItems[index]);
        }
    }
}
