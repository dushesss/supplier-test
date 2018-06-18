using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supplier
{
    public class DBZak : DB<ObjZak>
    {
        protected override ObjZak Serialize(SqlDataReader reader)
        {
            int ID=(int)reader["ID"];
            string NameTov= reader["NameTov"].ToString();
            string NumZak = reader["NumZak"].ToString();
            float Kvo= (float)(double)reader["Kvo"];
            string Ed= reader["Ed"].ToString();
            string Text = reader["Text"].ToString();

            return new ObjZak(ID,NameTov,NumZak,Kvo,Ed, Text);
        }

        public void AddDB(string sql, string NameTov, string NumZak,int Kvo, string Ed, string Text)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    zap(sql, con, NameTov, NumZak, Kvo, Ed, Text);
                }
                catch (Exception err) //отлов всех ошибок
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        protected void zap(string sql, SqlConnection con, string NameTov,
            string NumZak, int Kvo, string Ed, string Text)
        {
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@NameTov", NameTov);
                command.Parameters.AddWithValue("@NumZak", NumZak);
                command.Parameters.AddWithValue("@Kvo", Kvo);
                command.Parameters.AddWithValue("@Ed", Ed);
                command.Parameters.AddWithValue("@Text", Text);

                command.ExecuteNonQuery();
            }
        }
    }
}
