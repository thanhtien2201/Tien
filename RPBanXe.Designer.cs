namespace QLXM
{
    partial class RPBanXe
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPXE = new QLXM.RPXE();
            this.RPBanXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RPBanXeTableAdapter = new QLXM.RPXETableAdapters.RPBanXeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RPXE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPBanXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RPBanXeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLXM.RPBanXE.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(820, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // RPXE
            // 
            this.RPXE.DataSetName = "RPXE";
            this.RPXE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RPBanXeBindingSource
            // 
            this.RPBanXeBindingSource.DataMember = "RPBanXe";
            this.RPBanXeBindingSource.DataSource = this.RPXE;
            // 
            // RPBanXeTableAdapter
            // 
            this.RPBanXeTableAdapter.ClearBeforeFill = true;
            // 
            // RPBanXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 506);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RPBanXe";
            this.Text = "RPBanXe";
            this.Load += new System.EventHandler(this.RPBanXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPXE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPBanXeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPBanXeBindingSource;
        private RPXE RPXE;
        private RPXETableAdapters.RPBanXeTableAdapter RPBanXeTableAdapter;
    }
}