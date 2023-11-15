namespace QuanLyHocSinh
{
    partial class QuanLyHocSinh
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
            this.quảnLýHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnHt = new System.Windows.Forms.Button();
            this.btnTk = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.chbHoTen = new System.Windows.Forms.CheckBox();
            this.chbDiaChi = new System.Windows.Forms.CheckBox();
            this.chbEmail = new System.Windows.Forms.CheckBox();
            this.chbSdt = new System.Windows.Forms.CheckBox();
            this.chbNgaySinh = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMahs = new System.Windows.Forms.TextBox();
            this.chbMa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quảnLýHọcSinhToolStripMenuItem
            // 
            this.quảnLýHọcSinhToolStripMenuItem.Name = "quảnLýHọcSinhToolStripMenuItem";
            this.quảnLýHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.quảnLýHọcSinhToolStripMenuItem.Text = "Quản lý học sinh";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(11, 263);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.RowTemplate.Height = 24;
            this.dgvHocSinh.Size = new System.Drawing.Size(958, 328);
            this.dgvHocSinh.TabIndex = 14;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(71, 112);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(206, 28);
            this.txtHoTen.TabIndex = 12;
            // 
            // btnHt
            // 
            this.btnHt.Location = new System.Drawing.Point(762, 221);
            this.btnHt.Name = "btnHt";
            this.btnHt.Size = new System.Drawing.Size(207, 36);
            this.btnHt.TabIndex = 7;
            this.btnHt.Text = "Hiển thị tất cả";
            this.btnHt.UseVisualStyleBackColor = true;
            this.btnHt.Click += new System.EventHandler(this.btnHt_Click);
            // 
            // btnTk
            // 
            this.btnTk.Location = new System.Drawing.Point(301, 221);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(102, 36);
            this.btnTk.TabIndex = 8;
            this.btnTk.Text = "Tìm kiếm";
            this.btnTk.UseVisualStyleBackColor = true;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(205, 221);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 36);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(107, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 36);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 221);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 36);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quản lý học sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ tên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHọcSinhToolStripMenuItem,
            this.quảnLýLớpHọcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý lớp học";
            this.quảnLýLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpHọcToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(71, 181);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(206, 28);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(436, 108);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(185, 30);
            this.dtpNgaySinh.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(415, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 28);
            this.txtEmail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số điện thoại";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(763, 181);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(206, 28);
            this.txtSdt.TabIndex = 12;
            // 
            // chbHoTen
            // 
            this.chbHoTen.AutoSize = true;
            this.chbHoTen.Location = new System.Drawing.Point(71, 86);
            this.chbHoTen.Name = "chbHoTen";
            this.chbHoTen.Size = new System.Drawing.Size(134, 20);
            this.chbHoTen.TabIndex = 16;
            this.chbHoTen.Text = "Tìm kiếm theo tên";
            this.chbHoTen.UseVisualStyleBackColor = true;
            // 
            // chbDiaChi
            // 
            this.chbDiaChi.AutoSize = true;
            this.chbDiaChi.Location = new System.Drawing.Point(71, 155);
            this.chbDiaChi.Name = "chbDiaChi";
            this.chbDiaChi.Size = new System.Drawing.Size(155, 20);
            this.chbDiaChi.TabIndex = 16;
            this.chbDiaChi.Text = "Tìm kiếm theo địa chỉ";
            this.chbDiaChi.UseVisualStyleBackColor = true;
            // 
            // chbEmail
            // 
            this.chbEmail.AutoSize = true;
            this.chbEmail.Location = new System.Drawing.Point(415, 155);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Size = new System.Drawing.Size(149, 20);
            this.chbEmail.TabIndex = 16;
            this.chbEmail.Text = "Tìm kiếm theo email";
            this.chbEmail.UseVisualStyleBackColor = true;
            // 
            // chbSdt
            // 
            this.chbSdt.AutoSize = true;
            this.chbSdt.Location = new System.Drawing.Point(762, 155);
            this.chbSdt.Name = "chbSdt";
            this.chbSdt.Size = new System.Drawing.Size(134, 20);
            this.chbSdt.TabIndex = 16;
            this.chbSdt.Text = "Tìm kiếm theo sđt";
            this.chbSdt.UseVisualStyleBackColor = true;
            // 
            // chbNgaySinh
            // 
            this.chbNgaySinh.AutoSize = true;
            this.chbNgaySinh.Location = new System.Drawing.Point(436, 86);
            this.chbNgaySinh.Name = "chbNgaySinh";
            this.chbNgaySinh.Size = new System.Drawing.Size(173, 20);
            this.chbNgaySinh.TabIndex = 16;
            this.chbNgaySinh.Text = "Tìm kiếm theo ngày sinh";
            this.chbNgaySinh.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã học sinh";
            // 
            // txtMahs
            // 
            this.txtMahs.Enabled = false;
            this.txtMahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahs.Location = new System.Drawing.Point(762, 112);
            this.txtMahs.Name = "txtMahs";
            this.txtMahs.Size = new System.Drawing.Size(206, 28);
            this.txtMahs.TabIndex = 12;
            // 
            // chbMa
            // 
            this.chbMa.AutoSize = true;
            this.chbMa.Location = new System.Drawing.Point(762, 86);
            this.chbMa.Name = "chbMa";
            this.chbMa.Size = new System.Drawing.Size(135, 20);
            this.chbMa.TabIndex = 16;
            this.chbMa.Text = "Tìm kiếm theo mã";
            this.chbMa.UseVisualStyleBackColor = true;
            this.chbMa.CheckedChanged += new System.EventHandler(this.chbMa_CheckedChanged);
            // 
            // QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.chbSdt);
            this.Controls.Add(this.chbEmail);
            this.Controls.Add(this.chbDiaChi);
            this.Controls.Add(this.chbNgaySinh);
            this.Controls.Add(this.chbMa);
            this.Controls.Add(this.chbHoTen);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtMahs);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnHt);
            this.Controls.Add(this.btnTk);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "QuanLyHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHocSinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcSinhToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnHt;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.CheckBox chbHoTen;
        private System.Windows.Forms.CheckBox chbDiaChi;
        private System.Windows.Forms.CheckBox chbEmail;
        private System.Windows.Forms.CheckBox chbSdt;
        private System.Windows.Forms.CheckBox chbNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMahs;
        private System.Windows.Forms.CheckBox chbMa;
    }
}