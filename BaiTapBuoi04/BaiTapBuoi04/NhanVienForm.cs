using System;
using System.Windows.Forms;

namespace BaiTapBuoi04
{
    public partial class NhanVienForm : Form
    {
        public NhanVien NewNhanVien { get; set; }

        public NhanVienForm()
        {
            InitializeComponent();
        }

        public NhanVienForm(NhanVien existingNhanVien)
        {
            InitializeComponent();

            // Kiểm tra nếu đối tượng truyền vào không null
            if (existingNhanVien != null)
            {
                // Gán giá trị từ đối tượng vào các TextBox
                txtMSSV.Text = existingNhanVien.MSSV;
                txtTenNhanVien.Text = existingNhanVien.Name;
                txtLuongCanBan.Text = existingNhanVien.LuongCB.ToString();

                // MSSV không thể sửa đổi
                txtMSSV.Enabled = false;

                // Gán thông tin nhân viên vào thuộc tính NewNhanVien để chỉnh sửa
                NewNhanVien = existingNhanVien;
            }
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thêm logic nếu cần
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng nhập đầy đủ thông tin
            if (string.IsNullOrEmpty(txtMSSV.Text) || string.IsNullOrEmpty(txtTenNhanVien.Text) || string.IsNullOrEmpty(txtLuongCanBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng NhanVien từ các giá trị trong các TextBox
            NewNhanVien = new NhanVien
            {
                MSSV = txtMSSV.Text,
                Name = txtTenNhanVien.Text,
                LuongCB = int.Parse(txtLuongCanBan.Text) // Lưu ý cần kiểm tra số liệu đầu vào, tránh lỗi
            };

            // Đóng form và trả về kết quả OK
            DialogResult = DialogResult.OK;
            Close();
        }

        // Lớp NhanVien (mới đặt tên cho rõ ràng)
        public class NhanVien
        {
            public string MSSV { get; set; }
            public string Name { get; set; }
            public int LuongCB { get; set; }
        }
    }
}
