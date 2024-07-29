using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyShopDongHo.Forms
{
    public partial class QuanLyKhachHang : Form
    {
        string inputdata1 = "";
        string inputdata2 = "";
        string inputdata3 = "";
        public QuanLyKhachHang(string input1, string input2, string input3)
        {
            this.inputdata1 = input1;
            this.inputdata2 = input2;
            this.inputdata3 = input3;
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            tennv.Text = inputdata1;
            vaitro.Text = inputdata2;
            manv.Text = inputdata3;
            ShowKH();
        }

        private void ShowKH()
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                dgvKhachHang.Rows.Clear();
                db.KhachHangs.ToList().ForEach(x => dgvKhachHang.Rows.Add(x.TenKH, x.SDT, x.DiaChi));
            }
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private bool checkForm()
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                var sdtTrung = db.KhachHangs.Select(x => x.SDT).FirstOrDefault();
                int so;
                if (txtTenKhachHang.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenKhachHang.Focus();
                    return false;
                }
                else if (!IsValidInput(txtTenKhachHang.Text))
                {
                    txtTenKhachHang.Focus();
                    return false;
                }
                else if (txtSDT.Text.Length != 10)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại đủ 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return false;
                }
                else if (txtSDT.Text.Contains(" "))
                {
                    MessageBox.Show("Số điện thoại không chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return false;
                }
                else if (int.TryParse(txtSDT.Text, out so) == false)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                    return false;
                }
                else if (txtDiaChi.Text.StartsWith(" "))
                {
                    MessageBox.Show("Địa chỉ không bắt đầu bằng khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiaChi.Focus();
                    return false;
                }
                else
                    return true;
            }
        }
        private bool IsValidInput(string input)
        {
            foreach (char c in input)
            {
                if(input.StartsWith(" "))
                {
                    MessageBox.Show("Họ tên không bắt đầu bằng khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Họ tên chỉ nhập chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QuanLyShopDongHoEntities())
                {
                    if (checkForm())
                    {
                        KhachHang kh = new KhachHang();
                        kh.TenKH = txtTenKhachHang.Text;
                        kh.SDT = txtSDT.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        db.KhachHangs.Add(kh);
                        db.SaveChanges();
                        Rong();
                    }
                }            
                ShowKH();
            }
            catch (Exception)
            {

                MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                if (checkForm())
                {
                    var capNhat = db.KhachHangs.Where(x => x.SDT == txtSDT.Text).FirstOrDefault();
                    capNhat.TenKH = txtTenKhachHang.Text;
                    capNhat.DiaChi = txtDiaChi.Text;
                    db.SaveChanges();
                    txtTenKhachHang.Text = "";
                    txtSDT.Text = "";
                    txtDiaChi.Text = "";
                    txtTenKhachTim.Text = "";
                    btnThem.Enabled = true;
                    txtSDT.ReadOnly = false;
                    btnCapNhat.Enabled = false;
                    btnXoa.Enabled = false;
                    Rong();
                    ShowKH();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new QuanLyShopDongHoEntities())
                {
                    var xoa = db.KhachHangs.Where(x => x.SDT == txtSDT.Text).FirstOrDefault();
                    db.KhachHangs.Remove(xoa);
                    db.SaveChanges();
                    Rong();
                    ShowKH();
                    btnThem.Enabled = true;
                    txtSDT.ReadOnly = false;
                    btnCapNhat.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi - khách hàng đã có hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Rong();
            ShowKH();
            btnThem.Enabled = true;
            txtSDT.ReadOnly = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TrangChu dn = new TrangChu(inputdata1, inputdata2, inputdata3);
            dn.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                List<KhachHang> tenKH = db.KhachHangs.Where(x => x.TenKH.Contains(txtTenKhachTim.Text.Trim())).ToList();
                if (tenKH.Count > 0)
                {
                    dgvKhachHang.Rows.Clear();
                    tenKH.ForEach(x =>
                    {
                        dgvKhachHang.Rows.Add(x.TenKH, x.SDT, x.DiaChi);
                    });
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowKH();
                }
                if (vaitro.Text == "Nhân Viên")
                {
                    btnCapNhat.Enabled = true;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    btnCapNhat.Enabled = true;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            else
            {
                txtTenKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.ReadOnly = true;
            }        
            using (var db = new QuanLyShopDongHoEntities())
            {              
                if (vaitro.Text == "Nhân Viên")
                {
                    btnCapNhat.Enabled = true;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    btnCapNhat.Enabled = true;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void Rong()
        {
            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTenKhachTim.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
             Color.Silver, 3, ButtonBorderStyle.Solid,
             Color.Silver, 3, ButtonBorderStyle.Solid,
             Color.Silver, 3, ButtonBorderStyle.Solid,
             Color.Silver, 3, ButtonBorderStyle.Solid);
        }
    }
}
