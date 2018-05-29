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
    public partial class Info : Form
    {
        DataGridView d;
        StreamReader strEmailTxt = new StreamReader("EmailText.txt");
        int num;
        public Info()
        {
            InitializeComponent();
        }
        //public string GetStringNum(string a)
        //{
        //    StreamReader streamreader = new StreamReader("Sup.txt");
        //    //if(streamreader.ToString(Contains(a)))
        //    //return File.ReadLines("Em.txt").ElementAt();
        //}
        public void SetDGV(DataGridView d)
        {
            this.d = d;
        }
        public void SetStart(string a1, string a2, string a3, string a4, string a5, int num)
        {
            //if (File.Exists("EmText.xml")) // если существует данный файл
            //{
            //    string a;
            //    DataSet ds = new DataSet(); // создаем новый пустой кэш данных
            //    ds.ReadXml("EmText.xml");
            //    if (ds.Tables.Count > 0)
            //    {
            //        foreach (DataRow item in ds.Tables["Supply"].Rows)
            //        {
            //            int n = ds.Tables.Rows.Add(); // добавляем новую сроку в dgv
            //            dgvSupl.Rows[n].Cells[0].Value = item["Поставщик"];
            //        }
            //}
            txtbxSupl.Text = a1;

            //txtbxEmSpl.Text = line;
            //txtbxTextEm.Text = File.ReadLines("EmailText.txt").ElementAt(z.Num());
            dtpDOfZ.Text = a2;
            cmbxStatus.Text = a3;
            txtbxPer.Text = a4;
            //btnSend.Text = "Сохранить изменения";
            //cmbxCatExp.Visible = true;
            //lblCatExp.Visible = true;
            this.num = num;
            //ed = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //d[4, num].Value = txtbxFIO.Text;
            //d[6, num].Value = dtpDOB.Text;
        }
    }
}
