
namespace AUTO
{
    partial class FormReport1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AUTODataSet1 = new AUTO.AUTODataSet1();
            this.dolg_ЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolg_ЗапросTableAdapter = new AUTO.AUTODataSet1TableAdapters.dolg_ЗапросTableAdapter();
            this.dolg_ЗапросTableAdapter1 = new AUTO.AUTODataSet1TableAdapters.dolg_ЗапросTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AUTODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolg_ЗапросBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(5, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dolg_ЗапросBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AUTO.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 47);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(776, 391);
            this.reportViewer2.TabIndex = 1;
            // 
            // AUTODataSet1
            // 
            this.AUTODataSet1.DataSetName = "AUTODataSet1";
            this.AUTODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolg_ЗапросBindingSource
            // 
            this.dolg_ЗапросBindingSource.DataMember = "dolg Запрос";
            this.dolg_ЗапросBindingSource.DataSource = this.AUTODataSet1;
            // 
            // dolg_ЗапросTableAdapter
            // 
            this.dolg_ЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // dolg_ЗапросTableAdapter1
            // 
            this.dolg_ЗапросTableAdapter1.ClearBeforeFill = true;
            // 
            // FormReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Name = "FormReport1";
            this.Text = "FormReport1";
            this.Load += new System.EventHandler(this.FormReport1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AUTODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolg_ЗапросBindingSource)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource dolg_ЗапросBindingSource;
        private AUTODataSet1 AUTODataSet1;
        private AUTODataSet1TableAdapters.dolg_ЗапросTableAdapter dolg_ЗапросTableAdapter;
        private AUTODataSet1TableAdapters.dolg_ЗапросTableAdapter dolg_ЗапросTableAdapter1;
    }
}