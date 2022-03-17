
namespace KONTRAGENT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.z1DataSet = new KONTRAGENT.Z1DataSet();
            this.z1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANKTableAdapter = new KONTRAGENT.Z1DataSetTableAdapters.BANKTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazvDataGridViewTextBoxColumn,
            this.adrDataGridViewTextBoxColumn,
            this.schetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bANKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // z1DataSet
            // 
            this.z1DataSet.DataSetName = "Z1DataSet";
            this.z1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // z1DataSetBindingSource
            // 
            this.z1DataSetBindingSource.DataSource = this.z1DataSet;
            this.z1DataSetBindingSource.Position = 0;
            // 
            // bANKBindingSource
            // 
            this.bANKBindingSource.DataMember = "BANK";
            this.bANKBindingSource.DataSource = this.z1DataSet;
            // 
            // bANKTableAdapter
            // 
            this.bANKTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazvDataGridViewTextBoxColumn
            // 
            this.nazvDataGridViewTextBoxColumn.DataPropertyName = "nazv";
            this.nazvDataGridViewTextBoxColumn.HeaderText = "nazv";
            this.nazvDataGridViewTextBoxColumn.Name = "nazvDataGridViewTextBoxColumn";
            // 
            // adrDataGridViewTextBoxColumn
            // 
            this.adrDataGridViewTextBoxColumn.DataPropertyName = "adr";
            this.adrDataGridViewTextBoxColumn.HeaderText = "adr";
            this.adrDataGridViewTextBoxColumn.Name = "adrDataGridViewTextBoxColumn";
            // 
            // schetDataGridViewTextBoxColumn
            // 
            this.schetDataGridViewTextBoxColumn.DataPropertyName = "schet";
            this.schetDataGridViewTextBoxColumn.HeaderText = "schet";
            this.schetDataGridViewTextBoxColumn.Name = "schetDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource z1DataSetBindingSource;
        private Z1DataSet z1DataSet;
        private System.Windows.Forms.BindingSource bANKBindingSource;
        private Z1DataSetTableAdapters.BANKTableAdapter bANKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schetDataGridViewTextBoxColumn;
    }
}

