
namespace AUTO
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestooutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.putevkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTODataSet = new AUTO.AUTODataSet();
            this.queriesTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.putevkaTableAdapter = new AUTO.AUTODataSetTableAdapters.putevkaTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voditelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voditelTableAdapter = new AUTO.AUTODataSetTableAdapters.voditelTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoTableAdapter = new AUTO.AUTODataSetTableAdapters.autoTableAdapter();
            this.dopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rashodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putevkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voditelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите строку для поиска и укажите что искать";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Водители";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Автомобили";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 110);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "Путевки";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(191, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datepDataGridViewTextBoxColumn,
            this.gruzDataGridViewTextBoxColumn,
            this.mestoinDataGridViewTextBoxColumn,
            this.mestooutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.putevkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(774, 382);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            // 
            // datepDataGridViewTextBoxColumn
            // 
            this.datepDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datepDataGridViewTextBoxColumn.DataPropertyName = "date_p";
            this.datepDataGridViewTextBoxColumn.HeaderText = "ДАТА";
            this.datepDataGridViewTextBoxColumn.Name = "datepDataGridViewTextBoxColumn";
            this.datepDataGridViewTextBoxColumn.ReadOnly = true;
            this.datepDataGridViewTextBoxColumn.Width = 62;
            // 
            // gruzDataGridViewTextBoxColumn
            // 
            this.gruzDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gruzDataGridViewTextBoxColumn.DataPropertyName = "gruz";
            this.gruzDataGridViewTextBoxColumn.HeaderText = "ГРУЗ";
            this.gruzDataGridViewTextBoxColumn.Name = "gruzDataGridViewTextBoxColumn";
            this.gruzDataGridViewTextBoxColumn.ReadOnly = true;
            this.gruzDataGridViewTextBoxColumn.Width = 60;
            // 
            // mestoinDataGridViewTextBoxColumn
            // 
            this.mestoinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mestoinDataGridViewTextBoxColumn.DataPropertyName = "mesto_in";
            this.mestoinDataGridViewTextBoxColumn.HeaderText = "ОТКУДА";
            this.mestoinDataGridViewTextBoxColumn.Name = "mestoinDataGridViewTextBoxColumn";
            this.mestoinDataGridViewTextBoxColumn.ReadOnly = true;
            this.mestoinDataGridViewTextBoxColumn.Width = 78;
            // 
            // mestooutDataGridViewTextBoxColumn
            // 
            this.mestooutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mestooutDataGridViewTextBoxColumn.DataPropertyName = "mesto_out";
            this.mestooutDataGridViewTextBoxColumn.HeaderText = "КУДА";
            this.mestooutDataGridViewTextBoxColumn.Name = "mestooutDataGridViewTextBoxColumn";
            this.mestooutDataGridViewTextBoxColumn.ReadOnly = true;
            this.mestooutDataGridViewTextBoxColumn.Width = 63;
            // 
            // putevkaBindingSource
            // 
            this.putevkaBindingSource.DataMember = "putevka";
            this.putevkaBindingSource.DataSource = this.aUTODataSet;
            // 
            // aUTODataSet
            // 
            this.aUTODataSet.DataSetName = "AUTODataSet";
            this.aUTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queriesTableAdapterBindingSource
            // 
            this.queriesTableAdapterBindingSource.DataSource = typeof(AUTO.AUTODataSetTableAdapters.QueriesTableAdapter);
            // 
            // putevkaTableAdapter
            // 
            this.putevkaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.dopDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.voditelBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 142);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(772, 379);
            this.dataGridView2.TabIndex = 8;
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
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "ВОЗРАСТ";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 82;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "КЛАСС";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            this.classDataGridViewTextBoxColumn.Width = 68;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "АДРЕС";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Width = 69;
            // 
            // dopDataGridViewTextBoxColumn
            // 
            this.dopDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dopDataGridViewTextBoxColumn.DataPropertyName = "dop";
            this.dopDataGridViewTextBoxColumn.HeaderText = "ПРИМ";
            this.dopDataGridViewTextBoxColumn.Name = "dopDataGridViewTextBoxColumn";
            this.dopDataGridViewTextBoxColumn.ReadOnly = true;
            this.dopDataGridViewTextBoxColumn.Width = 64;
            // 
            // voditelBindingSource
            // 
            this.voditelBindingSource.DataMember = "voditel";
            this.voditelBindingSource.DataSource = this.aUTODataSet;
            // 
            // voditelTableAdapter
            // 
            this.voditelTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dopDataGridViewTextBoxColumn1,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn,
            this.godDataGridViewTextBoxColumn,
            this.rashodDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.autoBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(7, 140);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(774, 381);
            this.dataGridView3.TabIndex = 9;
            this.dataGridView3.Visible = false;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "auto";
            this.autoBindingSource.DataSource = this.aUTODataSet;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // dopDataGridViewTextBoxColumn1
            // 
            this.dopDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dopDataGridViewTextBoxColumn1.DataPropertyName = "dop";
            this.dopDataGridViewTextBoxColumn1.HeaderText = "НАЗВАНИЕ";
            this.dopDataGridViewTextBoxColumn1.Name = "dopDataGridViewTextBoxColumn1";
            this.dopDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dopDataGridViewTextBoxColumn1.Width = 91;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "МАРКА";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            this.markaDataGridViewTextBoxColumn.Width = 69;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "МОДЕЛЬ";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "НОМЕР";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            this.nomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomerDataGridViewTextBoxColumn.Width = 71;
            // 
            // godDataGridViewTextBoxColumn
            // 
            this.godDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.godDataGridViewTextBoxColumn.DataPropertyName = "god";
            this.godDataGridViewTextBoxColumn.HeaderText = "ГОД";
            this.godDataGridViewTextBoxColumn.Name = "godDataGridViewTextBoxColumn";
            this.godDataGridViewTextBoxColumn.ReadOnly = true;
            this.godDataGridViewTextBoxColumn.Width = 55;
            // 
            // rashodDataGridViewTextBoxColumn
            // 
            this.rashodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rashodDataGridViewTextBoxColumn.DataPropertyName = "rashod";
            this.rashodDataGridViewTextBoxColumn.HeaderText = "РАСХОД";
            this.rashodDataGridViewTextBoxColumn.Name = "rashodDataGridViewTextBoxColumn";
            this.rashodDataGridViewTextBoxColumn.ReadOnly = true;
            this.rashodDataGridViewTextBoxColumn.Width = 77;
            // 
            // FormFind
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(788, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПОИСК";
            this.Load += new System.EventHandler(this.FormFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putevkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queriesTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voditelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource queriesTableAdapterBindingSource;
        private AUTODataSet aUTODataSet;
        private System.Windows.Forms.BindingSource putevkaBindingSource;
        private AUTODataSetTableAdapters.putevkaTableAdapter putevkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gruzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestooutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource voditelBindingSource;
        private AUTODataSetTableAdapters.voditelTableAdapter voditelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private AUTODataSetTableAdapters.autoTableAdapter autoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rashodDataGridViewTextBoxColumn;
    }
}