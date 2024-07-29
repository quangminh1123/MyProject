
namespace QuanLyShopDongHo.Forms
{
    partial class QuanLyChiTietSanPham
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
            this.txtkhuyenmai = new System.Windows.Forms.TextBox();
            this.cbbmasp = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtloaisp = new System.Windows.Forms.TextBox();
            this.tennv = new System.Windows.Forms.Label();
            this.vaitro = new System.Windows.Forms.Label();
            this.manv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkhuyenmai
            // 
            this.txtkhuyenmai.Location = new System.Drawing.Point(145, 223);
            this.txtkhuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.txtkhuyenmai.Name = "txtkhuyenmai";
            this.txtkhuyenmai.Size = new System.Drawing.Size(131, 20);
            this.txtkhuyenmai.TabIndex = 71;
            // 
            // cbbmasp
            // 
            this.cbbmasp.FormattingEnabled = true;
            this.cbbmasp.Location = new System.Drawing.Point(145, 178);
            this.cbbmasp.Margin = new System.Windows.Forms.Padding(2);
            this.cbbmasp.Name = "cbbmasp";
            this.cbbmasp.Size = new System.Drawing.Size(131, 21);
            this.cbbmasp.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Controls.Add(this.txttim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 51);
            this.panel1.TabIndex = 61;
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.Color.LightBlue;
            this.btntim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntim.Image = global::QuanLyShopDongHo.Properties.Resources.Search;
            this.btntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntim.Location = new System.Drawing.Point(334, 13);
            this.btntim.Margin = new System.Windows.Forms.Padding(2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(76, 30);
            this.btntim.TabIndex = 15;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(136, 20);
            this.txttim.Margin = new System.Windows.Forms.Padding(2);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(173, 20);
            this.txttim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm loại sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Khuyến mãi: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Mã sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(290, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Giá bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(290, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tên loại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Loại sản phẩm: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 52;
            this.label1.Text = "Chi tiết sản phẩm";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(372, 126);
            this.txttenloai.Margin = new System.Windows.Forms.Padding(2);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(151, 20);
            this.txttenloai.TabIndex = 62;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(372, 177);
            this.txtgiaban.Margin = new System.Windows.Forms.Padding(2);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(151, 20);
            this.txtgiaban.TabIndex = 55;
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.LightBlue;
            this.btnlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoi.Image = global::QuanLyShopDongHo.Properties.Resources.Refresh;
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlammoi.Location = new System.Drawing.Point(535, 415);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(85, 30);
            this.btnlammoi.TabIndex = 69;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Format = "#,##0";
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiSP,
            this.TenLoai,
            this.MaSP,
            this.GiaBanRa,
            this.Mota});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(37, 293);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(484, 152);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick_dgv);
            // 
            // LoaiSP
            // 
            this.LoaiSP.HeaderText = "Loại sản phẩm";
            this.LoaiSP.MinimumWidth = 8;
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Width = 150;
            // 
            // TenLoai
            // 
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.MinimumWidth = 8;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Width = 150;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 150;
            // 
            // GiaBanRa
            // 
            this.GiaBanRa.HeaderText = "Giá bán ra";
            this.GiaBanRa.MinimumWidth = 8;
            this.GiaBanRa.Name = "GiaBanRa";
            this.GiaBanRa.Width = 150;
            // 
            // Mota
            // 
            this.Mota.HeaderText = "Mô tả";
            this.Mota.MinimumWidth = 8;
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            this.Mota.Width = 150;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(372, 222);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 68);
            this.richTextBox1.TabIndex = 63;
            this.richTextBox1.Text = "";
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.LightBlue;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Image = global::QuanLyShopDongHo.Properties.Resources.Delete;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(535, 375);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(85, 30);
            this.btnxoa.TabIndex = 68;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.LightBlue;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Image = global::QuanLyShopDongHo.Properties.Resources.Edit;
            this.btncapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncapnhat.Location = new System.Drawing.Point(535, 334);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(85, 30);
            this.btncapnhat.TabIndex = 67;
            this.btncapnhat.Text = "Cập nhật ";
            this.btncapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.LightBlue;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Image = global::QuanLyShopDongHo.Properties.Resources.Add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(535, 293);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 30);
            this.btnthem.TabIndex = 66;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Image = global::QuanLyShopDongHo.Properties.Resources.Exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(535, 13);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 30);
            this.btnthoat.TabIndex = 65;
            this.btnthoat.Text = "Quay lại";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtloaisp
            // 
            this.txtloaisp.Location = new System.Drawing.Point(145, 128);
            this.txtloaisp.Margin = new System.Windows.Forms.Padding(2);
            this.txtloaisp.Name = "txtloaisp";
            this.txtloaisp.Size = new System.Drawing.Size(132, 20);
            this.txtloaisp.TabIndex = 56;
            // 
            // tennv
            // 
            this.tennv.AutoSize = true;
            this.tennv.Location = new System.Drawing.Point(306, 13);
            this.tennv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tennv.Name = "tennv";
            this.tennv.Size = new System.Drawing.Size(35, 13);
            this.tennv.TabIndex = 72;
            this.tennv.Text = "label9";
            this.tennv.Visible = false;
            // 
            // vaitro
            // 
            this.vaitro.AutoSize = true;
            this.vaitro.Location = new System.Drawing.Point(372, 13);
            this.vaitro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vaitro.Name = "vaitro";
            this.vaitro.Size = new System.Drawing.Size(41, 13);
            this.vaitro.TabIndex = 73;
            this.vaitro.Text = "label10";
            this.vaitro.Visible = false;
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(436, 13);
            this.manv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(41, 13);
            this.manv.TabIndex = 74;
            this.manv.Text = "label11";
            this.manv.Visible = false;
            // 
            // QuanLyChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyShopDongHo.Properties.Resources.bg_dmk;
            this.ClientSize = new System.Drawing.Size(639, 472);
            this.Controls.Add(this.manv);
            this.Controls.Add(this.vaitro);
            this.Controls.Add(this.tennv);
            this.Controls.Add(this.txtkhuyenmai);
            this.Controls.Add(this.cbbmasp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtloaisp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyChiTietSanPham";
            this.Text = "QuanLyChiTietSanPham";
            this.Load += new System.EventHandler(this.QuanLyChiTietSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtkhuyenmai;
        private System.Windows.Forms.ComboBox cbbmasp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtloaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.Label tennv;
        private System.Windows.Forms.Label vaitro;
        private System.Windows.Forms.Label manv;
    }
}