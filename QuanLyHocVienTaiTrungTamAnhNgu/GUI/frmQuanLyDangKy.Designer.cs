namespace GUI
{
    partial class frmQuanLyDangKy
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_KhoaHoc = new System.Windows.Forms.ComboBox();
            this.cbx_Lop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_HocPhi = new System.Windows.Forms.TextBox();
            this.btn_ChapNhan = new System.Windows.Forms.Button();
            this.txt_MienGiam = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_GioiTinh
            // 
            this.cbx_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_GioiTinh.FormattingEnabled = true;
            this.cbx_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_GioiTinh.Location = new System.Drawing.Point(113, 130);
            this.cbx_GioiTinh.Name = "cbx_GioiTinh";
            this.cbx_GioiTinh.Size = new System.Drawing.Size(314, 21);
            this.cbx_GioiTinh.TabIndex = 45;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(113, 92);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(314, 20);
            this.dateTimePicker_NgaySinh.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nghề Nghiệp";
            // 
            // txt_NgheNghiep
            // 
            this.txt_NgheNghiep.Location = new System.Drawing.Point(113, 164);
            this.txt_NgheNghiep.Name = "txt_NgheNghiep";
            this.txt_NgheNghiep.Size = new System.Drawing.Size(314, 20);
            this.txt_NgheNghiep.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Số Điện Thoại";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(113, 200);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(314, 20);
            this.txt_SoDienThoai.TabIndex = 39;
            this.txt_SoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoDienThoai_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Địa Chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(113, 236);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(314, 20);
            this.txt_DiaChi.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên Học Viên";
            // 
            // txt_TenHocVien
            // 
            this.txt_TenHocVien.Location = new System.Drawing.Point(113, 56);
            this.txt_TenHocVien.Name = "txt_TenHocVien";
            this.txt_TenHocVien.Size = new System.Drawing.Size(314, 20);
            this.txt_TenHocVien.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Học Viên";
            // 
            // txt_MaHocVien
            // 
            this.txt_MaHocVien.Enabled = false;
            this.txt_MaHocVien.Location = new System.Drawing.Point(113, 20);
            this.txt_MaHocVien.Name = "txt_MaHocVien";
            this.txt_MaHocVien.Size = new System.Drawing.Size(314, 20);
            this.txt_MaHocVien.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Khóa Học";
            // 
            // cbx_KhoaHoc
            // 
            this.cbx_KhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_KhoaHoc.FormattingEnabled = true;
            this.cbx_KhoaHoc.Location = new System.Drawing.Point(113, 272);
            this.cbx_KhoaHoc.Name = "cbx_KhoaHoc";
            this.cbx_KhoaHoc.Size = new System.Drawing.Size(314, 21);
            this.cbx_KhoaHoc.TabIndex = 48;
            // 
            // cbx_Lop
            // 
            this.cbx_Lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Lop.FormattingEnabled = true;
            this.cbx_Lop.Location = new System.Drawing.Point(113, 316);
            this.cbx_Lop.Name = "cbx_Lop";
            this.cbx_Lop.Size = new System.Drawing.Size(314, 21);
            this.cbx_Lop.TabIndex = 50;
            this.cbx_Lop.SelectedIndexChanged += new System.EventHandler(this.cbx_Lop_SelectedIndexChanged);
            this.cbx_Lop.SelectionChangeCommitted += new System.EventHandler(this.cbx_Lop_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Lớp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Học Phí";
            // 
            // txt_HocPhi
            // 
            this.txt_HocPhi.Enabled = false;
            this.txt_HocPhi.Location = new System.Drawing.Point(113, 356);
            this.txt_HocPhi.Name = "txt_HocPhi";
            this.txt_HocPhi.Size = new System.Drawing.Size(314, 20);
            this.txt_HocPhi.TabIndex = 51;
            this.txt_HocPhi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dauPhayDongTextBox_KeyPress);
            // 
            // btn_ChapNhan
            // 
            this.btn_ChapNhan.Location = new System.Drawing.Point(188, 429);
            this.btn_ChapNhan.Name = "btn_ChapNhan";
            this.btn_ChapNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_ChapNhan.TabIndex = 53;
            this.btn_ChapNhan.Text = "Chấp Nhận";
            this.btn_ChapNhan.UseVisualStyleBackColor = true;
            this.btn_ChapNhan.Click += new System.EventHandler(this.btn_ChapNhan_Click);
            // 
            // txt_MienGiam
            // 
            this.txt_MienGiam.Enabled = false;
            this.txt_MienGiam.Location = new System.Drawing.Point(113, 392);
            this.txt_MienGiam.Name = "txt_MienGiam";
            this.txt_MienGiam.Size = new System.Drawing.Size(314, 20);
            this.txt_MienGiam.TabIndex = 51;
            this.txt_MienGiam.Text = "0";
            this.txt_MienGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dauPhayDongTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Miễn Giảm";
            // 
            // frmQuanLyDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 464);
            this.Controls.Add(this.btn_ChapNhan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_MienGiam);
            this.Controls.Add(this.txt_HocPhi);
            this.Controls.Add(this.cbx_Lop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_KhoaHoc);
            this.Controls.Add(this.label8);
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
            this.Name = "frmQuanLyDangKy";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmQuanLyDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_KhoaHoc;
        private System.Windows.Forms.ComboBox cbx_Lop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_HocPhi;
        private System.Windows.Forms.Button btn_ChapNhan;
        private System.Windows.Forms.TextBox txt_MienGiam;
        private System.Windows.Forms.Label label11;


    }
}