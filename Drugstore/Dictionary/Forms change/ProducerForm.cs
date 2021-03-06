﻿using System;
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
    public partial class ProducerForm : Form
    {
        bool addEdit; //true-додавання; false-редагування
        int id;

        public ProducerForm()
        {
            InitializeComponent();
            addEdit = true;
        }

        public ProducerForm(int id)
        {
            InitializeComponent();
            Producers producers = new Producers();
            producers.getDataItem(id);
            this.id = id;
            tbName.Text = producers.name;

            addEdit = false;
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            Producers producers = new Producers();
            producers.id = id;
            producers.name = tbName.Text;
            if (addEdit)
                producers.insertItem();
            else
                producers.updateItem();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
