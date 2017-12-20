namespace BTL_CNPM.Report
{
    partial class FrmRpPhieuNhap
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpViewerHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpDataSet1 = new BTL_CNPM.Report.rpDataSet();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rpViewerHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 506);
            this.panel1.TabIndex = 0;
            // 
            // rpViewerHoaDon
            // 
            this.rpViewerHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HoaDon";
            reportDataSource1.Value = this.hOADONBindingSource;
            this.rpViewerHoaDon.LocalReport.DataSources.Add(reportDataSource1);
            this.rpViewerHoaDon.LocalReport.ReportEmbeddedResource = "BTL_CNPM.Report.rpPhieuNhap.rdlc";
            this.rpViewerHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpViewerHoaDon.Name = "rpViewerHoaDon";
            this.rpViewerHoaDon.Size = new System.Drawing.Size(806, 504);
            this.rpViewerHoaDon.TabIndex = 0;
            // 
            // rpDataSet1
            // 
            this.rpDataSet1.DataSetName = "rpDataSet";
            this.rpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.rpDataSet1;
            // 
            // FrmRpPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 586);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmRpPhieuNhap";
            this.Resizable = false;
            this.Text = "PHIẾU NHẬP HÀNG";
            this.Load += new System.EventHandler(this.FrmRpPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpViewerHoaDon;
        private rpDataSet rpDataSet;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private rpDataSet rpDataSet1;
    }
}