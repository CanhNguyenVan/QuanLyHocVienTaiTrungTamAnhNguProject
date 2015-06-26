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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MaKyThi = new System.Windows.Forms.TextBox();
            this.dTime_NgayThi = new System.Windows.Forms.DateTimePicker();
            this.tEd_GioThi = new DevExpress.XtraEditors.TimeEdit();
            this.cbx_MaKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyKyThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEd_GioThi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyKyThi
            // 
            this.dataGridViewQuanLyKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyKyThi.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewQuanLyKyThi.Name = "dataGridViewQuanLyKyThi";
            this.dataGridViewQuanLyKyThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyKyThi.Size = new System.Drawing.Size(558, 281);
            this.dataGridViewQuanLyKyThi.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(495, 427);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(414, 427);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(333, 427);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MaKyThi
            // 
            this.txt_MaKyThi.Enabled = false;
            this.txt_MaKyThi.Location = new System.Drawing.Point(129, 5);
            this.txt_MaKyThi.Name = "txt_MaKyThi";
            this.txt_MaKyThi.Size = new System.Drawing.Size(344, 20);
            this.txt_MaKyThi.TabIndex = 2;
            // 
            // dTime_NgayThi
            // 
            this.dTime_NgayThi.Location = new System.Drawing.Point(129, 78);
            this.dTime_NgayThi.Name = "dTime_NgayThi";
            this.dTime_NgayThi.Size = new System.Drawing.Size(344, 20);
            this.dTime_NgayThi.TabIndex = 3;
            // 
            // tEd_GioThi
            // 
            this.tEd_GioThi.EditValue = new System.DateTime(2015, 6, 26, 0, 0, 0, 0);
            this.tEd_GioThi.Location = new System.Drawing.Point(129, 114);
            this.tEd_GioThi.Name = "tEd_GioThi";
            this.tEd_GioThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tEd_GioThi.Size = new System.Drawing.Size(344, 20);
            this.tEd_GioThi.TabIndex = 4;
            // 
            // cbx_MaKhoaHoc
            // 
            this.cbx_MaKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MaKhoaHoc.FormattingEnabled = true;
            this.cbx_MaKhoaHoc.Location = new System.Drawing.Point(129, 41);
            this.cbx_MaKhoaHoc.Name = "cbx_MaKhoaHoc";
            this.cbx_MaKhoaHoc.Size = new System.Drawing.Size(344, 21);
            this.cbx_MaKhoaHoc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Kỳ Thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Khóa Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giờ Thi";
            // 
            // frmQuanLyKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_MaKhoaHoc);
            this.Controls.Add(this.tEd_GioThi);
            this.Controls.Add(this.dTime_NgayThi);
            this.Controls.Add(this.txt_MaKyThi);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dataGridViewQuanLyKyThi);
            this.Name = "frmQuanLyKyThi";
            this.Text = "Quản Lý Kỳ Thi";
            this.Load += new System.EventHandler(this.frmQuanLyKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyKyThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEd_GioThi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyKyThi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_MaKyThi;
        private System.Windows.Forms.DateTimePicker dTime_NgayThi;
        private DevExpress.XtraEditors.TimeEdit tEd_GioThi;
        private System.Windows.Forms.ComboBox cbx_MaKhoaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}