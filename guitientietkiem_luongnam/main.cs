using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace guitientietkiem_luongnam
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form khachhang = new khachhang();
            khachhang.Show();
        }

        private void kyHanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kyhan = new kyhan();
            kyhan.Show();
        }

        private void soTietKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sotietkiem = new sotietkiem();
            sotietkiem.Show();
        }
    }
}
