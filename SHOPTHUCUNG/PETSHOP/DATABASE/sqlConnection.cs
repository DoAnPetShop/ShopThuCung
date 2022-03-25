using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATABASE
{
    public class sqlConnection
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public void CreateConnection(string sql)
        {
            con = new SqlConnection(sql);
        }
        public bool TestConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }
        public DataTable ExcuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public int ThemXoaSua(String sql)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                cmd = new SqlCommand(sql, con);
                int kq = cmd.ExecuteNonQuery();
                con.Close();
                return kq;
            }
            catch (SqlException e)
            {
                return -1;
            }
        }
        public int TaiKhoan(String sql)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                cmd = new SqlCommand(sql, con);
                int kq = (int)cmd.ExecuteScalar();
                con.Close();
                return kq;
            }
            catch (SqlException e)
            {
                return -1;
            }

        }
    }
}
