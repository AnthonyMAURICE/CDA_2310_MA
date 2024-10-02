using LibraryCratesProd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UCProd
{
    public partial class UserControlTab : UserControl
    {
        private TabControl tabControl;
        ProdLine prodLine;
        List<Production> productions = new List<Production>();

        public TabControl TabControl { get => tabControl;  }

        public UserControlTab(int elemCount, ProdLine prodLine)
        {
            InitializeComponent();
            this.tabControl = new TabControl();
            AddTabPages(elemCount);
            this.prodLine = prodLine;
            this.prodLine.ProdAdded += SetListProd;
        }

        public void SetListProd(object sender, EventArgs e)
        {
            foreach (Production prod in prodLine.Prods.Values)
            {
                prod.ItemAddedInList += UpdateTextBoxes;
                productions.Add(prod);
            }
        }

        private void AddTabPages(int elemCount)
        {
            for(int i = 0; i < elemCount; i++)
            {
                
                int yAxisTabPage = 10;
                TabPage tabPage = new();
                tabPage.Name = "tab" + i.ToString();
                this.tabControl.Size = new Size(400, 180);
                tabPage.Text = "Type " + Production.alphabet[i];
                for (int count = 0; count < elemCount; count++)
                {
                    tabPage.Controls.Add(AddLabel(count, yAxisTabPage));
                    tabPage.Controls.Add(AddTextBox(i, yAxisTabPage, count));
                    yAxisTabPage += 40;
                }
                this.tabControl.Controls.Add(tabPage);
            }
        }

        private Label AddLabel(int count, int yAxis)
        {
            Label label = new();
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

        private TextBox AddTextBox(int i, int yAxis, int count)
        {
            TextBox textBox = new();
            textBox.Location = new Point(280, yAxis);
            char identifier = Production.alphabet[i];
            switch (count)
            {
                case 0:
                    textBox.Name = "textBoxTotal" + identifier;
                    textBox.Tag = identifier.ToString();
                    break;
                case 1:
                    textBox.Name = "textBoxFlawsHour" + identifier;
                    textBox.Tag = "textBoxFlawsHour" + identifier;
                    break;
                case 2:
                    textBox.Name = "textBoxFlawsTotal" + identifier;
                    textBox.Tag = "textBoxFlawsTotal" + identifier;
                    break;
            }
            textBox.ReadOnly = true;
            return textBox;
        }

        public void UpdateTextBoxes(object sender, EventArgs e)
        {
            Production item = (Production)sender;
            foreach (TabPage page in this.TabControl.TabPages)
            {
                foreach (TextBox box in page.Controls.OfType<TextBox>())
                {
                    if (item.Type == box.Tag.ToString())
                    {
                        box.Invoke(new MethodInvoker(delegate
                        {
                            box.Text = item.GetValidCratesNumber().ToString();
                        }));
                    }
                    if(box.Tag.ToString() == "textBoxFlawsHour" + item.Type)
                    {

                        box.Invoke(new MethodInvoker(delegate
                        {
                            decimal flaws = item.GetLastHourFailureRate();
                            box.Text = flaws.ToString("0.####");
                        }));
                    }
                    if (box.Tag.ToString() == "textBoxFlawsTotal" + item.Type)
                    {

                        box.Invoke(new MethodInvoker(delegate
                        {
                            decimal flaws = item.GetTotalFailureRate();
                            box.Text = flaws.ToString("0.####");
                        }));
                    }
                }
            }
        }
    }
}
