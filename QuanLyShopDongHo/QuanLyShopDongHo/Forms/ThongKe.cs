using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopDongHo.Forms
{
    public partial class ThongKe : Form
    {
        string inputdata1 = "";
        string inputdata2 = "";
        string inputdata3 = "";
        public ThongKe(string input1, string input2, string input3)
        {
            this.inputdata1 = input1;
            this.inputdata2 = input2;
            this.inputdata3 = input3;
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            tennv.Text = inputdata1;
            vaitro.Text = inputdata2;
            manv.Text = inputdata3;
            updatedgvDT();
            updatedgvLN();
            updatedgvKH();
            updatedgvDH();
            updatedgvXNK();
        }
        private bool IsValidInput(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TrangChu dn = new TrangChu(inputdata1, inputdata2, inputdata3);
            dn.Show();
        }

        private void updatedgvDT()
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT ChiTietSanPham.MaSP,\r\nSanPham.TenSanPham," +
                    "\r\nSUM(DonHang.SoLuong) as 'SoLuongBanRa'," +
                    "\r\n(((100-ChiTietSanPham.KhuyenMai)/100)*ChiTietSanPham.GiaBan) as 'GiaBanRa'" +
                    ",\r\n(((100-ChiTietSanPham.KhuyenMai)/100)*ChiTietSanPham.GiaBan) * SUM(DonHang.SoLuong) as 'DoanhThu'" +
                    "\r\nFROM DonHang INNER JOIN\r\nChiTietSanPham ON DonHang.LoaiSP = ChiTietSanPham.LoaiSP" +
                    " INNER JOIN\r\nSanPham ON ChiTietSanPham.MaSP = SanPham.MaSanPham\r\n" +
                    "GROUP BY ChiTietSanPham.MaSP,SanPham.TenSanPham,ChiTietSanPham.KhuyenMai," +
                    "ChiTietSanPham.GiaBan";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                    {
                        dgvDT.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvDT.Rows.Add(datareader["MaSP"], datareader["TenSanPham"],
                                datareader["SoLuongBanRa"], datareader["GiaBanRa"], datareader["DoanhThu"]) ;
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void updatedgvLN()
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT ChiTietSanPham.MaSP,\r\nSanPham.TenSanPham," +
                    "\r\n(SanPham.GiaNhap / SanPham.SoLuong) AS 'GiaTB'," +
                    "\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan) AS 'GiaBanRa'" +
                    ",\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan) - (SanPham.GiaNhap / SanPham.SoLuong) AS'LoiNhuan'\r\n" +
                    "FROM DonHang INNER JOIN ChiTietSanPham\r\nON DonHang.LoaiSP = ChiTietSanPham.LoaiSP " +
                    "INNER JOIN\r\nSanPham ON ChiTietSanPham.MaSP = SanPham.MaSanPham\r\n" +
                    "GROUP BY ChiTietSanPham.MaSP,\r\nSanPham.TenSanPham,\r\nSanPham.GiaNhap" +
                    ",\r\nSanPham.SoLuong,\r\nChiTietSanPham.KhuyenMai,\r\nChiTietSanPham.GiaBan";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                    {
                        dgvLN.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvLN.Rows.Add(datareader["MaSP"], datareader["TenSanPham"],
                                datareader["GiaTB"], datareader["GiaBanRa"], datareader["LoiNhuan"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void updatedgvKH()
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT KhachHang.TenKH, DonHang.SDT, KhachHang.DiaChi," +
                    " COUNT(DonHang.SDT) AS 'SoLanMua' FROM DonHang INNER JOIN\r\nKhachHang" +
                    " ON DonHang.SDT = KhachHang.SDT\r\nGROUP BY DonHang.SDT, KhachHang.TenKH," +
                    " KhachHang.DiaChi";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                    {
                        dgvKH.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvKH.Rows.Add(datareader["TenKH"], datareader["SDT"],
                                datareader["DiaChi"], datareader["SoLanMua"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void updatedgvDH()
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT DonHang.MaDon, ChiTietSanPham.TenLoai," +
                    " KhachHang.TenKH,\r\nDonHang.SoLuong, DonHang.NgayIn," +
                    " NhanVien.HoTen\r\nFROM ChiTietSanPham\r\nINNER JOIN " +
                    "DonHang ON ChiTietSanPham.LoaiSP = DonHang.LoaiSP\r\nINNER JOIN" +
                    " KhachHang ON DonHang.SDT = KhachHang.SDT\r\nINNER JOIN NhanVien" +
                    " ON DonHang.MaNV = NhanVien.MaNV";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                    {
                        dgvDH.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvDH.Rows.Add(datareader["MaDon"], datareader["TenLoai"],
                                datareader["TenKH"], datareader["SoLuong"], datareader["NgayIn"],
                                datareader["HoTen"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void updatedgvXNK()
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT SanPham.MaSanPham, SanPham.TenSanPham," +
                    " SanPham.SoLuong,\r\nSUM(DonHang.SoLuong) AS 'SoLuongBan'" +
                    ",(SanPham.SoLuong - SUM(DonHang.SoLuong)) AS 'SoLuongCon'\r\n" +
                    "FROM SanPham\r\nINNER JOIN ChiTietSanPham ON SanPham.MaSanPham" +
                    " = ChiTietSanPham.MaSP\r\nINNER JOIN DonHang ON ChiTietSanPham.LoaiSP" +
                    " = DonHang.LoaiSP\r\nGROUP BY SanPham.MaSanPham, SanPham.TenSanPham," +
                    " DonHang.SoLuong, SanPham.SoLuong";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (datareader.HasRows)
                    {
                        dgvXNK.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvXNK.Rows.Add(datareader["MaSanPham"], datareader["TenSanPham"],
                                datareader["SoLuong"], datareader["SoLuongBan"], datareader["SoLuongCon"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void btnTimMDT_Click(object sender, EventArgs e)
        {
            if(txtTimMDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã cần tìm");
                return;
            }
            else 
            {
                string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = "SELECT ChiTietSanPham.MaSP,\r\nSanPham.TenSanPham," +
                        "\r\nSUM(DonHang.SoLuong) as 'SoLuongBanRa'," +
                        "\r\n(((100-ChiTietSanPham.KhuyenMai)/100)*ChiTietSanPham.GiaBan) as 'GiaBanRa'" +
                        ",\r\n(((100-ChiTietSanPham.KhuyenMai)/100)*ChiTietSanPham.GiaBan) * SUM(DonHang.SoLuong) as 'DoanhThu'" +
                        "\r\nFROM DonHang INNER JOIN\r\nChiTietSanPham ON DonHang.LoaiSP = ChiTietSanPham.LoaiSP" +
                        " INNER JOIN\r\nSanPham ON ChiTietSanPham.MaSP = SanPham.MaSanPham WHERE ChiTietSanPham.MaSP = @matim\r\n" +
                        "GROUP BY ChiTietSanPham.MaSP,SanPham.TenSanPham,ChiTietSanPham.KhuyenMai," +
                        "ChiTietSanPham.GiaBan";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@matim", txtTimMDT.Text);
                        conn.Open();
                        SqlDataReader datareader = command.ExecuteReader();
                        if (!datareader.HasRows)
                        {
                            MessageBox.Show("Mã không tồn tại hoặc chưa bán được sản phẩm");
                            return;
                        }
                        else
                        {
                            dgvDT.Rows.Clear();

                            while (datareader.Read())
                            {
                                dgvDT.Rows.Add(datareader["MaSP"], datareader["TenSanPham"],
                                    datareader["SoLuongBanRa"], datareader["GiaBanRa"], datareader["DoanhThu"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void btnLMDT_Click(object sender, EventArgs e)
        {
            txtTimMDT.Text = "";
            DTden.Text = "";
            DTtu.Text = "";
            updatedgvDT();
        }

        private void btnLDT_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            if(int.TryParse(DTtu.Text, out number1))
            {
                if(number1 < 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương");
                return;
            }
            if(int.TryParse(DTden.Text, out number2))
            {
                if (number2 < 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương");
                return;
            }
            if(int.Parse(DTden.Text)< int.Parse(DTtu.Text))
            {
                MessageBox.Show("Số ở điểm cuối phải > điểm đầu");
                return;
            }
                string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = "SELECT ChiTietSanPham.MaSP,SanPham.TenSanPham,\r\n" +
                        "SUM(DonHang.SoLuong) as 'SoLuongBanRa',\r\n" +
                        "(((100-ChiTietSanPham.KhuyenMai)/100)*ChiTietSanPham.GiaBan)" +
                        " as 'GiaBanRa',\r\n(((100-ChiTietSanPham.KhuyenMai)/100)" +
                        "*ChiTietSanPham.GiaBan) * SUM(DonHang.SoLuong) as 'DoanhThu'\r\n" +
                        "FROM DonHang INNER JOIN ChiTietSanPham ON DonHang.LoaiSP = " +
                        "ChiTietSanPham.LoaiSP\r\nINNER JOIN SanPham ON ChiTietSanPham.MaSP = " +
                        "SanPham.MaSanPham\r\nGROUP BY ChiTietSanPham.MaSP,SanPham.TenSanPham," +
                        "ChiTietSanPham.KhuyenMai,\r\nChiTietSanPham.GiaBan\r\n" +
                        "HAVING (((100-ChiTietSanPham.KhuyenMai)/100)*ChiTietSanPham.GiaBan) " +
                        "* SUM(DonHang.SoLuong)\r\n>= @tu AND " +
                        "(((100-ChiTietSanPham.KhuyenMai)/100)*ChiTietSanPham.GiaBan)" +
                        " * SUM(DonHang.SoLuong)\r\n<= @den\r\n";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@tu", DTtu.Text);
                        command.Parameters.AddWithValue("@den", DTden.Text);
                        conn.Open();
                        SqlDataReader datareader = command.ExecuteReader();
                        if (!datareader.HasRows)
                        {
                            MessageBox.Show("Không có sản phẩm nằm trong khoảng doanh thu muốn tìm");
                            return;
                        }
                        else
                        {
                            dgvDT.Rows.Clear();

                            while (datareader.Read())
                            {
                                dgvDT.Rows.Add(datareader["MaSP"], datareader["TenSanPham"],
                                    datareader["SoLuongBanRa"], datareader["GiaBanRa"], datareader["DoanhThu"]);
                            }
                        }
                        conn.Close();
                    }
                }
        }

        private void btnMLN_Click(object sender, EventArgs e)
        {
            if(txtTLN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã cần tìm");
                return;
            }
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT ChiTietSanPham.MaSP,SanPham.TenSanPham" +
                    ",\r\n(SanPham.GiaNhap / SanPham.SoLuong) AS 'GiaTB'" +
                    ",\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan)" +
                    " AS 'GiaBanRa',\r\n(((100-ChiTietSanPham.KhuyenMai)/100)" +
                    " * ChiTietSanPham.GiaBan) - (SanPham.GiaNhap / SanPham.SoLuong)" +
                    " AS'LoiNhuan'\r\nFROM DonHang INNER JOIN ChiTietSanPham ON DonHang.LoaiSP" +
                    " = ChiTietSanPham.LoaiSP\r\nINNER JOIN SanPham ON ChiTietSanPham.MaSP" +
                    " = SanPham.MaSanPham\r\nWHERE ChiTietSanPham.MaSP = @timLN\r\nGROUP BY" +
                    " ChiTietSanPham.MaSP, SanPham.TenSanPham, SanPham.GiaNhap\r\n" +
                    ",SanPham.SoLuong,ChiTietSanPham.KhuyenMai,ChiTietSanPham.GiaBan";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@timLN", txtTLN.Text);
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (!datareader.HasRows)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm");
                        return;
                    }
                    else
                    {
                        dgvLN.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvLN.Rows.Add(datareader["MaSP"], datareader["TenSanPham"],
                                datareader["GiaTB"], datareader["GiaBanRa"], datareader["LoiNhuan"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void btnLLN_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            if (int.TryParse(txtLNtu.Text, out number1))
            {
                if (number1 < 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương");
                return;
            }
            if (int.TryParse(txtLNden.Text, out number2))
            {
                if (number2 < 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương");
                return;
            }
            if (int.Parse(txtLNden.Text) < int.Parse(txtLNtu.Text))
            {
                MessageBox.Show("Số ở điểm cuối phải > điểm đầu");
                return;
            }
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT ChiTietSanPham.MaSP,SanPham.TenSanPham" +
                    ",\r\n(SanPham.GiaNhap / SanPham.SoLuong) AS 'GiaTB'" +
                    ",\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan)" +
                    " AS 'GiaBanRa',\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan)" +
                    " - (SanPham.GiaNhap / SanPham.SoLuong) AS'LoiNhuan'\r\nFROM" +
                    " DonHang INNER JOIN ChiTietSanPham ON DonHang.LoaiSP =" +
                    " ChiTietSanPham.LoaiSP\r\nINNER JOIN SanPham ON ChiTietSanPham.MaSP " +
                    "= SanPham.MaSanPham\r\nGROUP BY ChiTietSanPham.MaSP, SanPham.TenSanPham" +
                    ", SanPham.GiaNhap\r\n,SanPham.SoLuong,ChiTietSanPham.KhuyenMai" +
                    ",ChiTietSanPham.GiaBan\r\nHAVING (((100-ChiTietSanPham.KhuyenMai)/100)" +
                    " * ChiTietSanPham.GiaBan) - (SanPham.GiaNhap / SanPham.SoLuong) " +
                    ">= @LNtu\r\nAND  (((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan)" +
                    " - (SanPham.GiaNhap / SanPham.SoLuong) <= @LNden";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@LNtu", txtLNtu.Text);
                    command.Parameters.AddWithValue("@LNden", txtLNden.Text);
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (!datareader.HasRows)
                    {
                        MessageBox.Show("Không có sản phẩm nằm trong khoảng lợi nhuận");
                        return;
                    }
                    else
                    {
                        dgvLN.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvLN.Rows.Add(datareader["MaSP"], datareader["TenSanPham"],
                                datareader["GiaTB"], datareader["GiaBanRa"], datareader["LoiNhuan"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void btnLO_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT ChiTietSanPham.MaSP,SanPham.TenSanPham" +
                    ",\r\n(SanPham.GiaNhap / SanPham.SoLuong) AS 'GiaTB'" +
                    ",\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan)" +
                    " AS 'GiaBanRa',\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan)" +
                    " - (SanPham.GiaNhap / SanPham.SoLuong) AS'LoiNhuan'\r\nFROM" +
                    " DonHang INNER JOIN ChiTietSanPham ON DonHang.LoaiSP =" +
                    " ChiTietSanPham.LoaiSP\r\nINNER JOIN SanPham ON ChiTietSanPham.MaSP " +
                    "= SanPham.MaSanPham\r\nGROUP BY ChiTietSanPham.MaSP, SanPham.TenSanPham" +
                    ", SanPham.GiaNhap\r\n,SanPham.SoLuong,ChiTietSanPham.KhuyenMai" +
                    ",ChiTietSanPham.GiaBan\r\nHAVING (((100-ChiTietSanPham.KhuyenMai)/100)" +
                    " * ChiTietSanPham.GiaBan) - (SanPham.GiaNhap / SanPham.SoLuong) " +
                    "< 0";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (!datareader.HasRows)
                    {
                        MessageBox.Show("Không có sản phẩm đang bán lỗ");
                        return;
                    }
                    else
                    {
                        dgvLN.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvLN.Rows.Add(datareader["MaSP"], datareader["TenSanPham"],
                                datareader["GiaTB"], datareader["GiaBanRa"], datareader["LoiNhuan"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void btnLOI_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT ChiTietSanPham.MaSP,SanPham.TenSanPham" +
                    ",\r\n(SanPham.GiaNhap / SanPham.SoLuong) AS 'GiaTB'" +
                    ",\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan)" +
                    " AS 'GiaBanRa',\r\n(((100-ChiTietSanPham.KhuyenMai)/100) * ChiTietSanPham.GiaBan)" +
                    " - (SanPham.GiaNhap / SanPham.SoLuong) AS'LoiNhuan'\r\nFROM" +
                    " DonHang INNER JOIN ChiTietSanPham ON DonHang.LoaiSP =" +
                    " ChiTietSanPham.LoaiSP\r\nINNER JOIN SanPham ON ChiTietSanPham.MaSP " +
                    "= SanPham.MaSanPham\r\nGROUP BY ChiTietSanPham.MaSP, SanPham.TenSanPham" +
                    ", SanPham.GiaNhap\r\n,SanPham.SoLuong,ChiTietSanPham.KhuyenMai" +
                    ",ChiTietSanPham.GiaBan\r\nHAVING (((100-ChiTietSanPham.KhuyenMai)/100)" +
                    " * ChiTietSanPham.GiaBan) - (SanPham.GiaNhap / SanPham.SoLuong) " +
                    "> 0";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader datareader = command.ExecuteReader();

                    if (!datareader.HasRows)
                    {
                        MessageBox.Show("Không có sản phẩm đang bán lời");
                        return;
                    }
                    else
                    {
                        dgvLN.Rows.Clear();

                        while (datareader.Read())
                        {
                            dgvLN.Rows.Add(datareader["MaSP"], datareader["TenSanPham"],
                                datareader["GiaTB"], datareader["GiaBanRa"], datareader["LoiNhuan"]);
                        }
                    }

                    conn.Close();
                }
            }
        }

        private void btnLMLN_Click(object sender, EventArgs e)
        {
            txtLNden.Text = "";
            txtLNtu.Text = "";
            txtTLN.Text = "";
            updatedgvLN();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (rdTen.Checked)
            {
              
                if (txtTimKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm");
                    return;
                }
                else
                {
                    string input = txtTimKH.Text;

                    if (!IsValidInput(input))
                    {
                        MessageBox.Show("Vui lòng chỉ nhập chữ cái và khoảng trắng.");
                        return;
                    }
                    string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        string query = "SELECT KhachHang.TenKH, DonHang.SDT" +
                            ", KhachHang.DiaChi,\r\nCOUNT(DonHang.SDT) AS " +
                            "'SoLanMua' FROM DonHang INNER JOIN KhachHang\r\n" +
                            "ON DonHang.SDT = KhachHang.SDT WHERE KhachHang.TenKH " +
                            "LIKE @timten\r\nGROUP BY DonHang.SDT, KhachHang.TenKH" +
                            ",\r\nKhachHang.DiaChi";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@timten", "%" + txtTimKH.Text);
                            conn.Open();
                            SqlDataReader datareader = command.ExecuteReader();

                            if (!datareader.HasRows)
                            {
                                MessageBox.Show("Không tìm thấy khách hàng đã từng giao dịch");
                                return;
                            }
                            else
                            {
                                dgvKH.Rows.Clear();

                                while (datareader.Read())
                                {
                                    dgvKH.Rows.Add(datareader["TenKH"], datareader["SDT"],
                                        datareader["DiaChi"], datareader["SoLanMua"]);
                                }
                            }

                            conn.Close();
                        }
                    }
                }
            }
            else if (rdSDT.Checked)
            {
                if (txtTimKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại cần tìm");
                    return;
                }
                else
                {
                    int so;
                    if(int.TryParse(txtTimKH.Text, out so))
                    {
                        string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            string query = "SELECT KhachHang.TenKH, DonHang.SDT" +
                                ", KhachHang.DiaChi,\r\nCOUNT(DonHang.SDT) AS " +
                                "'SoLanMua' FROM DonHang INNER JOIN KhachHang\r\n" +
                                "ON DonHang.SDT = KhachHang.SDT WHERE KhachHang.SDT " +
                                "LIKE @timten\r\nGROUP BY DonHang.SDT, KhachHang.TenKH" +
                                ",\r\nKhachHang.DiaChi";
                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@timten", "%" + int.Parse(txtTimKH.Text));
                                conn.Open();
                                SqlDataReader datareader = command.ExecuteReader();

                                if (!datareader.HasRows)
                                {
                                    MessageBox.Show("Không tìm thấy khách hàng đã từng giao dịch");
                                    return;
                                }
                                else
                                {
                                    dgvKH.Rows.Clear();

                                    while (datareader.Read())
                                    {
                                        dgvKH.Rows.Add(datareader["TenKH"], datareader["SDT"],
                                            datareader["DiaChi"], datareader["SoLanMua"]);
                                    }
                                }

                                conn.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chỉ nhập số");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cách thức tìm");
                return;
            }
           
        }

        private void btnLMKH_Click(object sender, EventArgs e)
        {
            txtTimKH.Text = "";
            rdSDT.Checked = false;
            rdTen.Checked = false;
            updatedgvKH();
        }

        private void btntimDH_Click(object sender, EventArgs e)
        {
            if (txttimDH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng");
                return;
            }
            else
            {
                string connection = @"Data Source =.; Initial Catalog = QuanLyShopDongHo; Integrated security = SSPI";
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = "SELECT DonHang.MaDon, ChiTietSanPham.TenLoai," +
                        " KhachHang.TenKH,\r\nDonHang.SoLuong, DonHang.NgayIn," +
                        " NhanVien.HoTen\r\nFROM ChiTietSanPham\r\nINNER JOIN " +
                        "DonHang ON ChiTietSanPham.LoaiSP = DonHang.LoaiSP\r\nINNER JOIN" +
                        " KhachHang ON DonHang.SDT = KhachHang.SDT\r\nINNER JOIN NhanVien" +
                        " ON DonHang.MaNV = NhanVien.MaNV WHERE DonHang.MaDon = @timDH";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@timDH", txttimDH.Text);
                        conn.Open();
                        SqlDataReader datareader = command.ExecuteReader();

                        if (!datareader.HasRows)
                        {
                            MessageBox.Show("Không tìm thấy đơn hàng");
                            return;
                        }
                        else
                        {
                            dgvDH.Rows.Clear();

                            while (datareader.Read())
                            {
                                dgvDH.Rows.Add(datareader["MaDon"], datareader["TenLoai"],
                                    datareader["TenKH"], datareader["SoLuong"], datareader["NgayIn"],
                                    datareader["HoTen"]);
                            }
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void btnLMDH_Click(object sender, EventArgs e)
        {
            txttimDH.Text = "";
            updatedgvDH();
        }
    }
}
