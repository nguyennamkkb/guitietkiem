using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTOKhachHang
    {
        string id_kh;
        string tenkh;
        string cccd;
        string ngaysinh;
        string diachi;
        string sodienthoai;

        public string Id_kh
        {
            get { return id_kh; }
            set { id_kh = value; }
        }
        public string Tenkh
        {
            get { return tenkh; }
            set { tenkh = value; }
        }
        public string Cccd
        {
            get { return cccd; }
            set { cccd = value; }
        }
        
        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Sodienthoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        } 
        public DTOKhachHang() { }
        public DTOKhachHang(string id_kh, string tenkh, string cccd, string ngaysinh, string diachi, string sodienthoai)
        {
            this.Id_kh = id_kh;
            this.Tenkh = tenkh;
            this.Cccd = cccd;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Sodienthoai = sodienthoai;

        }
    }
}



 