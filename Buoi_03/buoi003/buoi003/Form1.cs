using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            CultureInfo culture = new CultureInfo("en-US");
            string ngaySinh = dtpNgaySinh.Value.ToString("MM/dd/yyyy hh:mm:ss tt", culture);

            // Kiểm tra sở thích
            string soThich = "";
            if (checkBoxTheThao.Checked) soThich += "Thể thao, ";
            if (checkBoxPhimAnh.Checked) soThich += "Phim ảnh, ";
            if (checkBoxDuLich.Checked) soThich += "Du lịch, ";

            // Xóa dấu phẩy cuối chuỗi nếu có
            if (!string.IsNullOrEmpty(soThich))
            {
                soThich = soThich.TrimEnd(',', ' ');
            }

            // Hiển thị thông tin
            string thongTin = string.Format("Họ tên: {0}, Giới tính: {1}, Ngày sinh: {2}, Sở thích: {3}", hoTen, gioiTinh, ngaySinh, soThich);

            MessageBox.Show(thongTin, "Thông tin người dùng");
        }
    }
    
}
