using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Supplier
{
    public partial class NewOrder : Form
    {
        DBPost post = new DBPost();
        BindingList<ObjPost> postav;
        BindingList<ObjInf> inf;

        public NewOrder()
        {
            InitializeComponent();
            postav = post.Open("Postav");
            DownloadPost();
        }

        public NewOrder(BindingList<ObjInf> Inf)
        { 
            InitializeComponent();
            postav = post.Open("Postav");
            DownloadPost();
            inf = Inf;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            AddSql();
            Close();
        }

        private void AddSql()
        {
            DBInf inf = new DBInf();
            DBZak zak = new DBZak();
            Random rand = new Random();
            

            string NamePost= cmbxSupl.SelectedItem.ToString();
            string NumZak = rand.Next().ToString();
            string State="ожидается";
            DateTime date= dtpDateOfApp.Value;
            string Text= txtbxEmailText.Text.ToString();
            float Price=0;
            float OplCen=0;
            string NameTov = txtbxStuff.Text;
            int Kvo = Convert.ToInt32(txtbxAmount.Text);
            string Ed = txtbxEdIzm.Text;
            string Cex = cmbxCeh.Text;

            string sql = string.Format("INSERT INTO Info" +
                      "( NamePost, NumZak, State, date, Cex, Price, OplCen)" +
                      " Values(@NamePost, @NumZak, @State, @date, @Cex, @Price, @OplCen)");
            string sqlZak = string.Format("INSERT INTO Zakaz" +
                      "( NameTov, NumZak, Kvo, Ed, Text)" +
                      " Values(@NameTov, @NumZak, @Kvo, @Ed, @Text)");

            zak.AddDB(sqlZak, NameTov, NumZak, Kvo, Ed, Text);
            inf.AddDB(sql, NamePost, NumZak, State, date, Cex, Price, OplCen);
        }

        private void DownloadPost()
        {
            foreach (ObjPost e in postav)
            {
                cmbxSupl.Items.Add(e.NamePost);
            }
        }

        private void cmbxSupl_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ObjPost e1 in postav)
            {
                if (cmbxSupl.Text == e1.NamePost)
                {
                    txtbxEmailSup.Text = e1.EmailPost;
                }
            }
        }
    }
}
