namespace guitientietkiem_luongnam
{
    partial class sotietkiem
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
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.flsotiengui = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.guitientkDataSet = new guitientietkiem_luongnam.guitientkDataSet();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachhangTableAdapter = new guitientietkiem_luongnam.guitientkDataSetTableAdapters.khachhangTableAdapter();
            this.guitientkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guitientkDataSet1 = new guitientietkiem_luongnam.guitientkDataSet1();
            this.kyhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyhanTableAdapter = new guitientietkiem_luongnam.guitientkDataSet1TableAdapters.kyhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitientkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitientkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitientkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sổ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kỳ hạn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tiền gửi:";
            // 
            // txtmaso
            // 
            this.txtmaso.Location = new System.Drawing.Point(133, 25);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.Size = new System.Drawing.Size(121, 20);
            this.txtmaso.TabIndex = 1;
            // 
            // flsotiengui
            // 
            this.flsotiengui.Location = new System.Drawing.Point(133, 120);
            this.flsotiengui.Name = "flsotiengui";
            this.flsotiengui.Size = new System.Drawing.Size(121, 20);
            this.flsotiengui.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khachhangBindingSource, "id", true));
            this.comboBox1.DataSource = this.khachhangBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kyhanBindingSource, "id", true));
            this.comboBox2.DataSource = this.kyhanBindingSource;
            this.comboBox2.DisplayMember = "kyhan";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 289);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Lime;
            this.btnthem.Location = new System.Drawing.Point(16, 178);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 45);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Aqua;
            this.btnxoa.Location = new System.Drawing.Point(154, 178);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 45);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Sửa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(154, 249);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 45);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Đóng lại";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Red;
            this.btnsua.Location = new System.Drawing.Point(16, 249);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 45);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Xóa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // guitientkDataSet
            // 
            this.guitientkDataSet.DataSetName = "guitientkDataSet";
            this.guitientkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "khachhang";
            this.khachhangBindingSource.DataSource = this.guitientkDataSet;
            // 
            // khachhangTableAdapter
            // 
            this.khachhangTableAdapter.ClearBeforeFill = true;
            // 
            // guitientkDataSetBindingSource
            // 
            this.guitientkDataSetBindingSource.DataSource = this.guitientkDataSet;
            this.guitientkDataSetBindingSource.Position = 0;
            // 
            // guitientkDataSet1
            // 
            this.guitientkDataSet1.DataSetName = "guitientkDataSet1";
            this.guitientkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kyhanBindingSource
            // 
            this.kyhanBindingSource.DataMember = "kyhan";
            this.kyhanBindingSource.DataSource = this.guitientkDataSet1;
            // 
            // kyhanTableAdapter
            // 
            this.kyhanTableAdapter.ClearBeforeFill = true;
            // 
            // sotietkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 358);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.flsotiengui);
            this.Controls.Add(this.txtmaso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sotietkiem";
            this.Text = "sotietkiem";
            this.Load += new System.EventHandler(this.sotietkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitientkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitientkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitientkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyhanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaso;
        private System.Windows.Forms.TextBox flsotiengui;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsua;
        private guitientkDataSet guitientkDataSet;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
        private guitientkDataSetTableAdapters.khachhangTableAdapter khachhangTableAdapter;
        private System.Windows.Forms.BindingSource guitientkDataSetBindingSource;
        private guitientkDataSet1 guitientkDataSet1;
        private System.Windows.Forms.BindingSource kyhanBindingSource;
        private guitientkDataSet1TableAdapters.kyhanTableAdapter kyhanTableAdapter;
    }
}