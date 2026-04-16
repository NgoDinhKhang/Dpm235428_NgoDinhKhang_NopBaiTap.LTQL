namespace BTH1.Forms
{
    partial class frmHoaDon_ChiTiet
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
            groupBox1 = new GroupBox();
            txtGhiChuHoaDon = new TextBox();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            numDonGiaBan = new NumericUpDown();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numSoLuongBan = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            cboSanPham = new ComboBox();
            label4 = new Label();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChuHoaDon);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(887, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Location = new Point(175, 63);
            txtGhiChuHoaDon.Margin = new Padding(3, 4, 3, 4);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(525, 27);
            txtGhiChuHoaDon.TabIndex = 6;
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(562, 24);
            cboKhachHang.Margin = new Padding(3, 4, 3, 4);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(138, 28);
            cboKhachHang.TabIndex = 5;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(173, 24);
            cboNhanVien.Margin = new Padding(3, 4, 3, 4);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(277, 28);
            cboNhanVien.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 28);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 0;
            label3.Text = "Khách hàng(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 67);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Ghi chú hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 28);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên lập(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numDonGiaBan);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhanBan);
            groupBox2.Controls.Add(numSoLuongBan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(14, 157);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(887, 325);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(303, 72);
            numDonGiaBan.Margin = new Padding(3, 4, 3, 4);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(137, 27);
            numDonGiaBan.TabIndex = 8;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, DonGiaBan, SoLuongBan, ThanhTien });
            dataGridView.Location = new Point(7, 117);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(873, 200);
            dataGridView.TabIndex = 7;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenSanPham
            // 
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // DonGiaBan
            // 
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            // 
            // SoLuongBan
            // 
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            // 
            // ThanhTien
            // 
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(768, 73);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 31);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.Location = new Point(654, 73);
            btnXacNhanBan.Margin = new Padding(3, 4, 3, 4);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(107, 31);
            btnXacNhanBan.TabIndex = 6;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(498, 72);
            numSoLuongBan.Margin = new Padding(3, 4, 3, 4);
            numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(137, 27);
            numSoLuongBan.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 48);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 4;
            label6.Text = "Số lượng bán(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(303, 48);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 2;
            label5.Text = "Đơn giá bán(*):";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(42, 72);
            cboSanPham.Margin = new Padding(3, 4, 3, 4);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(215, 28);
            cboSanPham.TabIndex = 1;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 48);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 0;
            label4.Text = "Sản phẩm(*):";
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(251, 491);
            btnLuuHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(120, 31);
            btnLuuHoaDon.TabIndex = 1;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(378, 491);
            btnInHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(105, 31);
            btnInHoaDon.TabIndex = 1;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(490, 491);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private ComboBox cboSanPham;
        private Label label4;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numSoLuongBan;
        private Label label6;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnLuuHoaDon;
        private Button btnInHoaDon;
        private Button btnThoat;
        private ComboBox cboNhanVien;
        private TextBox txtGhiChuHoaDon;
        private ComboBox cboKhachHang;
        private NumericUpDown numDonGiaBan;
    }
}