namespace guitientietkiem_luongnam
{
    partial class main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kyHanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soTietKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSachToolStripMenuItem
            // 
            this.danhSachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachHangToolStripMenuItem,
            this.kyHanToolStripMenuItem,
            this.soTietKiemToolStripMenuItem});
            this.danhSachToolStripMenuItem.Name = "danhSachToolStripMenuItem";
            this.danhSachToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhSachToolStripMenuItem.Text = "Danh sach";
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.khachHangToolStripMenuItem.Text = "Khach hang";
            this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // kyHanToolStripMenuItem
            // 
            this.kyHanToolStripMenuItem.Name = "kyHanToolStripMenuItem";
            this.kyHanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kyHanToolStripMenuItem.Text = "Ky han";
            this.kyHanToolStripMenuItem.Click += new System.EventHandler(this.kyHanToolStripMenuItem_Click);
            // 
            // soTietKiemToolStripMenuItem
            // 
            this.soTietKiemToolStripMenuItem.Name = "soTietKiemToolStripMenuItem";
            this.soTietKiemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.soTietKiemToolStripMenuItem.Text = "So tiet kiem";
            this.soTietKiemToolStripMenuItem.Click += new System.EventHandler(this.soTietKiemToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 362);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kyHanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soTietKiemToolStripMenuItem;
    }
}

