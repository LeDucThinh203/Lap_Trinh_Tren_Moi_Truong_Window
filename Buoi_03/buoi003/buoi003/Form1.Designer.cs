namespace buoi003
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.checkBoxTheThao = new System.Windows.Forms.CheckBox();
            this.checkBoxPhimAnh = new System.Windows.Forms.CheckBox();
            this.checkBoxDuLich = new System.Windows.Forms.CheckBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.btnXuatThongTin = new System.Windows.Forms.Button();
            this.lblSoThich = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(95, 30);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(142, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(391, 30);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 1;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(95, 98);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(204, 98);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 2;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // checkBoxTheThao
            // 
            this.checkBoxTheThao.AutoSize = true;
            this.checkBoxTheThao.Checked = true;
            this.checkBoxTheThao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTheThao.Location = new System.Drawing.Point(380, 96);
            this.checkBoxTheThao.Name = "checkBoxTheThao";
            this.checkBoxTheThao.Size = new System.Drawing.Size(88, 20);
            this.checkBoxTheThao.TabIndex = 3;
            this.checkBoxTheThao.Text = "Thể Thao";
            this.checkBoxTheThao.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhimAnh
            // 
            this.checkBoxPhimAnh.AutoSize = true;
            this.checkBoxPhimAnh.Checked = true;
            this.checkBoxPhimAnh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPhimAnh.Location = new System.Drawing.Point(481, 97);
            this.checkBoxPhimAnh.Name = "checkBoxPhimAnh";
            this.checkBoxPhimAnh.Size = new System.Drawing.Size(85, 20);
            this.checkBoxPhimAnh.TabIndex = 3;
            this.checkBoxPhimAnh.Text = "Phim Ảnh";
            this.checkBoxPhimAnh.UseVisualStyleBackColor = true;
            // 
            // checkBoxDuLich
            // 
            this.checkBoxDuLich.AutoSize = true;
            this.checkBoxDuLich.Location = new System.Drawing.Point(582, 97);
            this.checkBoxDuLich.Name = "checkBoxDuLich";
            this.checkBoxDuLich.Size = new System.Drawing.Size(69, 20);
            this.checkBoxDuLich.TabIndex = 3;
            this.checkBoxDuLich.Text = "Du lịch";
            this.checkBoxDuLich.UseVisualStyleBackColor = true;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 16);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(318, 30);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // btnXuatThongTin
            // 
            this.btnXuatThongTin.Location = new System.Drawing.Point(608, 320);
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            this.btnXuatThongTin.Size = new System.Drawing.Size(119, 28);
            this.btnXuatThongTin.TabIndex = 5;
            this.btnXuatThongTin.Text = "Xuất Thông Tin";
            this.btnXuatThongTin.UseVisualStyleBackColor = true;
            this.btnXuatThongTin.Click += new System.EventHandler(this.btnXuatThongTin_Click);
            // 
            // lblSoThich
            // 
            this.lblSoThich.AutoSize = true;
            this.lblSoThich.Location = new System.Drawing.Point(316, 96);
            this.lblSoThich.Name = "lblSoThich";
            this.lblSoThich.Size = new System.Drawing.Size(54, 16);
            this.lblSoThich.TabIndex = 4;
            this.lblSoThich.Text = "Sở thích";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(28, 100);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.txtHoTen);
            this.grBox.Controls.Add(this.radNam);
            this.grBox.Controls.Add(this.lblSoThich);
            this.grBox.Controls.Add(this.lblGioiTinh);
            this.grBox.Controls.Add(this.lblNgaySinh);
            this.grBox.Controls.Add(this.radNu);
            this.grBox.Controls.Add(this.checkBoxDuLich);
            this.grBox.Controls.Add(this.lblHoTen);
            this.grBox.Controls.Add(this.checkBoxPhimAnh);
            this.grBox.Controls.Add(this.dtpNgaySinh);
            this.grBox.Controls.Add(this.checkBoxTheThao);
            this.grBox.Location = new System.Drawing.Point(34, 89);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(721, 160);
            this.grBox.TabIndex = 6;
            this.grBox.TabStop = false;
            this.grBox.Text = "Thông tin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grBox);
            this.Controls.Add(this.btnXuatThongTin);
            this.Name = "Form1";
            this.Text = "Demo MyClass";
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.CheckBox checkBoxTheThao;
        private System.Windows.Forms.CheckBox checkBoxPhimAnh;
        private System.Windows.Forms.CheckBox checkBoxDuLich;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnXuatThongTin;
        private System.Windows.Forms.Label lblSoThich;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.GroupBox grBox;
    }
}

