namespace GUI
{
    partial class frmQuanLyKyThi
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
            this.dataGridViewQuanLyKyThi = new System.Windows.Forms.DataGridView();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.MaKyThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayThi = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.GioThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyKyThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyKyThi
            // 
            this.dataGridViewQuanLyKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyKyThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKyThi,
            this.TenKhoaHoc,
            this.NgayThi,
            this.GioThi});
            this.dataGridViewQuanLyKyThi.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQuanLyKyThi.Name = "dataGridViewQuanLyKyThi";
            this.dataGridViewQuanLyKyThi.Size = new System.Drawing.Size(758, 439);
            this.dataGridViewQuanLyKyThi.TabIndex = 0;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(696, 457);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 1;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(615, 457);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(534, 457);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(453, 457);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // MaKyThi
            // 
            this.MaKyThi.HeaderText = "Mã Kỳ Thi";
            this.MaKyThi.Name = "MaKyThi";
            this.MaKyThi.ReadOnly = true;
            // 
            // TenKhoaHoc
            // 
            this.TenKhoaHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhoaHoc.HeaderText = "Tên Khóa Học";
            this.TenKhoaHoc.Name = "TenKhoaHoc";
            // 
            // NgayThi
            // 
            // 
            // 
            // 
            this.NgayThi.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.NgayThi.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.NgayThi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayThi.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.NgayThi.HeaderText = "Ngày Thi";
            this.NgayThi.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.NgayThi.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayThi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayThi.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.NgayThi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayThi.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.NgayThi.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.NgayThi.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayThi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayThi.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.Width = 150;
            // 
            // GioThi
            // 
            this.GioThi.HeaderText = "Giờ Thi";
            this.GioThi.Name = "GioThi";
            // 
            // frmQuanLyKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 490);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.dataGridViewQuanLyKyThi);
            this.Name = "frmQuanLyKyThi";
            this.Text = "Quản Lý Kỳ Thi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyKyThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyKyThi;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKyThi;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenKhoaHoc;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn NgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioThi;
    }
}