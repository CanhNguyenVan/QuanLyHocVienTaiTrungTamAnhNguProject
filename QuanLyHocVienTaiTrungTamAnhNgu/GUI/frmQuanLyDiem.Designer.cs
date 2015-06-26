namespace GUI
{
    partial class frmQuanLyDiem
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
            this.dataGridViewQuanLyDiem = new System.Windows.Forms.DataGridView();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.cbx_MaHocVien = new System.Windows.Forms.ComboBox();
            this.cbx_MaKyThi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyDiem
            // 
            this.dataGridViewQuanLyDiem.AllowUserToAddRows = false;
            this.dataGridViewQuanLyDiem.AllowUserToDeleteRows = false;
            this.dataGridViewQuanLyDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyDiem.Location = new System.Drawing.Point(11, 92);
            this.dataGridViewQuanLyDiem.Name = "dataGridViewQuanLyDiem";
            this.dataGridViewQuanLyDiem.ReadOnly = true;
            this.dataGridViewQuanLyDiem.Size = new System.Drawing.Size(323, 295);
            this.dataGridViewQuanLyDiem.TabIndex = 0;
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Location = new System.Drawing.Point(259, 393);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xóa.TabIndex = 1;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(178, 393);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(97, 393);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Diem
            // 
            this.txt_Diem.Location = new System.Drawing.Point(93, 66);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.Size = new System.Drawing.Size(241, 20);
            this.txt_Diem.TabIndex = 2;
            // 
            // cbx_MaHocVien
            // 
            this.cbx_MaHocVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MaHocVien.FormattingEnabled = true;
            this.cbx_MaHocVien.Location = new System.Drawing.Point(93, 8);
            this.cbx_MaHocVien.Name = "cbx_MaHocVien";
            this.cbx_MaHocVien.Size = new System.Drawing.Size(241, 21);
            this.cbx_MaHocVien.TabIndex = 3;
            // 
            // cbx_MaKyThi
            // 
            this.cbx_MaKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MaKyThi.FormattingEnabled = true;
            this.cbx_MaKyThi.Location = new System.Drawing.Point(93, 37);
            this.cbx_MaKyThi.Name = "cbx_MaKyThi";
            this.cbx_MaKyThi.Size = new System.Drawing.Size(241, 21);
            this.cbx_MaKyThi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Học Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Kỳ Thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm";
            // 
            // frmQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_MaKyThi);
            this.Controls.Add(this.cbx_MaHocVien);
            this.Controls.Add(this.txt_Diem);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xóa);
            this.Controls.Add(this.dataGridViewQuanLyDiem);
            this.Name = "frmQuanLyDiem";
            this.Text = "Quản Lý Điểm";
            this.Load += new System.EventHandler(this.frmQuanLyDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyDiem;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Diem;
        private System.Windows.Forms.ComboBox cbx_MaHocVien;
        private System.Windows.Forms.ComboBox cbx_MaKyThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}