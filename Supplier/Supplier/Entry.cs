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
        public Entry()
        {
            InitializeComponent();
        }

        
        private void btnGuest_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            m.SetGuest(true);
            Hide();
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            Main m = new Main();

            m.SetGuest(false);
            m.SetLogin(txtbxLogin.Text, txtbxPass.Text);
            m.Show();
            Hide();
        }

        private void txtbxLogin_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = (txtbxLogin.Text.Length > 0 && txtbxPass.Text.Length > 0);
        }
    }
}
