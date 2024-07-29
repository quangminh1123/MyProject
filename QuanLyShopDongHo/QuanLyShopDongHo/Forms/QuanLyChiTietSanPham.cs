using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopDongHo.Forms
{
    public partial class QuanLyChiTietSanPham : Form
    {
        string inputdata1 = "";
        string inputdata2 = "";
        string inputdata3 = "";
        public QuanLyChiTietSanPham(string input1, string input2, string input3)
        {
            this.inputdata1 = input1;
            this.inputdata2 = input2;
            this.inputdata3 = input3;
            InitializeComponent();
        }

        private void QuanLyChiTietSanPham_Load(object sender, EventArgs e)
        {
            tennv.Text = inputdata1;
            vaitro.Text = inputdata2;
            manv.Text = inputdata3;
            btnthem.Enabled = true;
            btncapnhat.Enabled = false;
            btnxoa.Enabled = false;
            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
            {
                cbbmasp.Items.Clear();
                db.SanPhams.ToList().ForEach(row => cbbmasp.Items.Add(row.MaSanPham));
            }
            updatedgv();
        }
        private void updatedgv()
        {
            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
            {
                dataGridView1.Rows.Clear();
                db.ChiTietSanPhams.ToList().ForEach(nh =>
                {
                    dataGridView1.Rows.Add(
                        nh.LoaiSP,
                        nh.TenLoai,
                        nh.SanPham.MaSanPham,
                       (((100 - nh.KhuyenMai) / 100) * nh.GiaBan),
                        nh.MoTa
                    );
                });
            }
        }
        private void rong()
        {
            txttim.Text = "";
            txtloaisp.Text = "";
            txttenloai.Text = "";
            cbbmasp.Text = "";
            txtgiaban.Text = "";
            txtkhuyenmai.Text = "";
            richTextBox1.Text = "";
            btnthem.Enabled = true;
            btncapnhat.Enabled = false;
            btnxoa.Enabled = false;
        }
        private bool checkk()
        {
            if (txtloaisp.Text == "" || txttenloai.Text == "" || cbbmasp.Text == "" || txtgiaban.Text == "" || txtkhuyenmai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            if (txtloaisp.Text.Length > 8)
            {
                MessageBox.Show("Loại sản phẩm không được lớn hơn 8 ký tự");
                return false;
            }
            int number;
            if (int.TryParse(txtkhuyenmai.Text, out number))
            {
                if (number < 0)
                {
                    MessageBox.Show("Khuyễn mãi phải là số nguyên dương.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Khuyến mãi phải là số nguyên dương.");
                return false;
            }
            if (int.TryParse(txtgiaban.Text, out number))
            {
                if (number < 0)
                {
                    MessageBox.Show("Giá bán phải là số nguyên dương.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Giá bán phải là số nguyên dương.");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            using(QuanLyShopDongHoEntities hb = new QuanLyShopDongHoEntities())
            {
                List<ChiTietSanPham> list = hb.ChiTietSanPhams
                    .Where(x => x.LoaiSP == txtloaisp.Text)
                    .ToList();//sắp xếp ở đây
                if (!list.Any())
                {
                    if (checkk())
                    {
                        try
                        {
                            ChiTietSanPham them = new ChiTietSanPham();
                            them.LoaiSP = txtloaisp.Text;
                            them.TenLoai = txttenloai.Text;
                            them.GiaBan = float.Parse(txtgiaban.Text);
                            them.KhuyenMai = int.Parse(txtkhuyenmai.Text);
                            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
                            {
                                SanPham maspduocchon = db.SanPhams
                                    .Where(x => x.MaSanPham.ToString() == cbbmasp.SelectedItem.ToString()).FirstOrDefault();
                                them.MaSP = maspduocchon.MaSanPham;
                                db.ChiTietSanPhams.Add(them);
                                db.SaveChanges();
                            }
                            rong();
                            updatedgv();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Dữ liệu không hợp lệ.");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm đã tồn tại");
                    return;
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
                {
                    ChiTietSanPham xoa = db.ChiTietSanPhams.Where(x => x.LoaiSP == txtloaisp.Text)
                        .FirstOrDefault();
                    db.ChiTietSanPhams.Remove(xoa);
                    db.SaveChanges();
                }
                rong();
                updatedgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa sản phẩm!!!");
                return;
            }
           

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            rong();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (checkk())
            {
                try
                {
                    using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
                    {
                        ChiTietSanPham sua = db.ChiTietSanPhams.Where(x => x.LoaiSP == txtloaisp.Text)
                            .FirstOrDefault();
                        sua.LoaiSP = txtloaisp.Text;
                        sua.TenLoai = txttenloai.Text;
                        sua.GiaBan = float.Parse(txtgiaban.Text);
                        sua.KhuyenMai = int.Parse(txtkhuyenmai.Text);
                        SanPham maspduocchon = db.SanPhams
                            .Where(x => x.MaSanPham.ToString() == cbbmasp.SelectedItem.ToString()).FirstOrDefault();
                        sua.MaSP = maspduocchon.MaSanPham;
                        db.SaveChanges();
                    }
                    rong();
                    updatedgv();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.");
                    return;
                }
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
            {
                List<ChiTietSanPham> list = db.ChiTietSanPhams
                    .Where(x => x.LoaiSP == txttim.Text)
                    .ToList();//sắp xếp ở đây

                if (!list.Any())
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    list.ForEach(nh =>
                    {
                        txtloaisp.Text = nh.LoaiSP;
                        txttenloai.Text = nh.TenLoai;
                        cbbmasp.Text = nh.MaSP.ToString();
                        txtgiaban.Text = nh.GiaBan.ToString();
                        txtkhuyenmai.Text = nh.KhuyenMai.ToString();
                        richTextBox1.Text = nh.MoTa;
                    });

                }
                if (vaitro.Text == "Nhân Viên")
                {
                    btncapnhat.Enabled = true;
                    btnthem.Enabled = false;
                    btnxoa.Enabled = false;
                }
                else
                {
                    btncapnhat.Enabled = true;
                    btnthem.Enabled = false;
                    btnxoa.Enabled = true;
                }
            }
        }

        private void CellClick_dgv(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            var rowData = dataGridView1.Rows[row];
            String manh = rowData.Cells[0].Value.ToString();
            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
            {
                ChiTietSanPham kh = db.ChiTietSanPhams.Where(x => x.LoaiSP.ToString() == manh).FirstOrDefault();
                txtloaisp.Text = kh.LoaiSP.ToString();
                txttenloai.Text = kh.TenLoai;
                cbbmasp.Text = kh.MaSP.ToString();
                txtgiaban.Text = kh.GiaBan.ToString();
                txtkhuyenmai.Text = kh.KhuyenMai.ToString();
                richTextBox1.Text = kh.MoTa;
            }
            if (vaitro.Text == "Nhân Viên")
            {
                btncapnhat.Enabled = true;
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
            }
            else
            {
                btncapnhat.Enabled = true;
                btnthem.Enabled = false;
                btnxoa.Enabled = true;
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TrangChu dn = new TrangChu(inputdata1, inputdata2, inputdata3);
            dn.Show();
        }
    }
}
