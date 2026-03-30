namespace PresentationLayer
{
    partial class frm_nvQuaTrinhLuong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.radHoacDenNgay = new System.Windows.Forms.RadioButton();
            this.radDenHienTai = new System.Windows.Forms.RadioButton();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuaTrinhLuong = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaTrinhLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.radHoacDenNgay);
            this.groupBox1.Controls.Add(this.radDenHienTai);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tra cứu";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(695, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 67);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "TÌM";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(486, 38);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // radHoacDenNgay
            // 
            this.radHoacDenNgay.AutoSize = true;
            this.radHoacDenNgay.Location = new System.Drawing.Point(383, 39);
            this.radHoacDenNgay.Name = "radHoacDenNgay";
            this.radHoacDenNgay.Size = new System.Drawing.Size(97, 17);
            this.radHoacDenNgay.TabIndex = 2;
            this.radHoacDenNgay.TabStop = true;
            this.radHoacDenNgay.Text = "hoặc đến ngày";
            this.radHoacDenNgay.UseVisualStyleBackColor = true;
            // 
            // radDenHienTai
            // 
            this.radDenHienTai.AutoSize = true;
            this.radDenHienTai.Enabled = false;
            this.radDenHienTai.Location = new System.Drawing.Point(280, 39);
            this.radDenHienTai.Name = "radDenHienTai";
            this.radDenHienTai.Size = new System.Drawing.Size(81, 17);
            this.radDenHienTai.TabIndex = 2;
            this.radDenHienTai.TabStop = true;
            this.radDenHienTai.Text = "đến hiện tại";
            this.radDenHienTai.UseVisualStyleBackColor = true;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(74, 39);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "từ ngày";
            // 
            // dgvQuaTrinhLuong
            // 
            this.dgvQuaTrinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuaTrinhLuong.Location = new System.Drawing.Point(2, 118);
            this.dgvQuaTrinhLuong.Name = "dgvQuaTrinhLuong";
            this.dgvQuaTrinhLuong.Size = new System.Drawing.Size(794, 334);
            this.dgvQuaTrinhLuong.TabIndex = 1;
            // 
            // frm_nvQuaTrinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvQuaTrinhLuong);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_nvQuaTrinhLuong";
            this.Text = "QuaTrinhLuong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaTrinhLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.RadioButton radHoacDenNgay;
        private System.Windows.Forms.RadioButton radDenHienTai;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuaTrinhLuong;
    }
}