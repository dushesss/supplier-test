using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Supplier
{
    public partial class InfoAboutOrder : Form
    {
        DBPost postav = new DBPost();
        DBZak zakaz = new DBZak();
        DBInf inf = new DBInf();

        BindingList<ObjInf> info;
        BindingList<ObjPost> post;
        BindingList<ObjZak> zak;
        int id, ID;
        int idZ;

        public InfoAboutOrder()
        {
            InitializeComponent();
        }
        public InfoAboutOrder(BindingList<ObjInf> Info, int Id, bool a)
        {
            info = Info;
            id = Id;

            InitializeComponent();

            Start();
            tbNumZak.Enabled = false;
            dtpDOfZ.Enabled = false;
            txtbxEdIzm.Enabled = false;
            cmbxStatus.Enabled = false;
            tbPrice.Enabled = false;
            txtbxPer.Enabled = false;
            txtbxCeh.Enabled = false;
            btnAccept.Enabled = false;
        }

        public InfoAboutOrder(BindingList<ObjInf> Info, int Id)
        {
            info = Info;
            id = Id;

            InitializeComponent();

            Start();
        }

        public void Start()
        {
            

            post = postav.Open("Postav");
            zak = zakaz.Open("Zakaz");

            foreach (ObjPost p in post)
            {
                if (info[id].NamePost == p.NamePost)
                {
                    txtbxSupl.Text = p.NamePost;
                    txtbxEmSpl.Text = p.EmailPost;
                    tbNum.Text = p.TelPost;
                    break;
                }
            }

            foreach (ObjZak p in zak)
            {
                if (p.NumZak == info[id].NumZak)
                {
                    idZ = p.ID;
                    tbNumZak.Text = p.NumZak.ToString();
                    txtbxAmount.Text = p.NameTov;
                    txtbxOrder.Text = p.Kvo.ToString();
                    txtbxEdIzm.Text = p.Ed;
                    txtbxTextEm.Text = p.Text;
                    break;
                }
            }

            ID = info[id].ID;
            cmbxStatus.Text = info[id].State;
            txtbxCeh.Text = info[id].Cex;
            dtpDOfZ.Value = info[id].date;
            tbPrice.Text = info[id].Price.ToString();
            txtbxPer.Text = info[id].OplCen.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            addInf();
            addZak();
            Close();
        }

        private void addInf()
        {
            string NamePost = txtbxSupl.Text;
            int NumZak = 0;
            if (tbNumZak.Text != "" && tbNumZak.Text != null)
            {
                NumZak = Convert.ToInt32(tbNumZak.Text);
            }
            string State = cmbxStatus.Text;
            DateTime date = dtpDOfZ.Value;
            string Cex = txtbxCeh.Text;
            float Price = (float)Convert.ToDouble(tbPrice.Text);
            float OplCen = (float)Convert.ToDouble(txtbxPer.Text);

            string sql = $"Update Info Set NamePost = '{NamePost}', NumZak='{NumZak}', State='{State}', date='{date}', Cex= '{Cex}', Price='{Price}', OplCen='{OplCen}'" +
                $"  Where ID = '{ID}'";

            inf.AddDB(sql, NamePost, NumZak, State, date, Cex, Price, OplCen);
        }

        private void addZak()
        {
            string NameTov = txtbxOrder.Text;
            int NumZak = 0;
            if (tbNumZak.Text != "" && tbNumZak.Text != null)
            {
                NumZak = Convert.ToInt32(tbNumZak.Text);
            }
            int Kvo = 0;
            if (txtbxAmount.Text != "" && txtbxAmount.Text != null)
            {
                Kvo = Convert.ToInt32(txtbxAmount.Text);
            }
            string Ed = txtbxEdIzm.Text;
            string Text = txtbxTextEm.Text;

            string sql = $"Update Zakaz Set NameTov = '{NameTov}', NumZak='{NumZak}', Kvo='{Kvo}', Ed= '{Ed}', Text='{Text}'" +
                $"  Where ID = '{idZ}'";

            zakaz.AddDB(sql, NameTov, NumZak, Kvo, Ed, Text);
        }
    }
}
