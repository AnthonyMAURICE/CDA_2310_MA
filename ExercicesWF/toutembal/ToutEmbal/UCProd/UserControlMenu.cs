﻿using LibraryCratesProd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UCProd
{
    public partial class UserControlMenu : UserControl
    {
        private ToolStripMenuItem item;
        private ToolStripMenuItem start;
        private ToolStripMenuItem stop;
        private ToolStripMenuItem resume;
        private List<ToolStripMenuItem> items = new();
        private ProdLine prodLines;

        public EventHandler ProdlinesCreated;

        public UserControlMenu(int elemCount, ProdLine prodLines)
        {
            InitializeComponent();
            CreateMenuElem(elemCount);
            this.prodLines = prodLines;
        }

        public List<ToolStripMenuItem> Items { get => items; }

        private void CreateMenuElem(int elemCount)
        {
            bool initialized = true;
            for (int i = 0; i < elemCount; i++)
            {
                item = new ToolStripMenuItem();
                switch (i)
                {
                    case 0:
                        item.Text = "Démarrer";
                        item.Name = "toolStripMenuItemStart";
                        this.start = item;
                        break;
                    case 1:
                        item.Text = "Suspendre";
                        item.Name = "toolStripMenuItemStop";
                        this.stop = item;
                        break;
                    case 2:
                        item.Text = "Continuer";
                        item.Name = "toolStripMenuItemResume";
                        this.resume = item;
                        break;
                    default:
                        item.Text = "Something went wrong";
                        break;
                }
                for (int j = 0; j < elemCount; j++)
                {
                    ToolStripMenuItem element = new();
                    element.Tag = Production.alphabet[j];
                    element.Text = Production.alphabet[j].ToString();
                    element.Enabled = initialized;
                    element.Click += ToolStripMenuItem_Click;
                    item.DropDownItems.Add(element);
                }
                productionToolStripMenuItem.DropDownItems.Add(item);
                this.items.Add(item);
                initialized = false;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form? tmp = this.FindForm();
            if (tmp != null)
            {
                tmp.Close();
                tmp.Dispose();
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            if (btn.Tag != null)
            {
                string identifier = btn.Tag.ToString();
                if (this.prodLines.Prods != null)
                {
                    if (!this.prodLines.Prods.ContainsKey("prod" + identifier))
                    {
                        this.prodLines.CreateProd(identifier);
                        ProdlinesCreated?.Invoke(this, new EventArgs());
                    }
                    if (this.prodLines.Prods["prod" + identifier].CurrentState == Production.State.Initialized)
                    {
                        this.prodLines.Prods["prod" + btn.Tag.ToString()].StartProd();

                        //pour avec le timer sur l'IHM
                        //timer.Start();

                    }
                    else if (this.prodLines.Prods["prod" + identifier].CurrentState == Production.State.Started)
                    {
                        this.prodLines.Prods["prod" + identifier].Suspend();
                    }
                    else
                    {
                        this.prodLines.Prods["prod" + identifier].Continue();
                    }
                    ButtonEnabledOrNot();
                }
            }
            btn.Enabled = false;
        }

        private void UserControlMenu_ItemAddedInList(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ButtonEnabledOrNot()
        {
            foreach (Production prod in prodLines.Prods.Values)
            {
                foreach (ToolStripMenuItem btn in this.start.DropDownItems)
                {
                    if (btn.Tag.ToString() == prod.Type)
                    {
                        btn.Enabled = prod.CurrentState == Production.State.Stopped || prod.CurrentState == Production.State.Initialized;
                    }
                }
                foreach (ToolStripMenuItem btn in this.resume.DropDownItems)
                {
                    if (btn.Tag.ToString() == prod.Type)
                    {
                        btn.Enabled = prod.CurrentState == Production.State.Suspended;
                    }
                }
                foreach (ToolStripMenuItem btn in this.stop.DropDownItems)
                {
                    if (btn.Tag.ToString() == prod.Type)
                    {
                        btn.Enabled = prod.CurrentState == Production.State.Started;
                    }
                }
            }
        }
    }
}
