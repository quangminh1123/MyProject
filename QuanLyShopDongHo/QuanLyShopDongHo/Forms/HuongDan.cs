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
    public partial class HuongDan : Form
    {
        string inputdata1 = "";
        string inputdata2 = "";
        string inputdata3 = "";
        public HuongDan(string input1, string input2, string input3)
        {
            this.inputdata1 = input1;
            this.inputdata2 = input2;
            this.inputdata3 = input3;
            InitializeComponent();
        }

        private void HuongDan_Load(object sender, EventArgs e)
        {
            tennv.Text = inputdata1;
            vaitro.Text = inputdata2;
            manv.Text = inputdata3;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TrangChu dn = new TrangChu(inputdata1, inputdata2, inputdata3);
            dn.Show();
        }
    }
}
