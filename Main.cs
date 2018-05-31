using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Supplier
{
    public partial class Main : Form
    {
        OpenDB open = new OpenDB();
        BindingList<zak> zakaz = new BindingList<zak>();
        

        public Main()
        {
            InitializeComponent();
            AddStolb();
            zakaz = open.Open();
            dgvSupl.DataSource = zakaz;
        }

        public void AddStolb()
        {
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "id"
            });
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "post",
                HeaderText = "поставщик"
            });
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "zakaz",
                HeaderText = "заказ"
            });
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "kol",
                HeaderText = "кол-во"
            });
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "date_zak",
                HeaderText = "день заказа"
            });
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "state",
                HeaderText = "статус"
            });
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "date_new_stat",
                HeaderText = "дата нового статуса"
            });
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "proc_opl",
                HeaderText = "процент оплаченного"
            });
            dgvSupl.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "c",
                HeaderText = "цеха"
            });
        }

        private void btnAddApp_Click(object sender, System.EventArgs e)
        {
            NewOrder order = new NewOrder(zakaz, (int)(dgvSupl.Rows[dgvSupl.Rows.Count-1].Cells[0].Value));
            order.ShowDialog();
            zakaz.Clear();
            zakaz = open.Open();
        }



        private void dgvSupl_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dgvSupl.CurrentRow != null)
            {
                int a = dgvSupl.CurrentRow.Index;
                open.DeleteDB((int)(dgvSupl.Rows[a].Cells[0].Value));
                zakaz.Clear();
                zakaz = open.Open();
            }
        }

        private void txtbxSearch_TextChanged(object sender, System.EventArgs e)
        {
            zakaz.Clear();
            zakaz = open.SearchDB(txtbxSearch.Text);
        }
    }
}
