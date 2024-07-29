
namespace QuanLyShopDongHo.Forms
{
    partial class QuanLyDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboMaDonTim = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoDon = new System.Windows.Forms.Button();
            this.cboSDT = new System.Windows.Forms.ComboBox();
            this.dtpNgayIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.MaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.manvv = new System.Windows.Forms.Label();
            this.vaitro = new System.Windows.Forms.Label();
            this.tennv = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimSDT = new System.Windows.Forms.Button();
            this.pnlTimSDT = new System.Windows.Forms.Panel();
            this.btnThoatChon = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.pnlTimSDT.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(461, 127);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(150, 24);
            this.cboLoaiSP.TabIndex = 90;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = global::QuanLyShopDongHo.Properties.Resources.Refresh;
            this.btnLamMoi.Location = new System.Drawing.Point(249, 295);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 43);
            this.btnLamMoi.TabIndex = 96;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cboMaDonTim);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(379, 271);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 65);
            this.panel1.TabIndex = 108;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboMaDonTim
            // 
            this.cboMaDonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMaDonTim.FormattingEnabled = true;
            this.cboMaDonTim.Location = new System.Drawing.Point(85, 22);
            this.cboMaDonTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaDonTim.Name = "cboMaDonTim";
            this.cboMaDonTim.Size = new System.Drawing.Size(138, 24);
            this.cboMaDonTim.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.SlateGray;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.FlatAppearance.BorderSize = 3;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::QuanLyShopDongHo.Properties.Resources.Search;
            this.btnTimKiem.Location = new System.Drawing.Point(233, 11);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 43);
            this.btnTimKiem.TabIndex = 11;
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
            this.label6.Location = new System.Drawing.Point(11, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã đơn tìm";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(461, 86);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(150, 23);
            this.txtTenKhachHang.TabIndex = 105;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Image = global::QuanLyShopDongHo.Properties.Resources.dollar;
            this.btnThanhToan.Location = new System.Drawing.Point(127, 293);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(118, 43);
            this.btnThanhToan.TabIndex = 95;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::QuanLyShopDongHo.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(668, 9);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 32);
            this.btnThoat.TabIndex = 97;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTaoDon.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnTaoDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTaoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.Image = global::QuanLyShopDongHo.Properties.Resources.Add;
            this.btnTaoDon.Location = new System.Drawing.Point(28, 293);
            this.btnTaoDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(95, 43);
            this.btnTaoDon.TabIndex = 94;
            this.btnTaoDon.Text = "Tạo đơn";
            this.btnTaoDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoDon.UseVisualStyleBackColor = false;
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // cboSDT
            // 
            this.cboSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboSDT.FormattingEnabled = true;
            this.cboSDT.Location = new System.Drawing.Point(178, 128);
            this.cboSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSDT.Name = "cboSDT";
            this.cboSDT.Size = new System.Drawing.Size(150, 24);
            this.cboSDT.TabIndex = 89;
            this.cboSDT.SelectedIndexChanged += new System.EventHandler(this.cboSDT_SelectedIndexChanged);
            // 
            // dtpNgayIn
            // 
            this.dtpNgayIn.CustomFormat = "";
            this.dtpNgayIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayIn.Location = new System.Drawing.Point(460, 197);
            this.dtpNgayIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayIn.Name = "dtpNgayIn";
            this.dtpNgayIn.Size = new System.Drawing.Size(151, 23);
            this.dtpNgayIn.TabIndex = 92;
            this.dtpNgayIn.Value = new System.DateTime(2023, 11, 20, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(356, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 107;
            this.label7.Text = "Ngày in";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(356, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 106;
            this.label8.Text = "Loại sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(356, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 104;
            this.label9.Text = "Tên khách hàng";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(461, 232);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(150, 23);
            this.txtMaNhanVien.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(358, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 103;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(178, 163);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(150, 23);
            this.txtSoLuong.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "SĐT";
            // 
            // txtMaDon
            // 
            this.txtMaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDon.Location = new System.Drawing.Point(178, 89);
            this.txtMaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.ReadOnly = true;
            this.txtMaDon.Size = new System.Drawing.Size(150, 23);
            this.txtMaDon.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 100;
            this.label2.Text = "Mã đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 39);
            this.label1.TabIndex = 99;
            this.label1.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLoai.Location = new System.Drawing.Point(461, 160);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.ReadOnly = true;
            this.txtTenLoai.Size = new System.Drawing.Size(150, 23);
            this.txtTenLoai.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(356, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 110;
            this.label10.Text = "Tên loại";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDon,
            this.TenKhachHang,
            this.SDT,
            this.LoaiSP,
            this.TenLoai,
            this.SoLuong,
            this.DonGia,
            this.NgayIn,
            this.MaNV});
            this.dgvDonHang.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDonHang.Location = new System.Drawing.Point(26, 340);
            this.dgvDonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(723, 225);
            this.dgvDonHang.TabIndex = 112;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // MaDon
            // 
            this.MaDon.HeaderText = "Mã đơn";
            this.MaDon.MinimumWidth = 6;
            this.MaDon.Name = "MaDon";
            this.MaDon.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 125;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // LoaiSP
            // 
            this.LoaiSP.HeaderText = "Loại sản phẩm";
            this.LoaiSP.MinimumWidth = 6;
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Width = 125;
            // 
            // TenLoai
            // 
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // NgayIn
            // 
            this.NgayIn.HeaderText = "Ngày in";
            this.NgayIn.MinimumWidth = 6;
            this.NgayIn.Name = "NgayIn";
            this.NgayIn.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(85, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 117;
            this.label11.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGia.Location = new System.Drawing.Point(178, 199);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(150, 23);
            this.txtDonGia.TabIndex = 118;
            // 
            // manvv
            // 
            this.manvv.AutoSize = true;
            this.manvv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.manvv.Location = new System.Drawing.Point(573, 9);
            this.manvv.Name = "manvv";
            this.manvv.Size = new System.Drawing.Size(41, 13);
            this.manvv.TabIndex = 115;
            this.manvv.Text = "label13";
            this.manvv.Visible = false;
            // 
            // vaitro
            // 
            this.vaitro.AutoSize = true;
            this.vaitro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vaitro.Location = new System.Drawing.Point(526, 9);
            this.vaitro.Name = "vaitro";
            this.vaitro.Size = new System.Drawing.Size(41, 13);
            this.vaitro.TabIndex = 114;
            this.vaitro.Text = "label12";
            this.vaitro.Visible = false;
            // 
            // tennv
            // 
            this.tennv.AutoSize = true;
            this.tennv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tennv.Location = new System.Drawing.Point(479, 9);
            this.tennv.Name = "tennv";
            this.tennv.Size = new System.Drawing.Size(41, 13);
            this.tennv.TabIndex = 113;
            this.tennv.Text = "label11";
            this.tennv.Visible = false;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.dataGridViewTextBoxColumn1});
            this.dgvKhachHang.Location = new System.Drawing.Point(6, 33);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(248, 156);
            this.dgvKhachHang.TabIndex = 122;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnTimSDT
            // 
            this.btnTimSDT.BackColor = System.Drawing.Color.SlateGray;
            this.btnTimSDT.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimSDT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTimSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimSDT.ForeColor = System.Drawing.Color.White;
            this.btnTimSDT.Image = global::QuanLyShopDongHo.Properties.Resources.Search;
            this.btnTimSDT.Location = new System.Drawing.Point(121, 128);
            this.btnTimSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimSDT.Name = "btnTimSDT";
            this.btnTimSDT.Size = new System.Drawing.Size(36, 27);
            this.btnTimSDT.TabIndex = 123;
            this.btnTimSDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimSDT.UseVisualStyleBackColor = false;
            this.btnTimSDT.Click += new System.EventHandler(this.btnTimSDT_Click);
            // 
            // pnlTimSDT
            // 
            this.pnlTimSDT.Controls.Add(this.btnThoatChon);
            this.pnlTimSDT.Controls.Add(this.label12);
            this.pnlTimSDT.Controls.Add(this.txtSDT);
            this.pnlTimSDT.Controls.Add(this.btnTim);
            this.pnlTimSDT.Controls.Add(this.dgvKhachHang);
            this.pnlTimSDT.Location = new System.Drawing.Point(202, 163);
            this.pnlTimSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTimSDT.Name = "pnlTimSDT";
            this.pnlTimSDT.Size = new System.Drawing.Size(318, 195);
            this.pnlTimSDT.TabIndex = 124;
            // 
            // btnThoatChon
            // 
            this.btnThoatChon.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnThoatChon.FlatAppearance.BorderSize = 0;
            this.btnThoatChon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnThoatChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatChon.ForeColor = System.Drawing.Color.White;
            this.btnThoatChon.Location = new System.Drawing.Point(258, 74);
            this.btnThoatChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoatChon.Name = "btnThoatChon";
            this.btnThoatChon.Size = new System.Drawing.Size(54, 32);
            this.btnThoatChon.TabIndex = 126;
            this.btnThoatChon.Text = "Thoát";
            this.btnThoatChon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoatChon.UseVisualStyleBackColor = false;
            this.btnThoatChon.Click += new System.EventHandler(this.btnThoatChon_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 125;
            this.label12.Text = "Nhập SĐT";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(92, 10);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 23);
            this.txtSDT.TabIndex = 124;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(258, 33);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(54, 32);
            this.btnTim.TabIndex = 123;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // QuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::QuanLyShopDongHo.Properties.Resources.bg1_1;
            this.ClientSize = new System.Drawing.Size(776, 588);
            this.Controls.Add(this.btnTimSDT);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.manvv);
            this.Controls.Add(this.vaitro);
            this.Controls.Add(this.tennv);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaoDon);
            this.Controls.Add(this.cboSDT);
            this.Controls.Add(this.dtpNgayIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTimSDT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyDonHang";
            this.Text = "QuanLyDonHang";
            this.Load += new System.EventHandler(this.QuanLyDonHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.pnlTimSDT.ResumeLayout(false);
            this.pnlTimSDT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaDonTim;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoDon;
        private System.Windows.Forms.ComboBox cboSDT;
        private System.Windows.Forms.DateTimePicker dtpNgayIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label manvv;
        private System.Windows.Forms.Label vaitro;
        private System.Windows.Forms.Label tennv;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnTimSDT;
        private System.Windows.Forms.Panel pnlTimSDT;
        private System.Windows.Forms.Button btnThoatChon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnTim;
    }
}