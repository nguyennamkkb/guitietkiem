using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace guitientietkiem_luongnam
{
    public partial class kyhan : Form
    {
        BUS_Kyhan kh = new BUS_Kyhan();
        public kyhan()
        {
            InitializeComponent();
        }

        private void kyhan_Load(object sender, EventArgs e)
        {
            string sql = "select * from kyhan";
            dataGridView1.DataSource = kh.Load2(sql);
            txtma.Text = "";
            txtkyhan.Text = "";
            fl_ptlai.Text = "";

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO_Kyhan khan = new DTO_Kyhan(txtma.Text, txtkyhan.Text,float.Parse(fl_ptlai.Text));
            kh.Insert(khan);
            kyhan_Load(sender, e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTO_Kyhan khan = new DTO_Kyhan(txtma.Text, txtkyhan.Text,float.Parse(fl_ptlai.Text));
            kh.Update(khan);
            kyhan_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTO_Kyhan khan = new DTO_Kyhan(txtma.Text, txtkyhan.Text,float.Parse(fl_ptlai.Text));
            kh.Delete(khan);
            kyhan_Load(sender, e);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dt(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtma.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtkyhan.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            fl_ptlai.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            
        }
        
    }
}
