namespace BTL_CNPM.GUI
{
    partial class ucBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonMain = new DevExpress.XtraGrid.GridControl();
            this.dgvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxCBBanAn = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChuyenBan = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTraMon = new DevExpress.XtraEditors.SimpleButton();
            this.txtTMSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbxGMMatHang = new DevExpress.XtraEditors.LookUpEdit();
            this.txtGMSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoiMon = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtKhuyenMai = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.txtTenBanAn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelDsBanAn = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCBBanAn.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMSoLuong)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGMMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGMSoLuong)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhuyenMai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 548);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(717, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 526);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết bàn ăn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 503);
            this.panel2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvHoaDonMain);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(572, 303);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hóa đơn";
            // 
            // dgvHoaDonMain
            // 
            this.dgvHoaDonMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDonMain.Location = new System.Drawing.Point(3, 20);
            this.dgvHoaDonMain.MainView = this.dgvHoaDon;
            this.dgvHoaDonMain.Name = "dgvHoaDonMain";
            this.dgvHoaDonMain.Size = new System.Drawing.Size(566, 280);
            this.dgvHoaDonMain.TabIndex = 3;
            this.dgvHoaDonMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHoaDon});
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvHoaDon.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvHoaDon.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvHoaDon.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvHoaDon.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvHoaDon.Appearance.Row.Options.UseFont = true;
            this.dgvHoaDon.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvHoaDon.ColumnPanelRowHeight = 30;
            this.dgvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvHoaDon.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvHoaDon.GridControl = this.dgvHoaDonMain;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.OptionsBehavior.Editable = false;
            this.dgvHoaDon.OptionsBehavior.ReadOnly = true;
            this.dgvHoaDon.OptionsCustomization.AllowColumnMoving = false;
            this.dgvHoaDon.OptionsCustomization.AllowColumnResizing = false;
            this.dgvHoaDon.OptionsCustomization.AllowFilter = false;
            this.dgvHoaDon.OptionsCustomization.AllowGroup = false;
            this.dgvHoaDon.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvHoaDon.OptionsFind.AllowFindPanel = false;
            this.dgvHoaDon.OptionsView.ShowGroupPanel = false;
            this.dgvHoaDon.PaintStyleName = "UltraFlat";
            this.dgvHoaDon.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "TT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 61;
            // 
            // Ten
            // 
            this.Ten.Caption = "Mặt hàng";
            this.Ten.FieldName = "MatHang";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 244;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceCell.Options.UseTextOptions = true;
            this.DonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 124;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 124;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AppearanceCell.Options.UseTextOptions = true;
            this.ThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 146;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 403);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(572, 100);
            this.panel5.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxCBBanAn);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnChuyenBan);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(200, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 98);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chuyển bàn";
            // 
            // cbxCBBanAn
            // 
            this.cbxCBBanAn.Location = new System.Drawing.Point(83, 21);
            this.cbxCBBanAn.Name = "cbxCBBanAn";
            this.cbxCBBanAn.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxCBBanAn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxCBBanAn.Properties.Appearance.Options.UseFont = true;
            this.cbxCBBanAn.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxCBBanAn.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxCBBanAn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxCBBanAn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCBBanAn.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxCBBanAn.Properties.ShowHeader = false;
            this.cbxCBBanAn.Size = new System.Drawing.Size(281, 26);
            this.cbxCBBanAn.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Chọn bàn :";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Appearance.Options.UseFont = true;
            this.btnChuyenBan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnChuyenBan.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenBan.Image")));
            this.btnChuyenBan.Location = new System.Drawing.Point(9, 53);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(355, 34);
            this.btnChuyenBan.TabIndex = 45;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnTraMon);
            this.groupBox3.Controls.Add(this.txtTMSoLuong);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 98);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trả món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Số lượng :";
            // 
            // btnTraMon
            // 
            this.btnTraMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraMon.Appearance.Options.UseFont = true;
            this.btnTraMon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnTraMon.Image = ((System.Drawing.Image)(resources.GetObject("btnTraMon.Image")));
            this.btnTraMon.Location = new System.Drawing.Point(6, 53);
            this.btnTraMon.Name = "btnTraMon";
            this.btnTraMon.Size = new System.Drawing.Size(188, 34);
            this.btnTraMon.TabIndex = 39;
            this.btnTraMon.Text = "Trả món";
            this.btnTraMon.Click += new System.EventHandler(this.btnTraMon_Click);
            // 
            // txtTMSoLuong
            // 
            this.txtTMSoLuong.Location = new System.Drawing.Point(86, 23);
            this.txtTMSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTMSoLuong.Name = "txtTMSoLuong";
            this.txtTMSoLuong.Size = new System.Drawing.Size(97, 24);
            this.txtTMSoLuong.TabIndex = 42;
            this.txtTMSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTMSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupBox6);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(572, 100);
            this.panel4.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxGMMatHang);
            this.groupBox6.Controls.Add(this.txtGMSoLuong);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.btnGoiMon);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 47);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(570, 51);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            // 
            // cbxGMMatHang
            // 
            this.cbxGMMatHang.Location = new System.Drawing.Point(86, 16);
            this.cbxGMMatHang.Name = "cbxGMMatHang";
            this.cbxGMMatHang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxGMMatHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxGMMatHang.Properties.Appearance.Options.UseFont = true;
            this.cbxGMMatHang.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxGMMatHang.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxGMMatHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxGMMatHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGMMatHang.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxGMMatHang.Properties.ShowHeader = false;
            this.cbxGMMatHang.Size = new System.Drawing.Size(233, 26);
            this.cbxGMMatHang.TabIndex = 34;
            // 
            // txtGMSoLuong
            // 
            this.txtGMSoLuong.Location = new System.Drawing.Point(398, 18);
            this.txtGMSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtGMSoLuong.Name = "txtGMSoLuong";
            this.txtGMSoLuong.Size = new System.Drawing.Size(50, 24);
            this.txtGMSoLuong.TabIndex = 33;
            this.txtGMSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGMSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Số lượng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Chọn món : ";
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiMon.Appearance.Options.UseFont = true;
            this.btnGoiMon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnGoiMon.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiMon.Image")));
            this.btnGoiMon.Location = new System.Drawing.Point(458, 11);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(106, 34);
            this.btnGoiMon.TabIndex = 29;
            this.btnGoiMon.Text = "Gọi món";
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.txtKhuyenMai);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.txtTenBanAn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 47);
            this.panel3.TabIndex = 15;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Location = new System.Drawing.Point(351, 13);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(78, 24);
            this.txtKhuyenMai.TabIndex = 34;
            this.txtKhuyenMai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Khuyến mại (%) : ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(458, 6);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(107, 34);
            this.btnThanhToan.TabIndex = 18;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(83, 14);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(60, 17);
            this.txtTongTien.TabIndex = 17;
            this.txtTongTien.Text = "153,000";
            // 
            // txtTenBanAn
            // 
            this.txtTenBanAn.AutoSize = true;
            this.txtTenBanAn.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBanAn.Location = new System.Drawing.Point(7, 14);
            this.txtTenBanAn.Name = "txtTenBanAn";
            this.txtTenBanAn.Size = new System.Drawing.Size(59, 17);
            this.txtTenBanAn.TabIndex = 16;
            this.txtTenBanAn.Text = "Bàn 1 : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panelDsBanAn);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 526);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bàn ăn";
            // 
            // panelDsBanAn
            // 
            this.panelDsBanAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDsBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDsBanAn.Location = new System.Drawing.Point(3, 20);
            this.panelDsBanAn.Name = "panelDsBanAn";
            this.panelDsBanAn.Size = new System.Drawing.Size(691, 503);
            this.panelDsBanAn.TabIndex = 0;
            // 
            // ucBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucBanHang";
            this.Size = new System.Drawing.Size(1308, 548);
            this.Load += new System.EventHandler(this.ucBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCBBanAn.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMSoLuong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGMMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGMSoLuong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhuyenMai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel panelDsBanAn;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.Label txtTenBanAn;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraGrid.GridControl dgvHoaDonMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnChuyenBan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnTraMon;
        private System.Windows.Forms.NumericUpDown txtTMSoLuong;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown txtGMSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnGoiMon;
        private DevExpress.XtraEditors.LookUpEdit cbxCBBanAn;
        private DevExpress.XtraEditors.LookUpEdit cbxGMMatHang;
        private System.Windows.Forms.NumericUpDown txtKhuyenMai;
        private System.Windows.Forms.Label label2;
    }
}
