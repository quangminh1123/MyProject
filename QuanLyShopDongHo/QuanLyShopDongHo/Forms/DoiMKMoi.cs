using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopDongHo.Forms
{
    public partial class DoiMKMoi : Form
    {
        string inputdata1;
        public DoiMKMoi(string input1)
        {
            InitializeComponent();
            this.inputdata1 = input1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkk())
            {
                MD5 md5 = MD5.Create();
                byte[] pass = Encoding.UTF8.GetBytes(xnMK.Text);
                byte[] hash = md5.ComputeHash(pass);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                string pu = builder.ToString();
                using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
                {
                    NhanVien sua = db.NhanViens.Where(x => x.MaNV == MaTK.Text)
                               .FirstOrDefault();
                    sua.MatKhau = pu;
                    db.SaveChanges();
                }
                this.Close();
                DangNhap dn = new DangNhap();
                dn.Show();
            }

        }

        private void DoiMKMoi_Load(object sender, EventArgs e)
        {
            MaTK.Text = inputdata1;
            mkMoi.PasswordChar = '\u2022';
            xnMK.PasswordChar = '\u2022';
        }

        private bool checkk()
        {
            if (mkMoi.Text == "" || xnMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }

            if (mkMoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải >= 6 kí tự");
                return false;
            }

            if (!(xnMK.Text == mkMoi.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp");
                return false;
            }

            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mkMoi.PasswordChar = '\0';
                xnMK.PasswordChar = '\0';
            }
            else
            {
                mkMoi.PasswordChar = '\u2022';
                xnMK.PasswordChar = '\u2022';
            }
        }
    }
}
