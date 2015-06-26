namespace GUI
{
    partial class frmQuanLyKhoaHoc
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
            this.dataGridViewQuanLyKhoaHoc = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MaKhoaHoc = new System.Windows.Forms.TextBox();
            this.txt_NienHoc = new System.Windows.Forms.TextBox();
            this.txt_HocKy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyKhoaHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyKhoaHoc
            // 
            this.dataGridViewQuanLyKhoaHoc.AllowUserToAddRows = false;
            this.dataGridViewQuanLyKhoaHoc.AllowUserToDeleteRows = false;
            this.dataGridViewQuanLyKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyKhoaHoc.Location = new System.Drawing.Point(9, 88);
            this.dataGridViewQuanLyKhoaHoc.Name = "dataGridViewQuanLyKhoaHoc";
            this.dataGridViewQuanLyKhoaHoc.ReadOnly = true;
            this.dataGridViewQuanLyKhoaHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyKhoaHoc.Size = new System.Drawing.Size(415, 309);
            this.dataGridViewQuanLyKhoaHoc.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(349, 403);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(268, 403);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(187, 403);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MaKhoaHoc
            // 
            this.txt_MaKhoaHoc.Enabled = false;
            this.txt_MaKhoaHoc.Location = new System.Drawing.Point(84, 6);
            this.txt_MaKhoaHoc.Name = "txt_MaKhoaHoc";
            this.txt_MaKhoaHoc.Size = new System.Drawing.Size(340, 20);
            this.txt_MaKhoaHoc.TabIndex = 2;
            // 
            // txt_NienHoc
            // 
            this.txt_NienHoc.Location = new System.Drawing.Point(84, 34);
            this.txt_NienHoc.Name = "txt_NienHoc";
            this.txt_NienHoc.Size = new System.Drawing.Size(340, 20);
            this.txt_NienHoc.TabIndex = 2;
            // 
            // txt_HocKy
            // 
            this.txt_HocKy.Location = new System.Drawing.Point(84, 62);
            this.txt_HocKy.Name = "txt_HocKy";
            this.txt_HocKy.Size = new System.Drawing.Size(340, 20);
            this.txt_HocKy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khóa Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Niên Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Học Kỳ";
            // 
            // frmQuanLyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_HocKy);
            this.Controls.Add(this.txt_NienHoc);
            this.Controls.Add(this.txt_MaKhoaHoc);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dataGridViewQuanLyKhoaHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyKhoaHoc";
            this.Text = "Quản Lý Khóa Học";
            this.Load += new System.EventHandler(this.frmQuanLyKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyKhoaHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyKhoaHoc;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_MaKhoaHoc;
        private System.Windows.Forms.TextBox txt_NienHoc;
        private System.Windows.Forms.TextBox txt_HocKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}