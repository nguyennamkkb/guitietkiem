using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_Sotk:DBConnect
    {
        public DataTable Load1(string sql)
        {
            return Load(sql);

        }
        public void Insert(DTO_Sotk kh)
        {
            string sql = "insert into sotk values ('" + kh.Id_sotk + "','" + kh.Id_khachhang + "','" + kh.Id_kyhan + "','" + kh.Sotiengui + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(DTO_Sotk kh1)
        {
            string sql = "update sotk set id_kyhan='" + kh1.Id_kyhan + "',id_kh='" + kh1.Id_khachhang + "',sotiengui='" + kh1.Sotiengui + "' where id_stk='" + kh1.Id_sotk + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(DTO_Sotk kh2)
        {
            string sql = "delete from sotk where id_stk='" + kh2.Id_sotk + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
