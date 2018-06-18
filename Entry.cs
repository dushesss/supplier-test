using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
