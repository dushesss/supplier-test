using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Supplier
{
    public partial class Main : Form
    {
        DBInf inf = new DBInf();
        BindingList<ObjInf> info;
        bool ParamVhod = false;
        string log, pas;
        public Main()
        {
            InitializeComponent();
            btnAddApp.Enabled = false;
            btnDelete.Enabled = false;
            info = inf.Open("Info");
            dgvSupl.DataSource = info;
            Rename(); 
        }
        public Main(bool a)
        {
            ParamVhod = a;
            InitializeComponent();
            info = inf.Open("Info");
            dgvSupl.DataSource = info;
            Rename();
        }
        private void Rename()
        {
            dgvSupl.Columns["ID"].HeaderText = "ID";
            dgvSupl.Columns["NamePost"].HeaderText = "Поставщик";
            dgvSupl.Columns["NumZak"].HeaderText = "№ заказа";
            dgvSupl.Columns["State"].HeaderText = "Статус";
            dgvSupl.Columns["Date"].HeaderText = "Дата";
            dgvSupl.Columns["Cex"].HeaderText = "Цех";
            dgvSupl.Columns["Price"].HeaderText = "Цена";
            dgvSupl.Columns["OplCen"].HeaderText = "Оплачено";
        }
        public void EmStore(string l, string p)
        {
            log = l;
            pas = p;
        }
        private void btnAddApp_Click(object sender, System.EventArgs e)
        {
            NewOrder order = new NewOrder();
            order.ShowDialog();
            order.EmStore(log, pas);
            Restart();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                int a = dgvSupl.CurrentRow.Index;
                int id = (int)dgvSupl.Rows[a].Cells["ID"].Value;
                string sqlInfo = string.Format("Delete from Info where ID = '{0}'", id);
                string sqlZakaz = string.Format("Delete from Zakaz where ID = '{0}'", id);
                inf.Delite(sqlInfo, id);
                inf.Delite(sqlZakaz, id);
                Restart();
            }
            catch
            {
                MessageBox.Show("ошибка удаления");
            }
        }

        private void txtbxSearch_TextChanged(object sender, System.EventArgs e)
        {
            Restart();
        }

        private void Restart()
        {
            string search = txtbxSearch.Text;
            string CexPer = Cex();
            info.Clear();
            info = inf.Open("Info", search, CexPer);
            dgvSupl.DataSource = info;
        }

        private string Cex()
        {
            string CexPer = " ";
            if (cbCex1.Checked)
                CexPer += cbCex1.Text+" ";
            if (cbCex2.Checked)
                CexPer += cbCex2.Text + " ";
            if (cbCex3.Checked)
                CexPer += cbCex3.Text + " ";

            return CexPer;
        }

        private void btnAddNSup_Click(object sender, EventArgs e)
        {
            NewSupplier supplier = new NewSupplier();

            supplier.ShowDialog();
            Restart();
        }

        private void dgvSupl_DoubleClick(object sender, EventArgs e)
        {
            int id = dgvSupl.CurrentRow.Index;
            InfoAboutOrder order;
            if (ParamVhod)
            {
                order = new InfoAboutOrder(info, id);
            }
            else
            {
                order = new InfoAboutOrder(info, id, ParamVhod);
            }
            order.ShowDialog();
            Restart();
        }


        private void cbCex1_CheckedChanged(object sender, EventArgs e)
        {
            Restart();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
