using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab301
{
    class Database
    {
        private SqlConnection con;
        public Database()
        {
            String str = "server=DESKTOP-EHOD9B9\\SQLEXPRESS;database=lab;UID=sa;password=Lenovo";
            SqlConnection con = new SqlConnection(str);
            this.con = con;
        }

        public bool Insert(string table, Dictionary<string,string> data)
        {
            StringBuilder columns=new StringBuilder();
            StringBuilder values = new StringBuilder();
            

            foreach( var column in data.Keys)
            {
                columns = columns.Append(column);
                values = values.Append("@" + column);

                if (!(column == data.Last().Key))
                {
                    columns = columns.Append(",");
                    values = values.Append(",");
                }
            }

            string query = String.Format("INSERT INTO " + table + " ({0}) VALUES ({1})", columns, values);

            MessageBox.Show(query);

            using (con)
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                foreach(var datum in data)
                {
                    command.Parameters.AddWithValue("@" + datum.Key, datum.Value);
                }
             

                try {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data is saved");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
            return true;
           
        }

        public bool Update(string table, Dictionary<string, string> data,int id)
        {
          
            StringBuilder values = new StringBuilder();


            foreach (var column in data.Keys)
            {
              
                values = values.Append(column+" =@" + column);

                if (!(column == data.Last().Key))
                {
                    values = values.Append(",");
                }
            }

            string query = String.Format("UPDATE " + table + " SET {0} WHERE id=@id", values);

            MessageBox.Show(query);

            using (con)
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                foreach (var datum in data)
                {
                    command.Parameters.AddWithValue("@" + datum.Key, datum.Value);
                }
                command.Parameters.AddWithValue("@id", id);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data is updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
            return true;

        }

        public DataTable Select(string table, string columns,string where)
        {

            StringBuilder values = new StringBuilder();
            DataTable dt = new DataTable();

            string query = String.Format("SELECT {0} FROM {1} WHERE {2}", columns,table,where);

            MessageBox.Show(query);

            using (con)
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

              

                try
                {
                    dt.Load(command.ExecuteReader());
                    MessageBox.Show(dt.Rows[0]["id"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                finally
                {
                    con.Close();
                }

                return dt;
            }
        }

        public DataTable Select(string table)
        {

            StringBuilder values = new StringBuilder();
            DataTable dt = new DataTable();

            string query = String.Format("SELECT * FROM {0}",table);

            MessageBox.Show(query);

            using (con)
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                try
                {
                    dt.Load(command.ExecuteReader());
                    MessageBox.Show("Select");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }

                return dt;
            }
        }

        public bool Delete(string table,int id)
        {

            StringBuilder values = new StringBuilder();
            DataTable dt = new DataTable();

            string query = String.Format("DELETE FROM {0} WHERE id=@id", table);

            MessageBox.Show(query);

            using (con)
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    command.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }


                return true;
            }
        }

    }


}
