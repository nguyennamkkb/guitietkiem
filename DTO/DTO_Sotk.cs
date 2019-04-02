using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_Sotk
    {
        string id_sotk;
        string id_khachhang;
        string id_kyhan;
        float sotiengui;
        

        public string Id_sotk
        {
            get { return id_sotk; }
            set { id_sotk = value; }
        }
        
        public string Id_khachhang
        {
            get { return id_khachhang; }
            set { id_khachhang = value; }
        }
        public string Id_kyhan
        {
            get { return id_kyhan; }
            set { id_kyhan = value; }
        }
        public float Sotiengui
        {
            get { return sotiengui; }
            set { sotiengui = value; }
        }
        
       
        public DTO_Sotk() { }
        public DTO_Sotk(string id_sotk, string id_khachhang, string id_kyhan, float sotiengui)
        {
            this.Id_sotk = id_sotk;
            this.Id_khachhang = id_khachhang;
            this.Id_kyhan = id_kyhan;
            this.Sotiengui = sotiengui;
           
        }
    }
}
