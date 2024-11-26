using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace buoi003
{
    public partial class FormHocList : Form
    {
        public FormHocList()
        {
            InitializeComponent();
        }

        private void FromHocList_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtFirstName.Text);
            lvi.SubItems.Add(txtLastName.Text);
            lvi.SubItems.Add(txtPhone.Text);
            lvStudent.Items.Add(lvi);
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvStudent.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvStudent.SelectedItems[0];
                txtFirstName.Text = selectedItem.Text;
                txtLastName.Text = selectedItem.SubItems[1].Text;
                txtPhone.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvStudent.SelectedItems[0];
                selectedItem.SubItems[0].Text = txtFirstName.Text;
                selectedItem.SubItems[1].Text = txtLastName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                lvStudent.Items.Remove(lvStudent.SelectedItems[0]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}