using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supplier
{
    public class OpenDB
    {
        List<zak> zakaz = new List<zak>();

        public List<zak> Open()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sqlExpression = "SELECT * FROM t1";
                    using (SqlCommand command = new SqlCommand(sqlExpression, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                zakaz.Add(Serializer(reader));
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception err) //отлов всех ошибок
                {
                    MessageBox.Show(err.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            return zakaz;
        }

        private zak Serializer(SqlDataReader read)
        {

            string post = (string)read["postav"];
            string zakaz = (string)read["zakaz"];
            int kol = (int)read["kol_vo"];
            string date_zak = ((DateTime)read["date_zak"]).ToString();//время!!!
            string state = (string)read["state"];//////////////////////время!!!
            string date_new_stat = ((DateTime)read["date_new_zak"]).Date.ToString();//время!
            float proc_opl = (float)(double)read["proc_opl"];
            string c = (string)read["cex"];

            return new zak(post, zakaz, kol, date_zak, state, date_new_stat, proc_opl, c);
        }

        public void AddDB(string post, string zakaz, int kol, string date_zak, string state,
            string date_new_stat, float proc_opl, string c)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sql = string.Format("INSERT INTO t1" +
                      "(postav, zakaz, kol_vo, date_zak, state, date_new_zak, proc_opl, cex)" +
                      " Values(@postav ,@zakaz, @kol_vo, @date_zak, @state, @date_new_zak, @proc_opl, @cex)");
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.Parameters.AddWithValue("@postav", post);
                        command.Parameters.AddWithValue("@zakaz", zakaz);
                        command.Parameters.AddWithValue("@kol_vo", kol);
                        command.Parameters.AddWithValue("@date_zak", Convert.ToDateTime(date_zak));
                        command.Parameters.AddWithValue("@state", state);
                        command.Parameters.AddWithValue("@date_new_zak", Convert.ToDateTime(date_new_stat));
                        command.Parameters.AddWithValue("@proc_opl", proc_opl);
                        command.Parameters.AddWithValue("@cex", c);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception err) //отлов всех ошибок
                {
                    MessageBox.Show(err.ToString());
                }
                finally
                {
                    con.Close();
                }

            }
        }
    }
}

