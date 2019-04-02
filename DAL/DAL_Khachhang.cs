using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_Khachhang:DBConnect
    {
        public DataTable Load1(string sql)
        {
            return Load(sql);

        }
        public void Insert(DTOKhachHang kh)
        {
            string sql = "insert into khachhang values ('" + kh.Id_kh + "','" + kh.Tenkh + "','" + kh.Cccd + "','" + kh.Ngaysinh + "','" + kh.Diachi + "','" + kh.Sodienthoai + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Update(DTOKhachHang kh1)
        {
            string sql = "update khachhang set name='" + kh1.Tenkh + "',cccd='" + kh1.Cccd + "',ngaysinh='" + kh1.Ngaysinh + "',diachi='" + kh1.Diachi + "' ,sodienthoai='" + kh1.Sodienthoai + "' where id='" + kh1.Id_kh + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
        public void Delete(DTOKhachHang kh2)
        {
            string sql = "delete from khachhang where id='" + kh2.Id_kh + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Update(dt);
            dt.AcceptChanges();
        }
    }
}
