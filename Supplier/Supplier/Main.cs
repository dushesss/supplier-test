using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Supplier
{
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
            if (File.Exists("Data.xml")) // если существует данный файл
            {
                string a;
                DataSet ds = new DataSet(); // создаем новый пустой кэш данных
                ds.ReadXml("Data.xml"); // записываем в него XML-данные из файла
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow item in ds.Tables["Supply"].Rows)
                    {
                        int n = dgvSupl.Rows.Add(); // добавляем новую сроку в dgv
                        dgvSupl.Rows[n].Cells[0].Value = item["Поставщик"]; // заносим в первый столбец созданной строки данные из первого столбца таблицы ds.
                        dgvSupl.Rows[n].Cells[1].Value = item["Заказ"];
                        dgvSupl.Rows[n].Cells[2].Value = item["Количество"];
                        dgvSupl.Rows[n].Cells[3].Value = item["День заказа"];
                        dgvSupl.Rows[n].Cells[4].Value = item["Статус"];
                        dgvSupl.Rows[n].Cells[5].Value = item["Дата нового статуса"];
                        dgvSupl.Rows[n].Cells[6].Value = item["Процент оплаченного"];
                        dgvSupl.Rows[n].Cells[7].Value = item["Цех"];
                        a = dgvSupl.Rows[n].Cells[4].Value.ToString();
                        switch (a)
                        {
                            case "Заявка принята":
                                dgvSupl.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            case "Ожидается":
                                dgvSupl.Rows[n].DefaultCellStyle.BackColor = Color.Yellow;
                                break;
                            case "На складе":
                                dgvSupl.Rows[n].DefaultCellStyle.BackColor = Color.Green;
                                break;
                            default:
                                dgvSupl.Rows[n].DefaultCellStyle.BackColor = Color.White;
                                break;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("XML файл не найден.", "Ошибка.");
            }
        }
        string l;
        string p;
        bool ok;
        private void btnAddNSup_Click(object sender, EventArgs e)
        {
            NewSup n = new NewSup();
            n.Show();
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            Zayavka z = new Zayavka();
            z.SetLogin(l,p);
            z.SetGuest(ok);
            z.SetDGV(dgvSupl);
            z.Show();
                
        }
        public void SetGuest(bool ok)
        {
            this.ok = ok;
        }

        public void SetLogin(string log, string pass)
        {
            l = log;
            p = pass;
        }
        private void dgvSupl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSupl.SelectedCells.Count != 0)
            {
                int a = dgvSupl.CurrentRow.Index;
                Info i = new Info();
                i.SetStart(dgvSupl[0, a].Value.ToString(), dgvSupl[1, a].Value.ToString(), dgvSupl[2, a].Value.ToString(),
                            dgvSupl[3, a].Value.ToString(), dgvSupl[4, a].Value.ToString(), a);
                i.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgvSupl.RowCount; i++)
            {
                for (int j = 0; j < dgvSupl.ColumnCount; j++)
                    if (dgvSupl.Rows[i].Cells[j].Value != null)
                        if (dgvSupl.Rows[i].Cells[j].Value.ToString().Contains(txtbxSearch.Text)
                            || dgvSupl.Rows[i].Cells[7].Value.ToString().Contains(chlbxCeh.SelectedItems.ToString()))
                        {
                            dgvSupl.Rows[i].Visible = true;
                            break;
                        }
                        else
                        {
                            dgvSupl.Rows[i].Visible = false;
                        }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet(); // создаем пока что пустой кэш данных
            DataTable dt = new DataTable(); // создаем пока что пустую таблицу данных
            dt.TableName = "Supply"; // название таблицы
            dt.Columns.Add("Поставщик"); // название колонок
            dt.Columns.Add("Заказ");
            dt.Columns.Add("Количество");
            dt.Columns.Add("День заказа");
            dt.Columns.Add("Статус");
            dt.Columns.Add("Дата нового статуса");
            dt.Columns.Add("Процент оплаченного");
            dt.Columns.Add("Цех");
            ds.Tables.Add(dt); //в ds создается таблица

            foreach (DataGridViewRow r in dgvSupl.Rows) // пока в dgv есть строки
            {
                DataRow row = ds.Tables["Supply"].NewRow(); // создаем новую строку в таблице, занесенной в ds
                row["Поставщик"] = r.Cells[0].Value;  //в столбец этой строки заносим данные из первого столбца dgv
                row["Заказ"] = r.Cells[1].Value;
                row["Количество"] = r.Cells[2].Value;
                row["День заказа"] = r.Cells[3].Value;
                row["Статус"] = r.Cells[4].Value;
                row["Дата нового статуса"] = r.Cells[5].Value;
                row["Процент оплаченного"] = r.Cells[6].Value;
                row["Цех"] = r.Cells[7].Value;
                ds.Tables["Supply"].Rows.Add(row); //добавление всей этой строки в таблицу ds.
            }
            ds.WriteXml("Data.xml");
            MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < dgvSupl.RowCount; n++)
            {
                string a = dgvSupl.Rows[n].Cells[4].Value.ToString();
                dgvSupl.Rows[n].Cells[5].Value = DateTime.Today;
                switch (a)
                {
                    case "Заявка принята":
                        dgvSupl.Rows[n].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    case "Ожидается":
                        dgvSupl.Rows[n].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case "На складе":
                        dgvSupl.Rows[n].DefaultCellStyle.BackColor = Color.Green;
                        break;
                    default:
                        dgvSupl.Rows[n].DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }
    }
}
