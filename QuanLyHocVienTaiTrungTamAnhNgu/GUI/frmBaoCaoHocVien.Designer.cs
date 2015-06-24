namespace GUI
{
    partial class frmBaoCaoHocVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocVien,
            this.TenHocVien,
            this.NgaySinh,
            this.GioiTinh,
            this.NgheNghiep,
            this.SoDienThoai,
            this.DiaChi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaHocVien
            // 
            this.MaHocVien.HeaderText = "Mã Học Viên";
            this.MaHocVien.Name = "MaHocVien";
            // 
            // TenHocVien
            // 
            this.TenHocVien.HeaderText = "Tên Học Viên";
            this.TenHocVien.Name = "TenHocVien";
            // 
            // NgaySinh
            // 
            // 
            // 
            // 
            this.NgaySinh.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.NgaySinh.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.NgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgaySinh.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.NgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.NgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.NgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.NgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.HeaderText = "Nghề Nghiệp";
            this.NgheNghiep.Name = "NgheNghiep";
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmBaoCaoHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBaoCaoHocVien";
            this.Text = "Báo Cáo Học Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocVien;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}