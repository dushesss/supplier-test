using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supplier
{
    public partial class Entry : Form
    {
        bool log=false;
        bool pas=false;

        public Entry()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main m = new Main();
            m.ShowDialog();
            this.Visible = true;
            log = false;
            pas = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (log && pas) {
                
                this.Visible = false;
                Main m = new Main(log);
                m.ShowDialog();
                this.Visible = true;
                this.Visible = true;
                log = false;
                pas = false;
            }
            else
            {
                MessageBox.Show("Не правильно указан логин или пароль");
            }
        }

        private void txtbxLogin_TextChanged(object sender, EventArgs e)
        {
            log = true;
        }

        private void txtbxPass_TextChanged(object sender, EventArgs e)
        {
            pas = true;
        }

        private void txtbxLogin_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidEmailAddress(txtbxLogin.Text))
            {
                e.Cancel = true;
                txtbxLogin.Select(0, txtbxLogin.Text.Length);
            }
        }

        private bool ValidEmailAddress(string email)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, regexPattern);
        }
    }
}
