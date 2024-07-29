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
    public partial class TrangChu : Form
    {
        string inputdata1 = "";
        string inputdata2 = "";
        string inputdata3 = "";
        public TrangChu(string input1, string input2, string input3)
        {
            this.inputdata1 = input1;
            this.inputdata2 = input2;
            this.inputdata3 = input3;
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            tennv.Text = inputdata1;
            vaitro.Text = inputdata2;
            manv.Text = inputdata3;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (vaitro.Text == "Nhân Viên")
            {
                btnThongKe.Enabled = false;
            }
            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
            {
                List<NhanVien> list = db.NhanViens
                   .Where(x => (x.MaNV == manv.Text))
                   .ToList();//sắp xếp ở đây
                list.ForEach(tk =>
                {
                    if(tk.MatKhau == "e99a18c428cb38d5f260853678922e03")
                    {
                        MessageBox.Show("Tài khoản vừa đăng nhập chưa bảo mật." +
                            "Vui lòng đổi mật khẩu để tăng tính bảo mật");
                    }
                    else 
                    { }
                });
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            string inputdata1 = tennv.Text;
            string inputdata2 = vaitro.Text;
            string inputdata3 = manv.Text;
            this.Dispose();
            QuanLyNhanVien khg = new QuanLyNhanVien(inputdata1, inputdata2, inputdata3);
            khg.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            string inputdata1 = tennv.Text;
            string inputdata2 = vaitro.Text;
            string inputdata3 = manv.Text;
            this.Dispose();
            QuanLySanPham khg = new QuanLySanPham(inputdata1, inputdata2, inputdata3);
            khg.Show();
        }

        private void btnChiTietSP_Click(object sender, EventArgs e)
        {
            string inputdata1 = tennv.Text;
            string inputdata2 = vaitro.Text;
            string inputdata3 = manv.Text;
            this.Dispose();
            QuanLyChiTietSanPham khg = new QuanLyChiTietSanPham(inputdata1, inputdata2, inputdata3);
            khg.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            string inputdata1 = tennv.Text;
            string inputdata2 = vaitro.Text;
            string inputdata3 = manv.Text;
            this.Dispose();
            QuanLyKhachHang khg = new QuanLyKhachHang(inputdata1, inputdata2, inputdata3);
            khg.Show();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            string inputdata1 = tennv.Text;
            string inputdata2 = vaitro.Text;
            string inputdata3 = manv.Text;
            this.Dispose();
            QuanLyDonHang khg = new QuanLyDonHang(inputdata1, inputdata2, inputdata3);
            khg.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string inputdata1 = tennv.Text;
            string inputdata2 = vaitro.Text;
            string inputdata3 = manv.Text;
            this.Dispose();
            ThongKe khg = new ThongKe(inputdata1, inputdata2, inputdata3);
            khg.Show();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string inputdata1 = tennv.Text;
            string inputdata2 = vaitro.Text;
            string inputdata3 = manv.Text;
            this.Dispose();
            DoiMatKhau khg = new DoiMatKhau(inputdata1, inputdata2, inputdata3);
            khg.Show();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            string inputdata1 = tennv.Text;
            string inputdata2 = vaitro.Text;
            string inputdata3 = manv.Text;
            this.Dispose();
            HuongDan khg = new HuongDan(inputdata1, inputdata2, inputdata3);
            khg.Show();
        }
    }
}
