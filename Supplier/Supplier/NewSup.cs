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
    public partial class NewSup : Form
    {
        public NewSup()
        {
            InitializeComponent();
        }

        private void btnAddSpl_Click(object sender, EventArgs e)
        {
            StreamWriter strWrSup = File.AppendText("Sup.txt");
            StreamWriter strWrEm = File.AppendText("Em.txt");
            strWrSup.WriteLine(txtbxNSup.Text);
            strWrEm.WriteLine(txtbxEmailSup.Text);
            strWrSup.Close();
            strWrEm.Close();
            if (MessageBox.Show("Добавление прошло успешно", "Успех")==DialogResult.OK) this.Close();
        }
    }
}
