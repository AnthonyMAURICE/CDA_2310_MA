using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCProd
{
    public partial class UserControlTab : UserControl
    {
        private TabControl tabControl;

        public TabControl TabControl { get => tabControl;  }

        public UserControlTab(int i)
        {
            InitializeComponent();
            this.tabControl = new TabControl();
            AddTabPages(i);
        }

        private void AddTabPages(int i)
        {
            int yAxisTabPage = 10;
            TabPage tabPage = new TabPage();
            tabPage.Text = "Type " + UserControlProgress.alphabet[i];
            for (int count = 0; count < 3; count++)
            {
                tabPage.Controls.Add(AddLabel(count, yAxisTabPage));
                tabPage.Controls.Add(AddTextBox(count, yAxisTabPage));
                yAxisTabPage += 40;
            }
            this.tabControl.Controls.Add(tabPage);
        }

        private Label AddLabel(int count, int yAxis)
        {
            Label label = new Label();
            label.Location = new Point(10, yAxis);
            label.Size = new Size(250, 20);
            switch (count)
            {
                case 0:
                    label.Text = "Nombre de caisses depuis le démarrage";
                    break;
                case 1:
                    label.Text = "Taux défaut heure (en %)";
                    break;
                case 2:
                    label.Text = "Taux défaut depuis démarrage (en %)";
                    break;
                default:
                    label.Text = "Something went wrong";
                    break;
            }
            return label;
        }

        private TextBox AddTextBox(int y, int yAxis)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(280, yAxis);
            char identifier = UserControlProgress.alphabet[y];
            switch (y)
            {
                case 0:
                    textBox.Name = "textBoxTotal" + identifier;
                    textBox.Tag = identifier;
                    break;
                case 1:
                    textBox.Name = "textBoxFlawsHour" + identifier;
                    break;
                case 2:
                    textBox.Name = "textBoxFlawsTotal" + identifier;
                    break;
                default:
                    textBox.Name = "textBoxTotal" + identifier;
                    break;
            }
            return textBox;
        }
    }
}
