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
            this.button1 = new System.Windows.Forms.Button();
            this.MaHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocVien,
            this.TenHocVien,
            this.Lop,
            this.DiemThi,
            this.XepLoai});
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
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
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            // 
            // DiemThi
            // 
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.Name = "DiemThi";
            // 
            // XepLoai
            // 
            this.XepLoai.HeaderText = "Xếp Loại";
            this.XepLoai.Name = "XepLoai";
            // 
            // frmBaoCaoHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 269);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn XepLoai;
    }
}