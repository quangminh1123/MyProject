
namespace QuanLyShopDongHo.Forms
{
    partial class QuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenKhachTim = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.manv = new System.Windows.Forms.Label();
            this.vaitro = new System.Windows.Forms.Label();
            this.tennv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::QuanLyShopDongHo.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(465, 9);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 34);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::QuanLyShopDongHo.Properties.Resources.Add;
            this.btnThem.Location = new System.Drawing.Point(428, 248);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 43);
            this.btnThem.TabIndex = 82;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.txtTenKhachTim);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(362, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 128);
            this.panel1.TabIndex = 81;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtTenKhachTim
            // 
            this.txtTenKhachTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKhachTim.Location = new System.Drawing.Point(9, 41);
            this.txtTenKhachTim.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhachTim.Name = "txtTenKhachTim";
            this.txtTenKhachTim.Size = new System.Drawing.Size(150, 23);
            this.txtTenKhachTim.TabIndex = 44;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Teal;
            this.btnTimKiem.FlatAppearance.BorderSize = 3;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::QuanLyShopDongHo.Properties.Resources.Search;
            this.btnTimKiem.Location = new System.Drawing.Point(34, 68);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 43);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tên khách hàng tìm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Tên khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(152, 168);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(176, 23);
            this.txtDiaChi.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(152, 128);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(176, 23);
            this.txtSDT.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 39);
            this.label2.TabIndex = 75;
            this.label2.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::QuanLyShopDongHo.Properties.Resources.Refresh;
            this.btnLamMoi.Location = new System.Drawing.Point(428, 392);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 43);
            this.btnLamMoi.TabIndex = 88;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::QuanLyShopDongHo.Properties.Resources.Delete;
            this.btnXoa.Location = new System.Drawing.Point(428, 344);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 43);
            this.btnXoa.TabIndex = 87;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = global::QuanLyShopDongHo.Properties.Resources.Edit;
            this.btnCapNhat.Location = new System.Drawing.Point(428, 297);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(103, 45);
            this.btnCapNhat.TabIndex = 86;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(152, 90);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(176, 23);
            this.txtTenKhachHang.TabIndex = 85;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.SDT,
            this.DiaChi});
            this.dgvKhachHang.Location = new System.Drawing.Point(38, 223);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(383, 235);
            this.dgvKhachHang.TabIndex = 84;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 200;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "SĐT";
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(425, 7);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(35, 13);
            this.manv.TabIndex = 91;
            this.manv.Text = "label7";
            this.manv.Visible = false;
            // 
            // vaitro
            // 
            this.vaitro.AutoSize = true;
            this.vaitro.Location = new System.Drawing.Point(381, 7);
            this.vaitro.Name = "vaitro";
            this.vaitro.Size = new System.Drawing.Size(35, 13);
            this.vaitro.TabIndex = 90;
            this.vaitro.Text = "label4";
            this.vaitro.Visible = false;
            // 
            // tennv
            // 
            this.tennv.AutoSize = true;
            this.tennv.Location = new System.Drawing.Point(344, 7);
            this.tennv.Name = "tennv";
            this.tennv.Size = new System.Drawing.Size(35, 13);
            this.tennv.TabIndex = 89;
            this.tennv.Text = "label1";
            this.tennv.Visible = false;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyShopDongHo.Properties.Resources.bg_kh;
            this.ClientSize = new System.Drawing.Size(577, 478);
            this.Controls.Add(this.manv);
            this.Controls.Add(this.vaitro);
            this.Controls.Add(this.tennv);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenKhachTim;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label manv;
        private System.Windows.Forms.Label vaitro;
        private System.Windows.Forms.Label tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}