namespace BTL_CNPM.GUI
{
    partial class ucKho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdTenMatHang = new System.Windows.Forms.RadioButton();
            this.rdSoLuongTieuThu = new System.Windows.Forms.RadioButton();
            this.rdGiaBan = new System.Windows.Forms.RadioButton();
            this.rdSoLuong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKho = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 548);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTenMatHang);
            this.groupBox3.Controls.Add(this.rdSoLuongTieuThu);
            this.groupBox3.Controls.Add(this.rdGiaBan);
            this.groupBox3.Controls.Add(this.rdSoLuong);
            this.groupBox3.Location = new System.Drawing.Point(15, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thứ tự ưu tiên";
            // 
            // rdTenMatHang
            // 
            this.rdTenMatHang.AutoSize = true;
            this.rdTenMatHang.Location = new System.Drawing.Point(18, 161);
            this.rdTenMatHang.Name = "rdTenMatHang";
            this.rdTenMatHang.Size = new System.Drawing.Size(107, 21);
            this.rdTenMatHang.TabIndex = 3;
            this.rdTenMatHang.TabStop = true;
            this.rdTenMatHang.Text = "Tên mặt hàng";
            this.rdTenMatHang.UseVisualStyleBackColor = true;
            // 
            // rdSoLuongTieuThu
            // 
            this.rdSoLuongTieuThu.AutoSize = true;
            this.rdSoLuongTieuThu.Location = new System.Drawing.Point(18, 75);
            this.rdSoLuongTieuThu.Name = "rdSoLuongTieuThu";
            this.rdSoLuongTieuThu.Size = new System.Drawing.Size(125, 21);
            this.rdSoLuongTieuThu.TabIndex = 2;
            this.rdSoLuongTieuThu.TabStop = true;
            this.rdSoLuongTieuThu.Text = "Số lượng tiêu thụ";
            this.rdSoLuongTieuThu.UseVisualStyleBackColor = true;
            // 
            // rdGiaBan
            // 
            this.rdGiaBan.AutoSize = true;
            this.rdGiaBan.Location = new System.Drawing.Point(18, 118);
            this.rdGiaBan.Name = "rdGiaBan";
            this.rdGiaBan.Size = new System.Drawing.Size(71, 21);
            this.rdGiaBan.TabIndex = 1;
            this.rdGiaBan.TabStop = true;
            this.rdGiaBan.Text = "Giá bán";
            this.rdGiaBan.UseVisualStyleBackColor = true;
            // 
            // rdSoLuong
            // 
            this.rdSoLuong.AutoSize = true;
            this.rdSoLuong.Location = new System.Drawing.Point(18, 32);
            this.rdSoLuong.Name = "rdSoLuong";
            this.rdSoLuong.Size = new System.Drawing.Size(137, 21);
            this.rdSoLuong.TabIndex = 0;
            this.rdSoLuong.TabStop = true;
            this.rdSoLuong.Text = "Số lượng trong kho";
            this.rdSoLuong.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvKho);
            this.groupBox2.Location = new System.Drawing.Point(314, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 511);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mặt hàng";
            // 
            // dgvKho
            // 
            this.dgvKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKho.Location = new System.Drawing.Point(3, 20);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.Size = new System.Drawing.Size(964, 488);
            this.dgvKho.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(18, 54);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(244, 24);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // ucKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucKho";
            this.Size = new System.Drawing.Size(1308, 548);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel dgvKho;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdSoLuongTieuThu;
        private System.Windows.Forms.RadioButton rdGiaBan;
        private System.Windows.Forms.RadioButton rdSoLuong;
        private System.Windows.Forms.RadioButton rdTenMatHang;
    }
}
