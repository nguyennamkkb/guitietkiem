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
    public class BUS_Sotk
    {
        DAL_Sotk tk = new DAL_Sotk();
        public void Insert(DTO_Sotk s)
        {
            tk.Insert(s);
        }
        public void Update(DTO_Sotk s)
        {
            tk.Update(s);
        }
        public void Delete(DTO_Sotk s)
        {
            tk.Delete(s);
        }

        public DataTable Load2(string sql)
        {
            return tk.Load1(sql);
        }
    }
}
