using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            List<int> listSize = new List<int> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var s in listSize)
            {
                toolStripComboBox2.Items.Add(s);
            }
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";
            saveFileDialog.Title = "Lưu file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog.FilterIndex == 1)
                    {
                        // Lưu file RTF
                        richText.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        // Lưu file TXT (UTF-8)
                        richText.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.UnicodePlainText);
                    }
                    MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";
            openFileDialog.Title = "Mở file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog.FilterIndex == 1)
                    {
                        // Mở file RTF
                        richText.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        // Mở file TXT (UTF-8)
                        richText.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.UnicodePlainText);
                    }
                    MessageBox.Show("Mở file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi mở file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle = currentFont.Underline ? currentFont.Style & ~FontStyle.Underline : currentFont.Style | FontStyle.Underline;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đoạn văn bản để áp dụng định dạng gạch chân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
            openFileDialog.Title = "Mở file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richText.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Mở file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi mở file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog.Title = "Lưu file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richText.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }





        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                string selectedFont = toolStripComboBox1.SelectedItem.ToString();
                Font currentFont = richText.SelectionFont;
                richText.SelectionFont = new Font(selectedFont, currentFont.Size, currentFont.Style);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đoạn văn bản để thay đổi font chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                float selectedSize;
                if (float.TryParse(toolStripComboBox2.SelectedItem.ToString(), out selectedSize))
                {
                    Font currentFont = richText.SelectionFont;
                    richText.SelectionFont = new Font(currentFont.FontFamily, selectedSize, currentFont.Style);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đoạn văn bản để thay đổi kích thước chữ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn tạo mới và lưu văn bản?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Save_Click(sender, e);
            
            richText.Clear();
        }// Xóa nội dung cũ
            else
            {
                richText.Clear();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle = currentFont.Bold ? currentFont.Style & ~FontStyle.Bold : currentFont.Style | FontStyle.Bold;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đoạn văn bản để áp dụng định dạng in đậm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle = currentFont.Italic ? currentFont.Style & ~FontStyle.Italic : currentFont.Style | FontStyle.Italic;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đoạn văn bản để áp dụng định dạng in nghiêng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            richText.Clear();
        }
    }
}