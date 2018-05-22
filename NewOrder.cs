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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        public void Send(string l, string p)
        {
            double per = 100.0 / (Convert.ToDouble(txtbxCost.Text) / Convert.ToDouble(txtbxHowMuch.Text));
            string t = txtbxEmailSup.Text;
            MailAddress from = new MailAddress(l);// отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress to = new MailAddress(t);// кому отправляем
            MailMessage m = new MailMessage(from, to);// создаем объект сообщения
            m.Subject = "Заказ";// тема письма
            m.Body = txtbxEmailText.Text;// текст письма
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //функция сверху коммента нужна для того, с какой почты отправляется сообщение
            //разница в SMTP-сервере и порте
            //параметры при создании нового объекта надо менять, если почта, с которой отсылается сообщение, изменилась на майл или яндекс или т.п.
            smtp.Credentials = new NetworkCredential(l, p);// логин и пароль добавляются как параметры
            smtp.EnableSsl = true;//шифрование соединения
            try
            {
                smtp.Send(m);
                d.Rows.Add(cmbxSupl.Text, txtbxStuff.Text, txtbxAmount.Text + " " + txtbxEdIzm.Text, dtpDateOfApp.Text, "Заявка принята", DateTime.Today.ToString(),
                    Convert.ToString(per), cmbxCeh.SelectedItem);//для добавления в таблицу на главном окне
                MessageBox.Show("Сообщение успешно отправлено", "Успех");
            }
            catch (SmtpException)
            {
                MessageBox.Show("Произошла ошибка отправки, проверьте правильность введенного логина и пароля", "Ошибка!");
            }
        }
    }
}
