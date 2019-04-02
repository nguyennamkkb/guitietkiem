using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _cn = new SqlConnection(@"Data Source=DESKTOP-U8PH5FK\SQLEXPRESS;Initial Catalog=guitientk;Integrated Security=True");
        public DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand comSelect = new SqlCommand(sql, _cn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comSelect;
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
            return dt;
        }
    }
}
