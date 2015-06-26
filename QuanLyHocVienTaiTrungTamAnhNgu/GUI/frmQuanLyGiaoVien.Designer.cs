namespace GUI
{
    partial class frmQuanLyGiaoVien
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
            this.dataGridViewQuanLyGiaoVien = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaGiaoVien = new System.Windows.Forms.TextBox();
            this.txt_TenGiaoVien = new System.Windows.Forms.TextBox();
            this.cbx_MaBangCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenBangCap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyGiaoVien
            // 
            this.dataGridViewQuanLyGiaoVien.AllowUserToAddRows = false;
            this.dataGridViewQuanLyGiaoVien.AllowUserToDeleteRows = false;
            this.dataGridViewQuanLyGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyGiaoVien.Location = new System.Drawing.Point(13, 120);
            this.dataGridViewQuanLyGiaoVien.Name = "dataGridViewQuanLyGiaoVien";
            this.dataGridViewQuanLyGiaoVien.ReadOnly = true;
            this.dataGridViewQuanLyGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyGiaoVien.Size = new System.Drawing.Size(460, 202);
            this.dataGridViewQuanLyGiaoVien.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(396, 328);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(315, 328);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(234, 328);
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
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Bằng Cấp";
            // 
            // txt_MaGiaoVien
            // 
            this.txt_MaGiaoVien.Enabled = false;
            this.txt_MaGiaoVien.Location = new System.Drawing.Point(108, 8);
            this.txt_MaGiaoVien.Name = "txt_MaGiaoVien";
            this.txt_MaGiaoVien.Size = new System.Drawing.Size(365, 20);
            this.txt_MaGiaoVien.TabIndex = 3;
            // 
            // txt_TenGiaoVien
            // 
            this.txt_TenGiaoVien.Location = new System.Drawing.Point(108, 36);
            this.txt_TenGiaoVien.Name = "txt_TenGiaoVien";
            this.txt_TenGiaoVien.Size = new System.Drawing.Size(365, 20);
            this.txt_TenGiaoVien.TabIndex = 3;
            // 
            // cbx_MaBangCap
            // 
            this.cbx_MaBangCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MaBangCap.FormattingEnabled = true;
            this.cbx_MaBangCap.Location = new System.Drawing.Point(108, 63);
            this.cbx_MaBangCap.Name = "cbx_MaBangCap";
            this.cbx_MaBangCap.Size = new System.Drawing.Size(362, 21);
            this.cbx_MaBangCap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Bằng Cấp";
            // 
            // txt_TenBangCap
            // 
            this.txt_TenBangCap.Enabled = false;
            this.txt_TenBangCap.Location = new System.Drawing.Point(105, 94);
            this.txt_TenBangCap.Name = "txt_TenBangCap";
            this.txt_TenBangCap.Size = new System.Drawing.Size(365, 20);
            this.txt_TenBangCap.TabIndex = 3;
            // 
            // frmQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 359);
            this.Controls.Add(this.cbx_MaBangCap);
            this.Controls.Add(this.txt_TenBangCap);
            this.Controls.Add(this.txt_TenGiaoVien);
            this.Controls.Add(this.txt_MaGiaoVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dataGridViewQuanLyGiaoVien);
            this.Name = "frmQuanLyGiaoVien";
            this.Text = "Quản Lý Giáo Viên";
            this.Load += new System.EventHandler(this.frmQuanLyGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyGiaoVien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaGiaoVien;
        private System.Windows.Forms.TextBox txt_TenGiaoVien;
        private System.Windows.Forms.ComboBox cbx_MaBangCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenBangCap;
    }
}