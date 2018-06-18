using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supplier
{
    public class DB<T>// общий метод подключения
    {
        public virtual BindingList<T> Open(string NameTable)
        {
            BindingList<T> obj = new BindingList<T>();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sqlExpression = "SELECT * FROM "+ NameTable;
                    using (SqlCommand command = new SqlCommand(sqlExpression, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                obj.Add(Serialize(reader));
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

        protected virtual T Serialize(SqlDataReader reader)
        {
            return default(T);
        }

        public virtual void Delite(string sql, int id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception err) //отлов всех ошибок
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }
    }
}
