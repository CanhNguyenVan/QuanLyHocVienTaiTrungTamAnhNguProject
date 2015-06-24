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
            this.TenHocVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenKyThi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyDiem
            // 
            this.dataGridViewQuanLyDiem.AllowUserToOrderColumns = true;
            this.dataGridViewQuanLyDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHocVien,
            this.TenKyThi,
            this.Diem});
            this.dataGridViewQuanLyDiem.Location = new System.Drawing.Point(14, 12);
            this.dataGridViewQuanLyDiem.Name = "dataGridViewQuanLyDiem";
            this.dataGridViewQuanLyDiem.Size = new System.Drawing.Size(672, 379);
            this.dataGridViewQuanLyDiem.TabIndex = 0;
            // 
            // TenHocVien
            // 
            this.TenHocVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHocVien.HeaderText = "Tên Học Viên";
            this.TenHocVien.Name = "TenHocVien";
            // 
            // TenKyThi
            // 
            this.TenKyThi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKyThi.HeaderText = "Tên Kỳ Thi";
            this.TenKyThi.Name = "TenKyThi";
            // 
            // Diem
            // 
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            this.Diem.Width = 150;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(610, 398);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 1;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.Location = new System.Drawing.Point(529, 398);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xóa.TabIndex = 1;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(448, 398);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(367, 398);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 428);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xóa);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.dataGridViewQuanLyDiem);
            this.Name = "frmQuanLyDiem";
            this.Text = "Quản Lý Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyDiem;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenHocVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
    }
}