using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class ConnectToSQL
    {
        private string source = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=TESTDB;Integrated Security=True";
        private string DataTable = @"DB_THREE";
        private Person a;

        public ConnectToSQL(string source, string dataTable, Person a)
        {
            this.Source = source;
            DataTable1 = dataTable;
            this.A = a;
        }
        public ConnectToSQL() { }
        public string Source { get => source; set => source = value; }
        public string DataTable1 { get => DataTable; set => DataTable = value; }
        public Person A { get => a; set => a = value; }
        public int SELECT(Person a)
        {
            int check = 0;
            using (SqlConnection connection = new SqlConnection(Source))
            {
                string query = "Select * from DB_THREE Where email = '" + a.Email + "' and password = '" + a.Password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable ds = new DataTable();
                sda.Fill(ds);
                DataRow newRow = ds.NewRow();
                if (ds.Rows.Count == 1)
                {
                    foreach (DataRow row in ds.Rows)
                    {
                        if(row[2].ToString() == "1")
                        {
                            check = 1;
                            return check;
                        }
                        if(row[2].ToString() == "2")
                        {
                            check = 2;
                            return check;
                        }
                    }


                }
            }
            return check;
        }
        public int REGISTER(Person input)
        {

            int check = 1;

            using (SqlConnection connection = new SqlConnection(Source))
            {
                if (input.Email != "" && input.Password != "")
                {
                    string query = "Select * from DB_THREE Where email = '" + input.Email + "' and password = '" + input.Password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                   
                    if (ds.Rows.Count == 1)
                    {
                        check = 0;
                        return check;
                    }
                    if (check == 1)
                    {
                        
                        connection.Open();
                        string sql = "INSERT INTO DB_THREE VALUES ('" + input.Email + "','" + input.Password + "'," + input.Id + ")";
                        // sql = "INSERT INTO DB_THREE
                        //VALUES('dasd', 'dasd', 2);
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        int v = (int)cmd.ExecuteNonQuery();
                        if (v > 0)
                        {
                            return check;
                        }
                        else
                        {
                            check = 0;
                            return check;

                        }
                    }
                }
            }
            return check;
        }
        public int CHANGE_PASSWORD(Person a)
        {
            int check = 0;
            using (SqlConnection connection = new SqlConnection(Source))
            {
                connection.Open();
                string query = "UPDATE DB_THREE SET password = ' " + a.Password + " ' WHERE email = '" + a.Email + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                int v = (int)cmd.ExecuteNonQuery();
                if (v > 0)
                {
                    check = 1;
                    return check;
                }
                else
                {
                    return check;
                }
            }
           
        }
        public DataTable CONNECTTABLE()
        {            
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Source))
            {
                connection.Open();
                string sql = "select * from DB_THREE";  
                SqlCommand com = new SqlCommand(sql, connection); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                da.Fill(dt);  // đổ dữ liệu vào kho
                connection.Close();  // đóng kết nối
                //dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            }
            return dt;
        }
        public  DataTable CONNECTTABLE_TK(int id)
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Source))
            {
                connection.Open();
                string sql = "select * from DB_THREE where id = " + id;
                SqlCommand com = new SqlCommand(sql, connection); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                da.Fill(dt);  // đổ dữ liệu vào kho
                connection.Close();  // đóng kết nối
                //dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            }
            return dt;
        }
        public DataTable CONNECTTABLE_TK_SEARCH(string search)
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Source))
            {
                connection.Open();
                string sql = "select * from DB_THREE where email like  '%" + search + "%'" ;
                SqlCommand com = new SqlCommand(sql, connection); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                da.Fill(dt);  // đổ dữ liệu vào kho
                connection.Close();  // đóng kết nối
                //dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            }
            return dt;
        }
    }
}
