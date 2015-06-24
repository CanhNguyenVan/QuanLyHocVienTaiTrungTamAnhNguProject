namespace GUI
{
    partial class frmQuanLyLoaiLop
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
            this.dataGridViewQuanLyLoaiLop = new System.Windows.Forms.DataGridView();
            this.MaLoaiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.GioHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyLoaiLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyLoaiLop
            // 
            this.dataGridViewQuanLyLoaiLop.AllowUserToOrderColumns = true;
            this.dataGridViewQuanLyLoaiLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyLoaiLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiLop,
            this.TenLoaiLop,
            this.NgayHoc,
            this.GioHoc});
            this.dataGridViewQuanLyLoaiLop.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQuanLyLoaiLop.Name = "dataGridViewQuanLyLoaiLop";
            this.dataGridViewQuanLyLoaiLop.Size = new System.Drawing.Size(621, 320);
            this.dataGridViewQuanLyLoaiLop.TabIndex = 0;
            // 
            // MaLoaiLop
            // 
            this.MaLoaiLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaLoaiLop.HeaderText = "MaLoaiLop";
            this.MaLoaiLop.Name = "MaLoaiLop";
            this.MaLoaiLop.ReadOnly = true;
            // 
            // TenLoaiLop
            // 
            this.TenLoaiLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiLop.HeaderText = "Tên Loại Lớp";
            this.TenLoaiLop.Name = "TenLoaiLop";
            // 
            // NgayHoc
            // 
            this.NgayHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            // 
            // 
            // 
            this.NgayHoc.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.NgayHoc.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.NgayHoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayHoc.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.NgayHoc.HeaderText = "Ngày Học";
            this.NgayHoc.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.NgayHoc.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayHoc.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayHoc.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.NgayHoc.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayHoc.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.NgayHoc.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.NgayHoc.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayHoc.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayHoc.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.Width = 80;
            // 
            // GioHoc
            // 
            this.GioHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GioHoc.HeaderText = "Giờ Học";
            this.GioHoc.Name = "GioHoc";
            this.GioHoc.Width = 71;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(558, 340);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 1;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(467, 340);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(376, 340);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(285, 340);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyLoaiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 375);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.dataGridViewQuanLyLoaiLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyLoaiLop";
            this.Text = "Quản Lý Loại Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyLoaiLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyLoaiLop;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiLop;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioHoc;
    }
}