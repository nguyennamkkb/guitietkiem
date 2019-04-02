using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_Kyhan
    {
        string id_kyhan;
        string tenkyhan;
        float ptlai;
        

        public string Id_kyhan
        {
            get { return id_kyhan; }
            set { id_kyhan = value; }
        }
        public string Tenkyhan
        {
            get { return tenkyhan; }
            set { tenkyhan = value; }
        }
        public float Ptlai
        {
            get { return ptlai; }
            set { ptlai = value; }
        }
        
       
        public DTO_Kyhan() { }
        public DTO_Kyhan(string id_kyhan, string tenkyhan, float ptlai)
        {
            this.Id_kyhan = id_kyhan;
            this.Tenkyhan = tenkyhan;
            this.Ptlai = ptlai;
           
        }
    }
}



