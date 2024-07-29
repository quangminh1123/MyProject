
namespace QuanLyShopDongHo.Forms
{
    partial class QuanLySanPham
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
            this.txtngaynhap = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthemhinh = new System.Windows.Forms.Button();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.tennv = new System.Windows.Forms.Label();
            this.vaitro = new System.Windows.Forms.Label();
            this.manv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.Location = new System.Drawing.Point(135, 222);
            this.txtngaynhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(132, 20);
            this.txtngaynhap.TabIndex = 93;
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
            this.btntim.Click += new System.EventHandler(this.btntim_Click_1);
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
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Format = "#,##0";
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.GiaNhap,
            this.NgayNhap,
            this.MoTa});
            this.dataGridView1.Location = new System.Drawing.Point(25, 302);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Format = "#,##0";
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(498, 152);
            this.dataGridView1.TabIndex = 92;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.MinimumWidth = 8;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Width = 150;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 8;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // GiaNhap
            // 
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 8;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 150;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 8;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 150;
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 150;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(135, 179);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(132, 20);
            this.txtsoluong.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(537, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 88);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "Ngày nhập:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(280, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Mô tả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(280, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Giá nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 39);
            this.label1.TabIndex = 72;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(387, 135);
            this.txttensp.Margin = new System.Windows.Forms.Padding(2);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(138, 20);
            this.txttensp.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Controls.Add(this.txttim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 51);
            this.panel1.TabIndex = 80;
            // 
            // btnthemhinh
            // 
            this.btnthemhinh.BackColor = System.Drawing.Color.LightBlue;
            this.btnthemhinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemhinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemhinh.Location = new System.Drawing.Point(537, 179);
            this.btnthemhinh.Margin = new System.Windows.Forms.Padding(2);
            this.btnthemhinh.Name = "btnthemhinh";
            this.btnthemhinh.Size = new System.Drawing.Size(85, 30);
            this.btnthemhinh.TabIndex = 91;
            this.btnthemhinh.Text = "Thêm hình ảnh";
            this.btnthemhinh.UseVisualStyleBackColor = false;
            this.btnthemhinh.Click += new System.EventHandler(this.btnthemhinh_Click_1);
            // 
            // txtma
            // 
            this.txtma.Enabled = false;
            this.txtma.Location = new System.Drawing.Point(135, 137);
            this.txtma.Margin = new System.Windows.Forms.Padding(2);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(132, 20);
            this.txtma.TabIndex = 89;
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.LightBlue;
            this.btnlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlammoi.Image = global::QuanLyShopDongHo.Properties.Resources.Refresh;
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlammoi.Location = new System.Drawing.Point(537, 424);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(85, 30);
            this.btnlammoi.TabIndex = 88;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.LightBlue;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Image = global::QuanLyShopDongHo.Properties.Resources.Delete;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(537, 384);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(85, 30);
            this.btnxoa.TabIndex = 87;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.LightBlue;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.Image = global::QuanLyShopDongHo.Properties.Resources.Edit;
            this.btncapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncapnhat.Location = new System.Drawing.Point(537, 343);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(85, 30);
            this.btncapnhat.TabIndex = 86;
            this.btncapnhat.Text = "Cập nhật ";
            this.btncapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.LightBlue;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Image = global::QuanLyShopDongHo.Properties.Resources.Add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(537, 302);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 30);
            this.btnthem.TabIndex = 85;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Image = global::QuanLyShopDongHo.Properties.Resources.Exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(537, 21);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 30);
            this.btnthoat.TabIndex = 84;
            this.btnthoat.Text = "Quay lại";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(387, 222);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(138, 68);
            this.richTextBox1.TabIndex = 83;
            this.richTextBox1.Text = "";
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(387, 180);
            this.txtgianhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(138, 20);
            this.txtgianhap.TabIndex = 75;
            // 
            // tennv
            // 
            this.tennv.AutoSize = true;
            this.tennv.Location = new System.Drawing.Point(309, 30);
            this.tennv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tennv.Name = "tennv";
            this.tennv.Size = new System.Drawing.Size(35, 13);
            this.tennv.TabIndex = 94;
            this.tennv.Text = "label9";
            this.tennv.Visible = false;
            // 
            // vaitro
            // 
            this.vaitro.AutoSize = true;
            this.vaitro.Location = new System.Drawing.Point(375, 30);
            this.vaitro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vaitro.Name = "vaitro";
            this.vaitro.Size = new System.Drawing.Size(41, 13);
            this.vaitro.TabIndex = 95;
            this.vaitro.Text = "label10";
            this.vaitro.Visible = false;
            // 
            // manv
            // 
            this.manv.AutoSize = true;
            this.manv.Location = new System.Drawing.Point(439, 30);
            this.manv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(41, 13);
            this.manv.TabIndex = 96;
            this.manv.Text = "label11";
            this.manv.Visible = false;
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyShopDongHo.Properties.Resources.bg1_1;
            this.ClientSize = new System.Drawing.Size(635, 471);
            this.Controls.Add(this.manv);
            this.Controls.Add(this.tennv);
            this.Controls.Add(this.txtngaynhap);
            this.Controls.Add(this.vaitro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnthemhinh);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtgianhap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLySanPham";
            this.Text = "QuanLySanPham";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtngaynhap;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthemhinh;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.Label tennv;
        private System.Windows.Forms.Label vaitro;
        private System.Windows.Forms.Label manv;
    }
}