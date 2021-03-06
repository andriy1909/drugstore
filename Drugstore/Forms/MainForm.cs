﻿using Drugstore.Dictionary;
using Drugstore.Journals;
using Drugstore.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class MainForm : Form
    {
        public int user = -1;
        public int posada = -1;
        public List<FormsList> forms;
        public UserControl currentForm;

        public MainForm()
        {
            InitializeComponent();
            forms = new List<FormsList>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AutorizationForm form = new AutorizationForm();
            form.ShowDialog();
            user = form.getUserId();
            posada = form.getPosada();
            menuStrip1.Visible = false;
            if(user!=-1)
            {
                menuStrip1.Visible = true;
                loginToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = true;
                if (posada==1)
                {
                    фінансиToolStripMenuItem.Visible = false;
                    складToolStripMenuItem.Visible = false;
                    довідникиToolStripMenuItem.Visible = false;
                    прайслистиToolStripMenuItem.Visible=false;
                    накладніПриходуToolStripMenuItem.Visible = false;
                    відпускТовараToolStripMenuItem.Visible = false;
                }
                else
                {
                    фінансиToolStripMenuItem.Visible = true;
                    складToolStripMenuItem.Visible = true;
                    довідникиToolStripMenuItem.Visible = true;
                    прайслистиToolStripMenuItem.Visible = true;
                    накладніПриходуToolStripMenuItem.Visible = true;
                    відпускТовараToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                loginToolStripMenuItem.Visible = true;
                logoutToolStripMenuItem.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizationForm form = new AutorizationForm();
            form.ShowDialog();
            user = form.getUserId();
            posada = form.getPosada();
            menuStrip1.Visible = false;
            if (user != -1)
            {
                menuStrip1.Visible = true;
                loginToolStripMenuItem.Visible = false;
                logoutToolStripMenuItem.Visible = true;
                if (posada == 1)
                {
                    фінансиToolStripMenuItem.Visible = false;
                    складToolStripMenuItem.Visible = false;
                    довідникиToolStripMenuItem.Visible = false;
                    прайслистиToolStripMenuItem.Visible = false;
                    накладніПриходуToolStripMenuItem.Visible = false;
                    відпускТовараToolStripMenuItem.Visible = false;
                }
                else
                {
                    фінансиToolStripMenuItem.Visible = true;
                    складToolStripMenuItem.Visible = true;
                    довідникиToolStripMenuItem.Visible = true;
                    прайслистиToolStripMenuItem.Visible = true;
                    накладніПриходуToolStripMenuItem.Visible = true;
                    відпускТовараToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                loginToolStripMenuItem.Visible = true;
                logoutToolStripMenuItem.Visible = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = -1;
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
            menuStrip1.Visible = false;
        }

        private void товариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Товари");
        }
        private void постачальникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Постачальники");
        }
        private void виробникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Виробники");
        }
        private void кодиПостачальниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("КодиПостачальників");
        }
        private void упаковкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Упаковки");
        }
        private void працівникиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openForm("Працівники");
        }

        private void покупціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Покупці");
        }
        private void роботаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnContext.Controls.Clear();
        }

        public void openForm(string title)
        {
            FormsList temp = forms.Find(f => f.title == title);
            if (temp == null)
            {
                UserControl form = null;
                switch (title)
                {
                    case "Товари":
                        form = new GoodsForm();
                        break;
                    case "Постачальники":
                        form = new ProvidersForm();
                        break;
                    case "Виробники":
                        form = new ProducersForm();
                        break;
                    case "КодиПостачальників":
                        form = new CodeSuppliersForm();
                        break;
                    case "Упаковки":
                        form = new PackingForm();
                        break;
                    case "Працівники":
                        form = new WorkersForm();
                        break;
                    case "Покупці":
                        form = new CustomersForm();
                        break;
                    case "Накладні прихода":
                        form = new JournalInvoiceInForm();
                        break;
                    case "Ревізія":
                        form = new JournalInvoiceInForm();
                        break;
                    case "Списання":
                        form = new JournalInvoiceInForm();
                        break;
                    case "Введення залишків":
                        form = new JournalInvoiceInForm();
                        break;
                    case "Відпуск товара":
                        form = new JournalInvoiceInForm();
                        break;
                    case "Продаж товарів":
                        form = new SellGoodsForm();
                        break;
                    default:
                        break;
                }
                form.Dock = DockStyle.Fill;
                form.Parent = pnContext;
                form.BringToFront();
                forms.Add(new FormsList() { form = form, title = title });
                currentForm = form;
                ToolStripMenuItem item=new ToolStripMenuItem();
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
                item.Text = title;
                item.Click += Item_Click;
                tsddAllWindows.DropDownItems.Add(item);
            }
            else
            {
                temp.form.BringToFront();
                currentForm = temp.form;
            }
            tslText.Text = title;
        }

        private void Item_Click(object sender, EventArgs e)
        {
            openForm(forms.Find(f => f.title == ((sender as ToolStripMenuItem).Text)).title);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                int index = forms.FindIndex(f => f.title == tslText.Text);
                pnContext.Controls.Remove(forms[index].form);
                forms.RemoveAt(index);
                if (index - 1 >= 0)
                {
                    currentForm = forms[index - 1].form;
                    currentForm.BringToFront();
                    tslText.Text = forms[index - 1].title;
                }
                else
                    if (forms.Count > 0)
                {
                    currentForm = forms[index].form;
                    currentForm.BringToFront();
                    tslText.Text = forms[index].title;
                }
                else
                {
                    currentForm = null;
                    tslText.Text = "";
                }
                tsddAllWindows.DropDownItems.Clear();
                foreach (FormsList item in forms)
                {
                    ToolStripMenuItem ts = new ToolStripMenuItem();
                    ts.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    ts.Text = item.title;
                    ts.Click += Item_Click;
                    tsddAllWindows.DropDownItems.Add(ts);
                }
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("test");
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                int index = forms.FindIndex(f => f.title == tslText.Text);
                if (index + 1 < forms.Count)
                {
                    currentForm = forms[index + 1].form;
                    currentForm.BringToFront();
                    tslText.Text = forms[index + 1].title;
                }
            }
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                int index = forms.FindIndex(f => f.title == tslText.Text);
                if (index - 1 >= 0)
                {
                    currentForm = forms[index - 1].form;
                    currentForm.BringToFront();
                    tslText.Text = forms[index - 1].title;
                }
            }
        }

        private void списанняТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Списання");
        }

        private void введенняЗалишківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Введення залишків");
        }

        private void ревізіяТоварівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Ревізія");
        }

        private void відпускТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Відпуск товара");
        }

        private void накладніПриходуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Накладні прихода");
        }

        private void робочеМісцеКасираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Продаж товарів");
        }

        private void tsddAllWindows_Click(object sender, EventArgs e)
        {

        }

        private void pnContext_Paint(object sender, PaintEventArgs e)
        {

        }


       
    }
}