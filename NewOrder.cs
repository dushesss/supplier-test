using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Supplier
{
    public partial class NewOrder : Form
    {
        BindingList<zak> zakaz;
        OpenDB open = new OpenDB();
        int id;

        public NewOrder()
        {
            InitializeComponent();   
        }

        public NewOrder(BindingList<zak> zakaz, int id)
        {
            InitializeComponent();
            this.zakaz = zakaz;
            this.id = id;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            AddSql();
            Close();
        }


        private void AddSql()
        {
            id++;
            open.AddDB(cmbxSupl.Text, txtbxEmailText.Text, Convert.ToInt32(txtbxAmount.Text), dtpDateOfApp.Text, "статус", dtpDateOfApp.Text, (float)Convert.ToDouble(txtbxHowMuch.Text), cmbxCeh.Text);
            
        }

        private void lblStuff_Click(object sender, EventArgs e)
        {

        }
    }
}
