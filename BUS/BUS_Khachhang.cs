using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace BUS
{
    public class BUS_Khachhang
    {
        DAL_Khachhang kh= new DAL_Khachhang();
        public void Insert(DTOKhachHang s)
        {
            kh.Insert(s);
        }
        public void Update(DTOKhachHang s)
        {
            kh.Update(s);
        }
        public void Delete(DTOKhachHang s)
        {
            kh.Delete(s);
        }
       
        public DataTable Load2(string sql)
        {
            return kh.Load1(sql);
        }
    }

}
