namespace BTH1.Reports
{
    partial class frmThongKeSanPham
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1 = new Panel();
            cboLoaiSanPham = new ComboBox();
            cboHangSanXuat = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnLocKetQua = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(0, 0);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(993, 450);
            reportViewer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(cboLoaiSanPham);
            panel1.Controls.Add(cboHangSanXuat);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 125);
            panel1.TabIndex = 1;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(661, 32);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(151, 28);
            cboLoaiSanPham.TabIndex = 3;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(291, 32);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(151, 28);
            cboHangSanXuat.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 40);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Loại sản phẩm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Hãng sản xuất:";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(852, 36);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(109, 29);
            btnLocKetQua.TabIndex = 4;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // frmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 450);
            Controls.Add(panel1);
            Controls.Add(reportViewer);
            Name = "frmThongKeSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sản phẩm";
            Load += frmThongKeSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cboLoaiSanPham;
        private ComboBox cboHangSanXuat;
        private Button btnLocKetQua;
    }
}