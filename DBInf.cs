using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supplier
{
    public class DBInf : DB<ObjInf>
    {
        protected override ObjInf Serialize(SqlDataReader reader)
        {
            int ID=(int)reader["ID"];
            string NamePost= reader["NamePost"].ToString();
            string NumZak = reader["NumZak"].ToString();
            string State= reader["State"].ToString();
            DateTime date= (DateTime)reader["Date"];
            string Cex= reader["Cex"].ToString();
            float Price= (float)(double)reader["Price"];
            float OplCen= (float)(double)reader["OplCen"];
            
            return new ObjInf(ID, NamePost, NumZak, State, date, Cex, Price, OplCen);
        }

        public BindingList<ObjInf> Open(string NameTable, string search, string searchCex)
        {
            BindingList<ObjInf> obj = new BindingList<ObjInf>();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sqlExpression = "SELECT * FROM " + NameTable;
                    using (SqlCommand command = new SqlCommand(sqlExpression, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ObjInf inf = Serialize(reader);
                                string searcInf = inf.Str();
                                if(searcInf.Contains(search) && searchCex.Contains(inf.Cex))
                                    obj.Add(inf);
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception err) //отлов всех ошибок
                {
                    MessageBox.Show(err.ToString());
                }
            }
            return obj;
        }
    
        public void AddDB(string sql, string NamePost, string NumZak,
        string State, DateTime date, string Cex, float Price, float OplCen)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {         
                    con.Open();
                    zap(sql, con, NamePost, NumZak, State, date,
                        Cex, Price, OplCen);
                }
                catch (Exception err) //отлов всех ошибок
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        protected void zap(string sql, SqlConnection con, string NamePost, string NumZak,
        string State, DateTime date, string Cex, float Price, float OplCen)
        {
            using (SqlCommand command = new SqlCommand(sql, con))
            {
                command.Parameters.AddWithValue("@NamePost", NamePost);
                command.Parameters.AddWithValue("@NumZak", NumZak);
                command.Parameters.AddWithValue("@State", State);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Cex", Cex);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@OplCen", OplCen);

                command.ExecuteNonQuery();
            }
        }
    }
}
