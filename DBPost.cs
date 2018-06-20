using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supplier
{
    public class DBPost : DB<ObjPost>
    {
        protected override ObjPost Serialize(SqlDataReader reader)
        {
            int ID=(int)reader["ID"];
            string NamePost= reader["NamePost"].ToString();
            string EmailPost= reader["EmailPost"].ToString();
            string TelPost= reader["NumPost"].ToString();

            return new ObjPost(ID,NamePost,EmailPost,TelPost);
        }

        public void AddDB(string NamePost, string EmailPost, string NumPost)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    string sql = string.Format("INSERT INTO Postav" +
                      "( NamePost, EmailPost, NumPost)" +
                      " Values(@NamePost, @EmailPost, @NumPost)");
                    con.Open();
                    zap(sql, con, NamePost, EmailPost, NumPost);
                }
                catch (Exception err) //отлов всех ошибок
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        protected void zap(string sql, SqlConnection con, string NamePost,
            string EmailPost, string NumPost)
        {
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@NamePost", NamePost);
                command.Parameters.AddWithValue("@EmailPost", EmailPost);
                command.Parameters.AddWithValue("@NumPost", NumPost);

                command.ExecuteNonQuery();
            }
        }
    }
}
