using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Kyhan:DBConnect
    {
        public DataTable Load1(string sql)
        {
            return Load(sql);

        }
        public void Insert(DTO_Kyhan kh)
        {
            string sql = "insert into kyhan values ('" + kh.Id_kyhan + "','" + kh.Tenkyhan + "','" + kh.Ptlai + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(DTO_Kyhan kh1)
        {
            string sql = "update kyhan set kyhan='" + kh1.Tenkyhan + "',ptlai='" + kh1.Ptlai + "' where id='" + kh1.Id_kyhan + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(DTO_Kyhan kh2)
        {
            string sql = "delete from kyhan where id='" + kh2.Id_kyhan + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
