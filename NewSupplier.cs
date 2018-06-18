using System;
using System.Text.RegularExpressions;
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

        private void txtbxEmailSup_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!ValidEmailAddress(txtbxEmailSup.Text))
            {
                e.Cancel = true;
                txtbxEmailSup.Select(0, txtbxEmailSup.Text.Length);
            }
        }

        private bool ValidEmailAddress(string email)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, regexPattern);
        }
    }
}
