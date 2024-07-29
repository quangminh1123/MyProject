using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace QuanLyShopDongHo.Forms
{
    public partial class DoiMatKhau : Form
    {
        string inputdata1 = "";
        string inputdata2 = "";
        string inputdata3 = "";
        public DoiMatKhau(string input1, string input2, string input3)
        {
            this.inputdata1 = input1;
            this.inputdata2 = input2;
            this.inputdata3 = input3;
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            tennv.Text = inputdata1;
            vaitro.Text = inputdata2;
            manv.Text = inputdata3;
            txtTaiKhoan.Text = inputdata3;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TrangChu dn = new TrangChu(inputdata1, inputdata2, inputdata3);
            dn.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauCu = MaHoaPass(txtMatKhauCu.Text);
            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
            {
                var taiKhoan = db.NhanViens.Where(x => x.MaNV == txtTaiKhoan.Text).ToList();
                taiKhoan.ForEach(x =>
                {
                    if (matKhauCu == x.MatKhau)
                    {
                        if (txtMatKhauMoi.Text.Length < 6)
                        {
                            MessageBox.Show("Mật khẩu mới ít nhất có 6 kí tự", "Thông báo");
                            txtMatKhauMoi.Focus();
                        }
                        else if (txtMatKhauMoi.Text == txtMatKhauXacNhan.Text)
                        {
                            var taiKhoanDoi = db.NhanViens.Where(y => y.MaNV == txtTaiKhoan.Text).FirstOrDefault();
                            taiKhoanDoi.MatKhau = MaHoaPass(txtMatKhauMoi.Text);
                            db.SaveChanges();
                            MessageBox.Show("Mật khẩu đã đổi thành công của nhân viên có mã: " + txtTaiKhoan.Text, "Thông báo");
                            this.Dispose();
                            DangNhap dn = new DangNhap();
                            dn.Show();
                        }
                        else
                            MessageBox.Show("Mật khẩu xác nhận lại không đúng", "Thông báo");
                    }
                    else
                        MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo");
                });
            }
        }

        private string MaHoaPass(string chuoi)
        {
            using (MD5 mD5 = MD5.Create())
            {
                byte[] pass = Encoding.UTF8.GetBytes(chuoi);
                byte[] hash = mD5.ComputeHash(pass);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked)
            {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtMatKhauXacNhan.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtMatKhauXacNhan.UseSystemPasswordChar = true;
            }
        }

        private void Closing_DMK(object sender, FormClosingEventArgs e)
        {
            TrangChu dn = new TrangChu(inputdata1, inputdata2, inputdata3);
            dn.Show();
        }
    }
}
