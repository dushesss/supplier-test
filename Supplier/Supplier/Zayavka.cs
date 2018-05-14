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
using System.Net.Mail;
using System.Net;

namespace Supplier
{
    public partial class Zayavka : Form
    {
        DataGridView d;
        int num;
        bool ok;
        StreamReader streamreader = new StreamReader("Sup.txt");
        String item;
        string l;
        string p;
        ToolTip t = new ToolTip();

        public Zayavka()
        {
            InitializeComponent();
            while ((item = streamreader.ReadLine()) != null)
            {
                cmbxSupl.Items.Add(item);
            }
            streamreader.Close();
            
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
        public void SetDGV(DataGridView d)
        {
            this.d = d;
        }
        //public int Num()
        //{
        //    return cmbxSupl.SelectedIndex+1;
        //}
        public void cmbxSupl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line = File.ReadLines("Em.txt").ElementAt(cmbxSupl.SelectedIndex);
            txtbxEmailSup.Text = line;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (!ok)
            {
                double per = 100.0/(Convert.ToDouble(txtbxCost.Text)/Convert.ToDouble(txtbxHowMuch.Text));
                string t = txtbxEmailSup.Text;
                //DataSet ds = new DataSet(); // создаем пока что пустой кэш данных
                //DataTable dt = new DataTable(); // создаем пока что пустую таблицу данных
                //dt.TableName = "EmText"; // название таблицы
                //dt.Columns.Add("Текст письма");
                //DataRow row = ds.Tables[ds.Tables.Count].NewRow(); // создаем новую строку в таблице, занесенной в ds
                //row[ds.Tables.Count] = txtbxEmailText.Text;
                //ds.WriteXml("EmText.xml");
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress(l);
                // кому отправляем
                MailAddress to = new MailAddress(t);
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
                    d.Rows.Add(cmbxSupl.Text, txtbxStuff.Text, txtbxAmount.Text + " " + txtbxEdIzm.Text, dtpDateOfApp.Text, "Заявка принята", DateTime.Today.ToString(),
                        Convert.ToString(per), cmbxCeh.SelectedItem);
                    MessageBox.Show("Сообщение успешно отправлено", "Успех");
                }
                catch (SmtpException)
                {
                    MessageBox.Show("Произошла ошибка отправки, проверьте правильность введенного логина и пароля", "Ошибка!");
                }
                
                Close();
            }
            else
            {
                //d.Rows.Add(cmbxSupl.Text, dtpDateOfApp.Text, "Заявка принята", mtxtbxHowMuch.Text, txtbxStuff.Text, cmbxCeh.SelectedItem);
                //strText.WriteLine(txtbxEmailText.Text);
                //strText.Close();
                if (MessageBox.Show("Вы вошли как гость, вы не можете отсылать сообщения!"
                    , "Ошибка") == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void txtbxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
