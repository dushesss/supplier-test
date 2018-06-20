using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Supplier
{
    public partial class NewOrder : Form
    {
        DBPost post = new DBPost();
        BindingList<ObjPost> postav;
        BindingList<ObjInf> inf;
        string l, p;
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
            try
            {
                SendEmail();
                AddSql();
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка данных");
            }
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
                      "( NamePost, NumZak, State, Date, Cex, Price, OplCen)" +
                      " Values(@NamePost, @NumZak, @State, @Date, @Cex, @Price, @OplCen)");
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
        public void EmStore(string log, string pas)
        {
            l = log;
            p = pas;
        }
        public void SendEmail()
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress(l);
            // кому отправляем
            MailAddress to = new MailAddress(txtbxEmailSup.Text);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Заказ";
            // текст письма
            m.Body = txtbxEmailText.Text;
            // письмо представляет код html
            // m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(l, p);
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(m);
                MessageBox.Show("Сообщение успешно отправлено", "Успех");
            }
            catch (SmtpException)
            {
                MessageBox.Show("Произошла ошибка отправки, проверьте правильность введенного логина и пароля", "Ошибка!");
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
