using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace QuanLyShopDongHo.Forms
{
    public partial class QuenMatKhau : Form
    {

        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private string mxn;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email xác nhận");
                return;
            }
            string email = txtEmail.Text;
            if (IsValidEmail(email))
            { }
            else
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }
            using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
            {
                List<NhanVien> list = db.NhanViens
                  .Where(x => (x.Email == txtEmail.Text))
                  .ToList();//sắp xếp ở đây
                if (!list.Any())
                {
                    MessageBox.Show("Email không có trong hệ thống tài khoản");
                    return;
                }
                else
                {
                    Random random = new Random();
                    string randomNumberString = "";
                    for (int i = 0; i < 6; i++)
                    {
                        randomNumberString += random.Next(0, 10).ToString(); // Tạo số ngẫu nhiên từ 0 đến 9 và thêm vào chuỗi
                    }
                    mxn = (randomNumberString);
                    var fromAddress = new MailAddress("nle040525@gmail.com", "From Name");
                    var toAddress = new MailAddress(txtEmail.Text, "To Name");
                    const string fromPassword = "pxpn njhs jzjr qmof";
                    const string subject = "Mã xác nhận";
                    const string body = "Mã xác nhận của bạn là:";

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body + mxn
                    })
                    {
                        smtp.Send(message);
                    }

                    MessageBox.Show("Mã xác nhận đã được gửi. Vui lòng check Email");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMaXN.Text == mxn)
            {
                using (QuanLyShopDongHoEntities db = new QuanLyShopDongHoEntities())
                {
                    List<NhanVien> list = db.NhanViens
                    .Where(x => (x.Email == txtEmail.Text))
                    .ToList();//sắp xếp ở đây

                    list.ForEach(tk =>
                    {
                        string inputdata1 = tk.MaNV;
                        this.Dispose();
                        DoiMKMoi dmkm = new DoiMKMoi(inputdata1);
                        dmkm.Show();
                    });
                }
               
            }
            else
            {
                MessageBox.Show("Mã xác nhận không chính xác");
                return;
            }
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DangNhap dn = new DangNhap();
            dn.Show();
        }
    }
}
