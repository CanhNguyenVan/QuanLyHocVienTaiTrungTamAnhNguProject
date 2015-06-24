namespace GUI
{
    partial class frmQuanLyCapLop
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
            this.dataGridViewQuanLyCapLop = new System.Windows.Forms.DataGridView();
            this.MaCapLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCapLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyCapLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyCapLop
            // 
            this.dataGridViewQuanLyCapLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyCapLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCapLop,
            this.TenCapLop});
            this.dataGridViewQuanLyCapLop.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQuanLyCapLop.Name = "dataGridViewQuanLyCapLop";
            this.dataGridViewQuanLyCapLop.Size = new System.Drawing.Size(399, 266);
            this.dataGridViewQuanLyCapLop.TabIndex = 0;
            // 
            // MaCapLop
            // 
            this.MaCapLop.HeaderText = "Mã Cấp Lớp";
            this.MaCapLop.Name = "MaCapLop";
            this.MaCapLop.ReadOnly = true;
            // 
            // TenCapLop
            // 
            this.TenCapLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCapLop.HeaderText = "Tên Cấp Lớp";
            this.TenCapLop.Name = "TenCapLop";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyCapLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 333);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewQuanLyCapLop);
            this.Name = "frmQuanLyCapLop";
            this.Text = "Quản Lý Cấp Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyCapLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuanLyCapLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCapLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCapLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}