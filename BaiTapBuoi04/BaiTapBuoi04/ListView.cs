using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTapBuoi04
{
    public partial class ListView : Form
    {
        private List<NhanVienForm.NhanVien> nvList = new List<NhanVienForm.NhanVien>();

        public ListView()
        {
            InitializeComponent();
        }
        private void DisplayNhanVien(NhanVienForm.NhanVien nhanVien)
        {
            // Tạo một ListViewItem mới với thông tin MSSV
            ListViewItem listViewItem = new ListViewItem(nhanVien.MSSV);

            // Thêm các thông tin khác vào các cột phụ
            listViewItem.SubItems.Add(nhanVien.Name);
            listViewItem.SubItems.Add(nhanVien.LuongCB.ToString());

            // Thêm item này vào ListView
            listView1.Items.Add(listViewItem);
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            // Thêm cột vào ListView nếu chưa có
            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("MSNV", 50);
                listView1.Columns.Add("Tên", 150);
                listView1.Columns.Add("Lương Cơ Bản", 100);
            }

            // Xóa các mục cũ trong ListView nếu có
            listView1.Items.Clear();

            // Tạo một nhân viên mẫu
            var nhanVien = new NhanVienForm.NhanVien
            {
                MSSV = "NV001",
                Name = "Nguyễn Thị Thu Hiền",
                LuongCB = 8500000
            };
            DisplayNhanVien(nhanVien);
            // Duyệt qua danh sách nhân viên và thêm vào ListView
            foreach (var item in nvList)
            {
                // Tạo một ListViewItem với MSSV
                ListViewItem listViewItem = new ListViewItem(item.MSSV);

                // Thêm Tên và Lương cơ bản vào các cột phụ
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.LuongCB.ToString());

                // Thêm item vào ListView
                listView1.Items.Add(listViewItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVienForm formNhanVien = new NhanVienForm();
            DialogResult result = formNhanVien.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lấy thông tin nhân viên từ form Nhân viên
                NhanVienForm.NhanVien newNhanVien = formNhanVien.NewNhanVien;

                // Thêm nhân viên mới vào danh sách và cập nhật lại ListView
                nvList.Add(newNhanVien);
                ListView_Load(sender, e);  // Cập nhật lại ListView
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string mssv = selectedItem.SubItems[0].Text;

                var selectedNhanVien = nvList.Find(nv => nv.MSSV == mssv);
                if (selectedNhanVien != null)
                {
                    // Hiển thị form chỉnh sửa
                    NhanVienForm formNhanVien = new NhanVienForm(selectedNhanVien);
                    DialogResult result = formNhanVien.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Cập nhật lại thông tin nhân viên trong danh sách
                        selectedNhanVien.Name = formNhanVien.NewNhanVien.Name;
                        selectedNhanVien.LuongCB = formNhanVien.NewNhanVien.LuongCB;

                        // Cập nhật lại ListView
                        ListView_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string mssv = selectedItem.SubItems[0].Text;

                var selectedNhanVien = nvList.Find(nv => nv.MSSV == mssv);
                if (selectedNhanVien != null)
                {
                    DialogResult confirmResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhân viên này không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Xóa nhân viên khỏi danh sách
                        nvList.Remove(selectedNhanVien);

                        // Cập nhật lại ListView
                        ListView_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
