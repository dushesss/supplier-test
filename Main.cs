using System.Collections.Generic;
using System.Windows.Forms;

namespace Supplier
{
    public partial class Main : Form
    {
        OpenDB open = new OpenDB();
        List<zak> zakaz = new List<zak>();

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
            NewOrder order = new NewOrder(zakaz);
            MessageBox.Show(zakaz.Count.ToString());
            order.ShowDialog();

            MessageBox.Show(zakaz.Count.ToString());
        }

        private void dgvSupl_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            zakaz = open.Open();
            
        }
    }
}
