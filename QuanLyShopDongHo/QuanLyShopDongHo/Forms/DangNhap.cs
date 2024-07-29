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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu");
                return;
            }

            if(txtMK.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải >= 6 kí tự");
                return;
            }

            MD5 md5 = MD5.Create();
            byte[] pass = Encoding.UTF8.GetBytes(txtMK.Text);
            byte[] hash = md5.ComputeHash(pass);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("x2"));
            }
            string pw = builder.ToString();
            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
            {
                List<NhanVien> list = db.NhanViens
                   .Where(x => (x.MaNV == txtMaNV.Text))
                   .ToList();
                if (!list.Any())
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    return;
                }
                else
                {
                    list.ForEach(tk =>
                    {
                        if (tk.MatKhau == pw && tk.VaiTro == "Quản Trị")
                        {
                            string inputdata1 = tk.HoTen.ToString();
                            string inputdata2 = tk.VaiTro.ToString();
                            string inputdata3 = tk.MaNV.ToString();
                            TrangChu tc = new TrangChu(inputdata1, inputdata2, inputdata3);
                            this.Hide();
                            tc.Show();
                            DangNhap dn = new DangNhap();
                            dn.Dispose();
                        }
                        else if (tk.MatKhau == pw && tk.VaiTro == "Nhân Viên")
                        {
                            string inputdata1 = tk.HoTen.ToString();
                            string inputdata2 = tk.VaiTro.ToString();
                            string inputdata3 = tk.MaNV.ToString();
                            TrangChu tc = new TrangChu(inputdata1, inputdata2, inputdata3);
                            this.Hide();
                            tc.Show();
                            DangNhap dn = new DangNhap();
                            dn.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                            return;
                        }
                    });
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '\u2022';
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '\u2022';
        }

        private void Quenmk_Click(object sender, EventArgs e)
        {
            QuenMatKhau qmk = new QuenMatKhau();
            this.Hide();
            qmk.Show();
            DangNhap dn = new DangNhap();
            dn.Dispose();
        }
    }
}
