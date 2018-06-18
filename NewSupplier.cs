using System;
using System.Windows.Forms;

namespace Supplier
{
    public partial class NewSupplier : Form
    {
        public NewSupplier()
        {
            InitializeComponent();
        }

        private void btnAddSpl_Click(object sender, EventArgs e)
        {
            string Name = txtbxNSup.Text;
            string Email = txtbxEmailSup.Text;
            string Number = txtbxPhoneNumber.Text;

            DBPost db = new DBPost();

            db.AddDB(Name,Email,Number);

            MessageBox.Show("Добавление выполнено!");
            Close();
        }
    }
}
