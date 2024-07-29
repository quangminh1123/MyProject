using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace QuanLyShopDongHo.Forms
{
    public partial class ThanhToanDonHang : Form
    {
        private PrintDocument printDocument = new PrintDocument();

        public ThanhToanDonHang(string maDH)
        {
            InitializeComponent();
            lblMaDon.Text = maDH;
            label11.Height = 2;
        }

        private void ThanhToanDonHang_Load(object sender, EventArgs e)
        {
            using (var db = new QuanLyShopDongHoEntities())
            {
                lblSDT.Text = db.DonHangs.Where(x => x.MaDon == lblMaDon.Text)
                              .Select(x => x.SDT).FirstOrDefault().ToString();
                lblTenKH.Text = db.DonHangs.Where(x => x.MaDon == lblMaDon.Text)
                              .Select(x => x.TenKH).FirstOrDefault().ToString();
                lblNgayIn.Text = db.DonHangs.Where(x => x.MaDon == lblMaDon.Text)
                              .Select(x => x.NgayIn).FirstOrDefault().ToString("dd/MM/yyyy");
                lblLoaiSP.Text = db.DonHangs.Where(x => x.MaDon == lblMaDon.Text)
                              .Select(x => x.LoaiSP).FirstOrDefault().ToString();
                lblTenLoai.Text = db.DonHangs.Where(x => x.MaDon == lblMaDon.Text)
                              .Select(x => x.ChiTietSanPham.TenLoai).FirstOrDefault().ToString();
                lblSoLuong.Text = db.DonHangs.Where(x => x.MaDon == lblMaDon.Text)
                              .Select(x => x.SoLuong).FirstOrDefault().ToString();
                lblDonGia.Text = db.DonHangs.Where(x => x.MaDon == lblMaDon.Text)
                              .Select(x => x.ChiTietSanPham.GiaBan).FirstOrDefault().ToString("#,##0");
                int soLuong = int.Parse(lblSoLuong.Text);
                double donGia = float.Parse(lblDonGia.Text);
                double tongTien = soLuong * donGia;
                lblTongTien.Text = tongTien.ToString("#,##0");
            }
        }

        private void btnXuatDon_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("MyPaper", 228, 300);
            print.AllowSomePages = true;
            print.ShowHelp = true;
            print.Document = printDocument;
            DialogResult result = print.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.PrintPage += new PrintPageEventHandler(document_PrintPage);
                printDocument.Print();
            }
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string title = "\t\t\tĐƠN HÀNG";
            string text = Environment.NewLine + "\t\t" + label2.Text + lblMaDon.Text + Environment.NewLine
             + "\t\t" + label4.Text + lblSDT.Text + Environment.NewLine
             + "\t\t" + label3.Text + lblTenKH.Text + Environment.NewLine
             + "\t\t" + label10.Text + lblNgayIn.Text + Environment.NewLine
             + "\t\t" + label5.Text+ "\t\t" + label6.Text + "\t\t" + label8.Text + "\t" + label7.Text+ Environment.NewLine
             + "\t\t" + lblLoaiSP.Text + "\t\t" + lblTenLoai.Text + "\t\t" + lblSoLuong.Text + "\t" + lblDonGia.Text + Environment.NewLine
             + "\t\t" + label11.Text + Environment.NewLine
             + "\t\t\t\t\t\t\t" + label9.Text + lblTongTien.Text;

            System.Drawing.Font printFont1 = new System.Drawing.Font
                ("Times New Roman", 18, System.Drawing.FontStyle.Bold);
            e.Graphics.DrawString(title, printFont1,
                System.Drawing.Brushes.Black, 10, 10);
            System.Drawing.Font printFont2 = new System.Drawing.Font
                ("Times New Roman", 12, System.Drawing.FontStyle.Regular);
            e.Graphics.DrawString(text, printFont2,
                System.Drawing.Brushes.Black, 10, 10);
            MessageBox.Show("Đơn hàng đã được xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
