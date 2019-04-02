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
using System.Data.SqlClient;

namespace guitientietkiem_luongnam
{
    public partial class sotietkiem : Form
    {
        BUS_Sotk tk = new BUS_Sotk();
        public sotietkiem()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            
        }

        private void sotietkiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guitientkDataSet1.kyhan' table. You can move, or remove it, as needed.
            this.kyhanTableAdapter.Fill(this.guitientkDataSet1.kyhan);
            // TODO: This line of code loads data into the 'guitientkDataSet.khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.guitientkDataSet.khachhang);
           
            string sql3 = "select * from sotk";
            dataGridView1.DataSource = tk.Load2(sql3);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DTO_Sotk tkiem = new DTO_Sotk(txtmaso.Text, comboBox1.Text,comboBox2.Text, float.Parse(flsotiengui.Text));
            tk.Insert(tkiem);
            sotietkiem_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DTO_Sotk tkiem = new DTO_Sotk(txtmaso.Text, comboBox1.Text, comboBox2.Text, float.Parse(flsotiengui.Text));
            tk.Update(tkiem);
            sotietkiem_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DTO_Sotk tkiem = new DTO_Sotk(txtmaso.Text, comboBox1.Text, comboBox2.Text, float.Parse(flsotiengui.Text));
            tk.Delete(tkiem);
            sotietkiem_Load(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
