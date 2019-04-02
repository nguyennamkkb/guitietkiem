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
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }
        BUS_Khachhang kh = new BUS_Khachhang();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            string sql = "select * from khachhang";
            dataGridView1.DataSource = kh.Load2(sql);
            txtcccd.Text = "";
            txtname.Text = "";
            txtdiachi.Text = "";
            txtid.Text = "";
            txtns.Text = "";
            txtsdt.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bnt_them_Click(object sender, EventArgs e)
        {
            DTOKhachHang khang = new DTOKhachHang(txtid.Text,txtname.Text,txtcccd.Text,txtns.Text,txtdiachi.Text,txtsdt.Text);
            kh.Insert(khang);
            khachhang_Load(sender, e);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DTOKhachHang khang = new DTOKhachHang(txtid.Text, txtname.Text, txtcccd.Text, txtns.Text, txtdiachi.Text, txtsdt.Text);
            kh.Update(khang);
            khachhang_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DTOKhachHang khang = new DTOKhachHang(txtid.Text, txtname.Text, txtcccd.Text, txtns.Text, txtdiachi.Text, txtsdt.Text);
            kh.Delete(khang);
            khachhang_Load(sender, e);
        }

        private void dt(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtid.Text =dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtname.Text =dataGridView1.Rows[i].Cells[1].Value.ToString() ;
            txtcccd.Text =  dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtns.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            
        }
    }
}
