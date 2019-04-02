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
    public class BUS_Kyhan
    {
        DAL_Kyhan kh = new DAL_Kyhan();
        public void Insert(DTO_Kyhan s)
        {
            kh.Insert(s);
        }
        public void Update(DTO_Kyhan s)
        {
            kh.Update(s);
        }
        public void Delete(DTO_Kyhan s)
        {
            kh.Delete(s);
        }

        public DataTable Load2(string sql)
        {
            return kh.Load1(sql);
        }
    }
}
