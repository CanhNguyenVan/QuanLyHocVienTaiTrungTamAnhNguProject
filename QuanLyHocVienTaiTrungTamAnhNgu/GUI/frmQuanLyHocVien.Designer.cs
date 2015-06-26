namespace GUI
{
    partial class frmQuanLyHocVien
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
            this.dataGridViewQuanLyHocVien = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ChinhSuaHoSo = new System.Windows.Forms.Button();
            this.cbx_GioiTinh = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NgheNghiep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenHocVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaHocVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyHocVien
            // 
            this.dataGridViewQuanLyHocVien.AllowDrop = true;
            this.dataGridViewQuanLyHocVien.AllowUserToAddRows = false;
            this.dataGridViewQuanLyHocVien.AllowUserToDeleteRows = false;
            this.dataGridViewQuanLyHocVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyHocVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewQuanLyHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyHocVien.Location = new System.Drawing.Point(12, 266);
            this.dataGridViewQuanLyHocVien.Name = "dataGridViewQuanLyHocVien";
            this.dataGridViewQuanLyHocVien.ReadOnly = true;
            this.dataGridViewQuanLyHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyHocVien.Size = new System.Drawing.Size(606, 224);
            this.dataGridViewQuanLyHocVien.TabIndex = 0;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(452, 496);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(543, 496);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_ChinhSuaHoSo
            // 
            this.btn_ChinhSuaHoSo.Location = new System.Drawing.Point(12, 496);
            this.btn_ChinhSuaHoSo.Name = "btn_ChinhSuaHoSo";
            this.btn_ChinhSuaHoSo.Size = new System.Drawing.Size(111, 23);
            this.btn_ChinhSuaHoSo.TabIndex = 3;
            this.btn_ChinhSuaHoSo.Text = "Chỉnh sửa hồ sơ";
            this.btn_ChinhSuaHoSo.UseVisualStyleBackColor = true;
            this.btn_ChinhSuaHoSo.Click += new System.EventHandler(this.btn_ChinhSuaHoSo_Click);
            // 
            // cbx_GioiTinh
            // 
            this.cbx_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_GioiTinh.Location = new System.Drawing.Point(218, 120);
            this.cbx_GioiTinh.Name = "cbx_GioiTinh";
            this.cbx_GioiTinh.Size = new System.Drawing.Size(314, 21);
            this.cbx_GioiTinh.TabIndex = 66;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(218, 84);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(314, 20);
            this.dateTimePicker_NgaySinh.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Nghề Nghiệp";
            // 
            // txt_NgheNghiep
            // 
            this.txt_NgheNghiep.Location = new System.Drawing.Point(218, 157);
            this.txt_NgheNghiep.Name = "txt_NgheNghiep";
            this.txt_NgheNghiep.Size = new System.Drawing.Size(314, 20);
            this.txt_NgheNghiep.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Số Điện Thoại";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(218, 193);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(314, 20);
            this.txt_SoDienThoai.TabIndex = 60;
            this.txt_SoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoDienThoai_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Địa Chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(218, 229);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(314, 20);
            this.txt_DiaChi.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tên Học Viên";
            // 
            // txt_TenHocVien
            // 
            this.txt_TenHocVien.Location = new System.Drawing.Point(218, 48);
            this.txt_TenHocVien.Name = "txt_TenHocVien";
            this.txt_TenHocVien.Size = new System.Drawing.Size(314, 20);
            this.txt_TenHocVien.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã Học Viên";
            // 
            // txt_MaHocVien
            // 
            this.txt_MaHocVien.Enabled = false;
            this.txt_MaHocVien.Location = new System.Drawing.Point(218, 12);
            this.txt_MaHocVien.Name = "txt_MaHocVien";
            this.txt_MaHocVien.Size = new System.Drawing.Size(314, 20);
            this.txt_MaHocVien.TabIndex = 53;
            // 
            // frmQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 531);
            this.Controls.Add(this.cbx_GioiTinh);
            this.Controls.Add(this.dateTimePicker_NgaySinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_NgheNghiep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TenHocVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaHocVien);
            this.Controls.Add(this.btn_ChinhSuaHoSo);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.dataGridViewQuanLyHocVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyHocVien";
            this.Text = "Quản Lý Học Viên";
            this.Load += new System.EventHandler(this.frmQuanLyHocVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyHocVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyHocVien;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_ChinhSuaHoSo;
        private System.Windows.Forms.ComboBox cbx_GioiTinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NgheNghiep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenHocVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHocVien;
    }
}