namespace QLXM
{
    partial class frmRPPNH
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
            this.Phieu_Nhap_HangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSPhieuNhap = new QLXM.DSPhieuNhap();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Phieu_Nhap_HangTableAdapter = new QLXM.DSPhieuNhapTableAdapters.Phieu_Nhap_HangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Phieu_Nhap_HangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // Phieu_Nhap_HangBindingSource
            // 
            this.Phieu_Nhap_HangBindingSource.DataMember = "Phieu_Nhap_Hang";
            this.Phieu_Nhap_HangBindingSource.DataSource = this.DSPhieuNhap;
            // 
            // DSPhieuNhap
            // 
            this.DSPhieuNhap.DataSetName = "DSPhieuNhap";
            this.DSPhieuNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Phieu_Nhap_HangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLXM.RPPhieuNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(886, 431);
            this.reportViewer1.TabIndex = 0;
            // 
            // Phieu_Nhap_HangTableAdapter
            // 
            this.Phieu_Nhap_HangTableAdapter.ClearBeforeFill = true;
            // 
            // frmRPPNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 431);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRPPNH";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Phieu_Nhap_HangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Phieu_Nhap_HangBindingSource;
        private DSPhieuNhap DSPhieuNhap;
        private DSPhieuNhapTableAdapters.Phieu_Nhap_HangTableAdapter Phieu_Nhap_HangTableAdapter;
    }
}