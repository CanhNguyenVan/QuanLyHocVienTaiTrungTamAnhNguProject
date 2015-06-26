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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaLoaiLop = new System.Windows.Forms.TextBox();
            this.txt_TenLoaiLop = new System.Windows.Forms.TextBox();
            this.dTime_NgayHoc = new System.Windows.Forms.DateTimePicker();
            this.dTime_GioHoc = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyLoaiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTime_GioHoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyLoaiLop
            // 
            this.dataGridViewQuanLyLoaiLop.AllowUserToAddRows = false;
            this.dataGridViewQuanLyLoaiLop.AllowUserToDeleteRows = false;
            this.dataGridViewQuanLyLoaiLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyLoaiLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyLoaiLop.Location = new System.Drawing.Point(12, 122);
            this.dataGridViewQuanLyLoaiLop.Name = "dataGridViewQuanLyLoaiLop";
            this.dataGridViewQuanLyLoaiLop.ReadOnly = true;
            this.dataGridViewQuanLyLoaiLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyLoaiLop.Size = new System.Drawing.Size(621, 290);
            this.dataGridViewQuanLyLoaiLop.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(558, 418);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(467, 418);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(376, 418);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Loại Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giờ Học";
            // 
            // txt_MaLoaiLop
            // 
            this.txt_MaLoaiLop.Enabled = false;
            this.txt_MaLoaiLop.Location = new System.Drawing.Point(191, 9);
            this.txt_MaLoaiLop.Name = "txt_MaLoaiLop";
            this.txt_MaLoaiLop.Size = new System.Drawing.Size(390, 20);
            this.txt_MaLoaiLop.TabIndex = 3;
            // 
            // txt_TenLoaiLop
            // 
            this.txt_TenLoaiLop.Location = new System.Drawing.Point(191, 37);
            this.txt_TenLoaiLop.Name = "txt_TenLoaiLop";
            this.txt_TenLoaiLop.Size = new System.Drawing.Size(390, 20);
            this.txt_TenLoaiLop.TabIndex = 3;
            // 
            // dTime_NgayHoc
            // 
            this.dTime_NgayHoc.Location = new System.Drawing.Point(191, 65);
            this.dTime_NgayHoc.Name = "dTime_NgayHoc";
            this.dTime_NgayHoc.Size = new System.Drawing.Size(390, 20);
            this.dTime_NgayHoc.TabIndex = 4;
            // 
            // dTime_GioHoc
            // 
            this.dTime_GioHoc.EditValue = new System.DateTime(2015, 6, 25, 0, 0, 0, 0);
            this.dTime_GioHoc.Location = new System.Drawing.Point(191, 97);
            this.dTime_GioHoc.Name = "dTime_GioHoc";
            this.dTime_GioHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTime_GioHoc.Size = new System.Drawing.Size(390, 20);
            this.dTime_GioHoc.TabIndex = 5;
            // 
            // frmQuanLyLoaiLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 446);
            this.Controls.Add(this.dTime_GioHoc);
            this.Controls.Add(this.dTime_NgayHoc);
            this.Controls.Add(this.txt_TenLoaiLop);
            this.Controls.Add(this.txt_MaLoaiLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dataGridViewQuanLyLoaiLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyLoaiLop";
            this.Text = "Quản Lý Loại Lớp";
            this.Load += new System.EventHandler(this.frmQuanLyLoaiLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyLoaiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTime_GioHoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyLoaiLop;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaLoaiLop;
        private System.Windows.Forms.TextBox txt_TenLoaiLop;
        private System.Windows.Forms.DateTimePicker dTime_NgayHoc;
        private DevExpress.XtraEditors.TimeEdit dTime_GioHoc;
    }
}