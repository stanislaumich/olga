
namespace KADR
{
    partial class FormReport
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
            this.kadrDataSet = new KADR.kadrDataSet();
            this.SotrZarplRepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SotrZarplRepTableAdapter = new KADR.kadrDataSetTableAdapters.SotrZarplRepTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kadrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SotrZarplRepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SotrZarplRepBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KADR.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // kadrDataSet
            // 
            this.kadrDataSet.DataSetName = "kadrDataSet";
            this.kadrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SotrZarplRepBindingSource
            // 
            this.SotrZarplRepBindingSource.DataMember = "SotrZarplRep";
            this.SotrZarplRepBindingSource.DataSource = this.kadrDataSet;
            // 
            // SotrZarplRepTableAdapter
            // 
            this.SotrZarplRepTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReport";
            this.Text = "ОТЧЕТ";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kadrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SotrZarplRepBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SotrZarplRepBindingSource;
        private kadrDataSet kadrDataSet;
        private kadrDataSetTableAdapters.SotrZarplRepTableAdapter SotrZarplRepTableAdapter;
    }
}