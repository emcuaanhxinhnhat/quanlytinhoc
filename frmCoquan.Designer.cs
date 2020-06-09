namespace quanlytinhoc
{
    partial class frmCoquan
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaCQ = new System.Windows.Forms.Label();
            this.TenCQ = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.DienThoai = new System.Windows.Forms.Label();
            this.dataGridViewCoQuan = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtMaCQ = new System.Windows.Forms.TextBox();
            this.txtTenCQ = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.MaCoQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCoQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ Quan";
            // 
            // MaCQ
            // 
            this.MaCQ.AutoSize = true;
            this.MaCQ.Location = new System.Drawing.Point(54, 95);
            this.MaCQ.Name = "MaCQ";
            this.MaCQ.Size = new System.Drawing.Size(87, 17);
            this.MaCQ.TabIndex = 1;
            this.MaCQ.Text = "Mã Cơ Quan";
            // 
            // TenCQ
            // 
            this.TenCQ.AutoSize = true;
            this.TenCQ.Location = new System.Drawing.Point(54, 133);
            this.TenCQ.Name = "TenCQ";
            this.TenCQ.Size = new System.Drawing.Size(93, 17);
            this.TenCQ.TabIndex = 2;
            this.TenCQ.Text = "Tên Cơ Quan";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(435, 94);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(55, 17);
            this.DiaChi.TabIndex = 3;
            this.DiaChi.Text = "Địa chỉ ";
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSize = true;
            this.DienThoai.Location = new System.Drawing.Point(435, 133);
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Size = new System.Drawing.Size(72, 17);
            this.DienThoai.TabIndex = 4;
            this.DienThoai.Text = "Điện thoại";
            // 
            // dataGridViewCoQuan
            // 
            this.dataGridViewCoQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCoQuan,
            this.TenCoQuan,
            this.clDiaChi,
            this.clDienThoai});
            this.dataGridViewCoQuan.Location = new System.Drawing.Point(118, 177);
            this.dataGridViewCoQuan.Name = "dataGridViewCoQuan";
            this.dataGridViewCoQuan.RowHeadersWidth = 51;
            this.dataGridViewCoQuan.RowTemplate.Height = 24;
            this.dataGridViewCoQuan.Size = new System.Drawing.Size(557, 150);
            this.dataGridViewCoQuan.TabIndex = 5;
            this.dataGridViewCoQuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCoQuan_CellClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(57, 367);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(207, 367);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(358, 367);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(498, 367);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(648, 367);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtMaCQ
            // 
            this.txtMaCQ.Location = new System.Drawing.Point(170, 92);
            this.txtMaCQ.Name = "txtMaCQ";
            this.txtMaCQ.Size = new System.Drawing.Size(100, 22);
            this.txtMaCQ.TabIndex = 11;
            // 
            // txtTenCQ
            // 
            this.txtTenCQ.Location = new System.Drawing.Point(170, 128);
            this.txtTenCQ.Name = "txtTenCQ";
            this.txtTenCQ.Size = new System.Drawing.Size(100, 22);
            this.txtTenCQ.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(514, 90);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(514, 128);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(100, 22);
            this.txtDienThoai.TabIndex = 14;
            // 
            // MaCoQuan
            // 
            this.MaCoQuan.DataPropertyName = "MaCQ";
            this.MaCoQuan.HeaderText = "Mã Cơ Quan ";
            this.MaCoQuan.MinimumWidth = 6;
            this.MaCoQuan.Name = "MaCoQuan";
            this.MaCoQuan.Width = 125;
            // 
            // TenCoQuan
            // 
            this.TenCoQuan.DataPropertyName = "TenCQ";
            this.TenCoQuan.HeaderText = "Tên cơ quan";
            this.TenCoQuan.MinimumWidth = 6;
            this.TenCoQuan.Name = "TenCoQuan";
            this.TenCoQuan.Width = 125;
            // 
            // clDiaChi
            // 
            this.clDiaChi.DataPropertyName = "DiaChi";
            this.clDiaChi.HeaderText = "Địa Chỉ";
            this.clDiaChi.MinimumWidth = 6;
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Width = 125;
            // 
            // clDienThoai
            // 
            this.clDienThoai.DataPropertyName = "DienThoai";
            this.clDienThoai.HeaderText = "Điện thoại ";
            this.clDienThoai.MinimumWidth = 6;
            this.clDienThoai.Name = "clDienThoai";
            this.clDienThoai.Width = 125;
            // 
            // frmCoquan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenCQ);
            this.Controls.Add(this.txtMaCQ);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridViewCoQuan);
            this.Controls.Add(this.DienThoai);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.TenCQ);
            this.Controls.Add(this.MaCQ);
            this.Controls.Add(this.label1);
            this.Name = "frmCoquan";
            this.Text = "frmCoquan";
            this.Load += new System.EventHandler(this.frmCoquan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaCQ;
        private System.Windows.Forms.Label TenCQ;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label DienThoai;
        private System.Windows.Forms.DataGridView dataGridViewCoQuan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtMaCQ;
        private System.Windows.Forms.TextBox txtTenCQ;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCoQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCoQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDienThoai;
    }
}