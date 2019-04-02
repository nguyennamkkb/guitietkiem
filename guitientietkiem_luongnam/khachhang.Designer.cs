namespace guitientietkiem_luongnam
{
    partial class khachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.txtns = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bnt_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Căn cước công dân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(126, 16);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(54, 20);
            this.txtid.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(126, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(155, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtcccd
            // 
            this.txtcccd.Location = new System.Drawing.Point(126, 42);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(155, 20);
            this.txtcccd.TabIndex = 1;
            // 
            // txtns
            // 
            this.txtns.Location = new System.Drawing.Point(126, 97);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(155, 20);
            this.txtns.TabIndex = 1;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(126, 123);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(155, 20);
            this.txtdiachi.TabIndex = 1;
            this.txtdiachi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(126, 149);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(155, 20);
            this.txtsdt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 310);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt);
            // 
            // bnt_them
            // 
            this.bnt_them.BackColor = System.Drawing.Color.LightGreen;
            this.bnt_them.Location = new System.Drawing.Point(37, 196);
            this.bnt_them.Name = "bnt_them";
            this.bnt_them.Size = new System.Drawing.Size(75, 23);
            this.bnt_them.TabIndex = 3;
            this.bnt_them.Text = "Thêm  mới";
            this.bnt_them.UseVisualStyleBackColor = false;
            this.bnt_them.Click += new System.EventHandler(this.bnt_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_sua.Location = new System.Drawing.Point(148, 196);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.LightCoral;
            this.btn_xoa.Location = new System.Drawing.Point(37, 252);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(148, 251);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Đóng lại";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 345);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.bnt_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtns);
            this.Controls.Add(this.txtcccd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "khachhang";
            this.Text = "khachhang";
            this.Load += new System.EventHandler(this.khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.TextBox txtns;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bnt_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_close;
    }
}