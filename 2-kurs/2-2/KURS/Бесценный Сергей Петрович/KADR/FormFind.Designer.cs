
namespace KADR
{
    partial class FormFind
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sotrudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kadrDataSet = new KADR.kadrDataSet();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarplataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zarplataTableAdapter = new KADR.kadrDataSetTableAdapters.zarplataTableAdapter();
            this.sotrudTableAdapter = new KADR.kadrDataSetTableAdapters.sotrudTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите часть ФИО:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodDataGridViewTextBoxColumn,
            this.okladDataGridViewTextBoxColumn,
            this.premiaDataGridViewTextBoxColumn,
            this.itogoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zarplataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(565, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.nazvDataGridViewTextBoxColumn,
            this.adrDataGridViewTextBoxColumn,
            this.phonesDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.sotrudBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 157);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(565, 137);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // sotrudBindingSource
            // 
            this.sotrudBindingSource.DataMember = "sotrud";
            this.sotrudBindingSource.DataSource = this.kadrDataSet;
            // 
            // kadrDataSet
            // 
            this.kadrDataSet.DataSetName = "kadrDataSet";
            this.kadrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Период";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodDataGridViewTextBoxColumn.Width = 70;
            // 
            // okladDataGridViewTextBoxColumn
            // 
            this.okladDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.okladDataGridViewTextBoxColumn.DataPropertyName = "oklad";
            this.okladDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.okladDataGridViewTextBoxColumn.Name = "okladDataGridViewTextBoxColumn";
            this.okladDataGridViewTextBoxColumn.ReadOnly = true;
            this.okladDataGridViewTextBoxColumn.Width = 64;
            // 
            // premiaDataGridViewTextBoxColumn
            // 
            this.premiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.premiaDataGridViewTextBoxColumn.DataPropertyName = "premia";
            this.premiaDataGridViewTextBoxColumn.HeaderText = "Премия";
            this.premiaDataGridViewTextBoxColumn.Name = "premiaDataGridViewTextBoxColumn";
            this.premiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.premiaDataGridViewTextBoxColumn.Width = 72;
            // 
            // itogoDataGridViewTextBoxColumn
            // 
            this.itogoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itogoDataGridViewTextBoxColumn.DataPropertyName = "itogo";
            this.itogoDataGridViewTextBoxColumn.HeaderText = "Итого";
            this.itogoDataGridViewTextBoxColumn.Name = "itogoDataGridViewTextBoxColumn";
            this.itogoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itogoDataGridViewTextBoxColumn.Width = 62;
            // 
            // zarplataBindingSource
            // 
            this.zarplataBindingSource.DataMember = "zarplata";
            this.zarplataBindingSource.DataSource = this.kadrDataSet;
            // 
            // zarplataTableAdapter
            // 
            this.zarplataTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudTableAdapter
            // 
            this.sotrudTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сбросить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 59;
            // 
            // nazvDataGridViewTextBoxColumn
            // 
            this.nazvDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nazvDataGridViewTextBoxColumn.DataPropertyName = "nazv";
            this.nazvDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.nazvDataGridViewTextBoxColumn.Name = "nazvDataGridViewTextBoxColumn";
            this.nazvDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazvDataGridViewTextBoxColumn.Width = 90;
            // 
            // adrDataGridViewTextBoxColumn
            // 
            this.adrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adrDataGridViewTextBoxColumn.DataPropertyName = "adr";
            this.adrDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adrDataGridViewTextBoxColumn.Name = "adrDataGridViewTextBoxColumn";
            this.adrDataGridViewTextBoxColumn.ReadOnly = true;
            this.adrDataGridViewTextBoxColumn.Width = 63;
            // 
            // phonesDataGridViewTextBoxColumn
            // 
            this.phonesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phonesDataGridViewTextBoxColumn.DataPropertyName = "phones";
            this.phonesDataGridViewTextBoxColumn.HeaderText = "Тел";
            this.phonesDataGridViewTextBoxColumn.Name = "phonesDataGridViewTextBoxColumn";
            this.phonesDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonesDataGridViewTextBoxColumn.Width = 51;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 5;
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormFind";
            this.Text = "Форма поиска";
            this.Load += new System.EventHandler(this.FormFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kadrDataSet kadrDataSet;
        private System.Windows.Forms.BindingSource zarplataBindingSource;
        private kadrDataSetTableAdapters.zarplataTableAdapter zarplataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource sotrudBindingSource;
        private kadrDataSetTableAdapters.sotrudTableAdapter sotrudTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}