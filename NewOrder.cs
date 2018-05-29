using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Supplier
{
    public partial class NewOrder : Form
    {
        List<zak> zakaz;
        public NewOrder(List<zak> zakaz)
        {
            InitializeComponent();
            this.zakaz = zakaz;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            AddSql();
            Close();
        }

        public List<zak> Zaks()
        {
            return zakaz;
        }

        private void AddSql()
        {
            OpenDB open = new OpenDB();
            open.AddDB(cmbxSupl.Text, txtbxEmailText.Text, Convert.ToInt32(txtbxAmount.Text), dtpDateOfApp.Text, "статус", dtpDateOfApp.Text, (float)Convert.ToDouble(txtbxHowMuch.Text), cmbxCeh.Text);
            zakaz.Add(new zak(cmbxSupl.Text, txtbxEmailText.Text, Convert.ToInt32(txtbxAmount.Text), dtpDateOfApp.Text, "статус", dtpDateOfApp.Text, (float)Convert.ToDouble(txtbxHowMuch.Text), cmbxCeh.Text));
        }
    }
}
