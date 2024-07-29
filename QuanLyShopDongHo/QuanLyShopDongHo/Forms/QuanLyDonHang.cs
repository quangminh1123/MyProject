using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyShopDongHo.Forms
{
    public partial class QuanLyDonHang : Form
    {
        string inputdata1 = "";
        string inputdata2 = "";
        string inputdata3 = "";
        public QuanLyDonHang(string input1, string input2, string input3)
        {
            this.inputdata1 = input1;
            this.inputdata2 = input2;
            this.inputdata3 = input3;
            InitializeComponent();
        }

        private void QuanLyDonHang_Load(object sender, EventArgs e)
        {
            tennv.Text = inputdata1;
            vaitro.Text = inputdata2;
            manvv.Text = inputdata3;
            using (var db = new QuanLyShopDongHoEntities())
            {
                db.DonHangs.ToList().ForEach(x => cboMaDonTim.Items.Add(x.MaDon));
                db.KhachHangs.ToList().ForEach(x => cboSDT.Items.Add(x.SDT));
                db.ChiTietSanPhams.ToList().ForEach(x => cboLoaiSP.Items.Add(x.LoaiSP));
            }
            txtMaNhanVien.Text = manvv.Text;
            dtpNgayIn.Text = DateTime.Now.ToString("dd/MM/yyyy");
            btnThanhToan.Enabled = false;
            pnlTimSDT.Visible = false;
            ShowDH();
            ShowKH();
        }

        private void ShowDH()
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                dgvDonHang.Rows.Clear();
                db.DonHangs.ToList().ForEach(x =>
                    dgvDonHang.Rows.Add(x.MaDon, x.TenKH, x.SDT, x.LoaiSP, x.ChiTietSanPham.TenLoai,
                    x.SoLuong, x.ChiTietSanPham.GiaBan.ToString("#,##0"), x.NgayIn.ToString("dd/MM/yyyy"), x.MaNV));
            }
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QuanLyShopDongHoEntities())
                {
                    DonHang dh = new DonHang();
                    dh.MaDon = taoMaDH();
                    dh.TenKH = db.KhachHangs.Where(x => x.SDT == cboSDT.Text).Select(x => x.TenKH).FirstOrDefault();
                    dh.SDT = cboSDT.Text;
                    dh.LoaiSP = cboLoaiSP.Text;
                    dh.SoLuong = int.Parse(txtSoLuong.Text);
                    dh.NgayIn = DateTime.Parse(dtpNgayIn.Text);
                    dh.MaNV = txtMaNhanVien.Text;

                    var SDT = db.KhachHangs.Select(x => x.SDT);
                    var loaiSP = db.ChiTietSanPhams.Select(x => x.LoaiSP);
                    if (cboSDT.Text == "" || cboLoaiSP.Text == "" || txtSoLuong.Text == "" || txtMaNhanVien.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaDon.Focus();
                    }
                    else if (cboSDT.Text.Length > 10 || cboSDT.Text.Length < 10)
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại đủ 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboSDT.Focus();
                    }
                    else if (SDT.Contains(cboSDT.Text) == false)
                    {
                        MessageBox.Show("Số điện thoại không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboSDT.Focus();
                    }
                    else if (int.Parse(txtSoLuong.Text) <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboSDT.Focus();
                    }
                    else if (loaiSP.Contains(cboLoaiSP.Text) == false)
                    {
                        MessageBox.Show("Mã loại sản phẩm không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboLoaiSP.Focus();
                    }
                    else
                    {
                        db.DonHangs.Add(dh);
                        db.SaveChanges();
                        ShowDH();
                        Rong();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanDonHang thanhToan = new ThanhToanDonHang(txtMaDon.Text);
            thanhToan.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Rong();
            btnThanhToan.Enabled = false;
            btnTaoDon.Enabled = true;
            btnTimSDT.Enabled = true;
            ShowDH();
        }
        private void Rong()
        {
            txtMaDon.Text = "";
            txtTenKhachHang.Text = "";
            cboSDT.Text = "";
            cboLoaiSP.Text = "";
            txtTenLoai.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtMaNhanVien.Text = manvv.Text;
            dtpNgayIn.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cboMaDonTim.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                List<DonHang> maDon = db.DonHangs.Where(x => x.MaDon.Contains(cboMaDonTim.Text.Trim())).ToList();
                if (maDon.Count > 0)
                {
                    dgvDonHang.Rows.Clear();
                    maDon.ForEach(x =>
                    {
                        dgvDonHang.Rows.Add(x.MaDon, x.TenKH, x.SDT, x.LoaiSP, x.ChiTietSanPham.TenLoai,
                                            x.SoLuong, x.ChiTietSanPham.GiaBan, x.NgayIn, x.MaNV);
                        txtMaDon.Text = x.MaDon;
                        txtTenKhachHang.Text = x.TenKH;
                        cboSDT.Text = x.SDT;
                        cboLoaiSP.Text = x.LoaiSP;
                        txtTenLoai.Text = x.ChiTietSanPham.TenLoai;
                        txtSoLuong.Text = x.SoLuong.ToString();
                        txtDonGia.Text = x.ChiTietSanPham.GiaBan.ToString("#,##0");
                        dtpNgayIn.Text = x.NgayIn.ToString("dd/MM/yyyy");
                        txtMaNhanVien.Text = x.MaNV;
                    });
                    btnTaoDon.Enabled = false;
                    btnThanhToan.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDH();
                    btnTaoDon.Enabled = true;
                    btnThanhToan.Enabled = false;
                    Rong();
                }
            }
        }

        private string taoMaDH()
        {
            SqlConnection conn = new SqlConnection(@"server = .; database = QuanLyShopDongHo; integrated security = true");
            string query = "select * from DonHang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string ma = "";
            if (table.Rows.Count <= 0)
            {
                ma = "DH01";
            }
            else
            {
                int index;
                ma = "DH";
                index = int.Parse(table.Rows[table.Rows.Count - 1][0].ToString().Substring(2, 2));
                index += 1;
                if (index < 10)
                {
                    ma += "0";
                }
                ma += index.ToString();
            }
            return ma;
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                txtMaDon.Text = dgvDonHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dgvDonHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboSDT.Text = dgvDonHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboLoaiSP.Text = dgvDonHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTenLoai.Text = dgvDonHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSoLuong.Text = dgvDonHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDonGia.Text = dgvDonHang.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtpNgayIn.Text = dgvDonHang.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtMaNhanVien.Text = dgvDonHang.Rows[e.RowIndex].Cells[8].Value.ToString();
                btnTaoDon.Enabled = false;
                btnTimSDT.Enabled = false;
                btnThanhToan.Enabled = true;
            }          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TrangChu dn = new TrangChu(inputdata1, inputdata2, inputdata3);
            dn.Show();
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                txtTenLoai.Text = db.ChiTietSanPhams.Where(x => x.LoaiSP == cboLoaiSP.Text)
                                    .Select(x => x.TenLoai).FirstOrDefault().ToString();
                txtDonGia.Text = db.ChiTietSanPhams.Where(x => x.LoaiSP == cboLoaiSP.Text)
                                   .Select(x => x.GiaBan).FirstOrDefault().ToString("#,##0");
            }
        }

        private void cboSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                txtTenKhachHang.Text = db.KhachHangs.Where(x => x.SDT == cboSDT.Text)
                                        .Select(x => x.TenKH).FirstOrDefault().ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
           Color.Silver, 3, ButtonBorderStyle.Solid,
           Color.Silver, 3, ButtonBorderStyle.Solid,
           Color.Silver, 3, ButtonBorderStyle.Solid,
           Color.Silver, 3, ButtonBorderStyle.Solid);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            else
            {
                cboSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        private void ShowKH()
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                dgvKhachHang.Rows.Clear();
                db.KhachHangs.ToList().ForEach(x => dgvKhachHang.Rows.Add(x.TenKH, x.SDT));
            }
        }

        private void btnTimSDT_Click(object sender, EventArgs e)
        {
            pnlTimSDT.Visible = true;
            pnlTimSDT.BringToFront();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                List<KhachHang> SDT = db.KhachHangs.Where(x => x.SDT.Contains(txtSDT.Text.Trim())).ToList();
                if (SDT.Count > 0)
                {
                    dgvKhachHang.Rows.Clear();
                    SDT.ForEach(x =>
                    {
                        dgvKhachHang.Rows.Add(x.TenKH, x.SDT);
                    });
                }
                else
                {
                    ShowKH();
                    MessageBox.Show("Không tìm thấy SĐT khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowKH();
                }
            }
        }

        private void btnThoatChon_Click(object sender, EventArgs e)
        {
            pnlTimSDT.Visible = false;
        }
    }
}
