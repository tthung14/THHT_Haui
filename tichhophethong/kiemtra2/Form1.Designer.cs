namespace kiemtra2
{
    partial class Form1
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
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.dgvNgayLamViec = new System.Windows.Forms.DataGridView();
            this.tbnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tbnSua = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgayLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(167, 36);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(206, 22);
            this.txtNgay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lý do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn vị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trạng thái";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(167, 67);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(206, 22);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(167, 98);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(206, 22);
            this.txtLyDo.TabIndex = 7;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(167, 129);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(206, 22);
            this.txtDonVi.TabIndex = 8;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(167, 160);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(206, 22);
            this.txtTrangThai.TabIndex = 9;
            // 
            // dgvNgayLamViec
            // 
            this.dgvNgayLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNgayLamViec.Location = new System.Drawing.Point(32, 233);
            this.dgvNgayLamViec.Name = "dgvNgayLamViec";
            this.dgvNgayLamViec.RowHeadersWidth = 51;
            this.dgvNgayLamViec.RowTemplate.Height = 24;
            this.dgvNgayLamViec.Size = new System.Drawing.Size(739, 205);
            this.dgvNgayLamViec.TabIndex = 10;
            this.dgvNgayLamViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNgayLamViec_CellContentClick);
            this.dgvNgayLamViec.SelectionChanged += new System.EventHandler(this.dgvNgayLamViec_SelectionChanged);
            // 
            // tbnThem
            // 
            this.tbnThem.Location = new System.Drawing.Point(448, 36);
            this.tbnThem.Name = "tbnThem";
            this.tbnThem.Size = new System.Drawing.Size(92, 50);
            this.tbnThem.TabIndex = 11;
            this.tbnThem.Text = "Thêm";
            this.tbnThem.UseVisualStyleBackColor = true;
            this.tbnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(448, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 50);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tbnSua
            // 
            this.tbnSua.Location = new System.Drawing.Point(448, 98);
            this.tbnSua.Name = "tbnSua";
            this.tbnSua.Size = new System.Drawing.Size(92, 50);
            this.tbnSua.TabIndex = 13;
            this.tbnSua.Text = "Sửa";
            this.tbnSua.UseVisualStyleBackColor = true;
            this.tbnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(591, 36);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(92, 50);
            this.btnTaiLai.TabIndex = 14;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(591, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 50);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.tbnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tbnThem);
            this.Controls.Add(this.dgvNgayLamViec);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.KiemTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNgayLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.DataGridView dgvNgayLamViec;
        private System.Windows.Forms.Button tbnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button tbnSua;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnClear;
    }
}

