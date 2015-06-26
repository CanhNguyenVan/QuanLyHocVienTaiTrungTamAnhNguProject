namespace GUI
{
    partial class frmQuanLyLop
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
            this.dataGridViewQuanLyLop = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_SiSo = new System.Windows.Forms.TextBox();
            this.cbx_MaCapLop = new System.Windows.Forms.ComboBox();
            this.cbx_MaLoaiLop = new System.Windows.Forms.ComboBox();
            this.cbx_MaKhoaHoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyLop
            // 
            this.dataGridViewQuanLyLop.AllowUserToAddRows = false;
            this.dataGridViewQuanLyLop.AllowUserToDeleteRows = false;
            this.dataGridViewQuanLyLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQuanLyLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyLop.Location = new System.Drawing.Point(12, 182);
            this.dataGridViewQuanLyLop.Name = "dataGridViewQuanLyLop";
            this.dataGridViewQuanLyLop.ReadOnly = true;
            this.dataGridViewQuanLyLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyLop.Size = new System.Drawing.Size(754, 251);
            this.dataGridViewQuanLyLop.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(690, 439);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(609, 439);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(525, 439);
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
            this.label1.Location = new System.Drawing.Point(196, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Cấp Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Loại Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Khóa Học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sỉ Số";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Enabled = false;
            this.txt_MaLop.Location = new System.Drawing.Point(291, 5);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(321, 20);
            this.txt_MaLop.TabIndex = 3;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(291, 120);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(321, 20);
            this.txt_TenLop.TabIndex = 3;
            // 
            // txt_SiSo
            // 
            this.txt_SiSo.Location = new System.Drawing.Point(291, 148);
            this.txt_SiSo.Name = "txt_SiSo";
            this.txt_SiSo.Size = new System.Drawing.Size(321, 20);
            this.txt_SiSo.TabIndex = 3;
            this.txt_SiSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SiSo_KeyPress);
            // 
            // cbx_MaCapLop
            // 
            this.cbx_MaCapLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MaCapLop.FormattingEnabled = true;
            this.cbx_MaCapLop.Location = new System.Drawing.Point(291, 33);
            this.cbx_MaCapLop.Name = "cbx_MaCapLop";
            this.cbx_MaCapLop.Size = new System.Drawing.Size(321, 21);
            this.cbx_MaCapLop.TabIndex = 4;
            // 
            // cbx_MaLoaiLop
            // 
            this.cbx_MaLoaiLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MaLoaiLop.FormattingEnabled = true;
            this.cbx_MaLoaiLop.Location = new System.Drawing.Point(291, 62);
            this.cbx_MaLoaiLop.Name = "cbx_MaLoaiLop";
            this.cbx_MaLoaiLop.Size = new System.Drawing.Size(321, 21);
            this.cbx_MaLoaiLop.TabIndex = 4;
            // 
            // cbx_MaKhoaHoc
            // 
            this.cbx_MaKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MaKhoaHoc.FormattingEnabled = true;
            this.cbx_MaKhoaHoc.Location = new System.Drawing.Point(291, 91);
            this.cbx_MaKhoaHoc.Name = "cbx_MaKhoaHoc";
            this.cbx_MaKhoaHoc.Size = new System.Drawing.Size(321, 21);
            this.cbx_MaKhoaHoc.TabIndex = 4;
            // 
            // frmQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 473);
            this.Controls.Add(this.cbx_MaKhoaHoc);
            this.Controls.Add(this.cbx_MaLoaiLop);
            this.Controls.Add(this.cbx_MaCapLop);
            this.Controls.Add(this.txt_SiSo);
            this.Controls.Add(this.txt_TenLop);
            this.Controls.Add(this.txt_MaLop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dataGridViewQuanLyLop);
            this.Name = "frmQuanLyLop";
            this.Text = "Quản Lý Lớp";
            this.Load += new System.EventHandler(this.frmQuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyLop;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_SiSo;
        private System.Windows.Forms.ComboBox cbx_MaCapLop;
        private System.Windows.Forms.ComboBox cbx_MaLoaiLop;
        private System.Windows.Forms.ComboBox cbx_MaKhoaHoc;
    }
}