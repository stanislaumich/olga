
namespace AUTO
{
    partial class FormPutevka
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.putevkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUTODataSet = new AUTO.AUTODataSet();
            this.putevkaTableAdapter = new AUTO.AUTODataSetTableAdapters.putevkaTableAdapter();
            this.datepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestooutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvoditelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idautoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoTableAdapter = new AUTO.AUTODataSetTableAdapters.autoTableAdapter();
            this.voditelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voditelTableAdapter = new AUTO.AUTODataSetTableAdapters.voditelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putevkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voditelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Записать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Стереть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Авто";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Водитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Груз";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Место отправления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Место прибытия";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(33, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.autoBindingSource;
            this.comboBox1.DisplayMember = "dop";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.voditelBindingSource;
            this.comboBox2.DisplayMember = "fio";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(70, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(463, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(463, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(411, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(411, 20);
            this.textBox4.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datepDataGridViewTextBoxColumn,
            this.gruzDataGridViewTextBoxColumn,
            this.mestoinDataGridViewTextBoxColumn,
            this.mestooutDataGridViewTextBoxColumn,
            this.idvoditelDataGridViewTextBoxColumn,
            this.idautoDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.putevkaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 309);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
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
            // putevkaTableAdapter
            // 
            this.putevkaTableAdapter.ClearBeforeFill = true;
            // 
            // datepDataGridViewTextBoxColumn
            // 
            this.datepDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.datepDataGridViewTextBoxColumn.DataPropertyName = "date_p";
            this.datepDataGridViewTextBoxColumn.HeaderText = "ДАТА";
            this.datepDataGridViewTextBoxColumn.Name = "datepDataGridViewTextBoxColumn";
            this.datepDataGridViewTextBoxColumn.Width = 62;
            // 
            // gruzDataGridViewTextBoxColumn
            // 
            this.gruzDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gruzDataGridViewTextBoxColumn.DataPropertyName = "gruz";
            this.gruzDataGridViewTextBoxColumn.HeaderText = "ГРУЗ";
            this.gruzDataGridViewTextBoxColumn.Name = "gruzDataGridViewTextBoxColumn";
            this.gruzDataGridViewTextBoxColumn.Width = 60;
            // 
            // mestoinDataGridViewTextBoxColumn
            // 
            this.mestoinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mestoinDataGridViewTextBoxColumn.DataPropertyName = "mesto_in";
            this.mestoinDataGridViewTextBoxColumn.HeaderText = "ОТПРАВЛЕНИЕ";
            this.mestoinDataGridViewTextBoxColumn.Name = "mestoinDataGridViewTextBoxColumn";
            this.mestoinDataGridViewTextBoxColumn.Width = 114;
            // 
            // mestooutDataGridViewTextBoxColumn
            // 
            this.mestooutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mestooutDataGridViewTextBoxColumn.DataPropertyName = "mesto_out";
            this.mestooutDataGridViewTextBoxColumn.HeaderText = "НАЗНАЧЕНИЕ";
            this.mestooutDataGridViewTextBoxColumn.Name = "mestooutDataGridViewTextBoxColumn";
            this.mestooutDataGridViewTextBoxColumn.Width = 107;
            // 
            // idvoditelDataGridViewTextBoxColumn
            // 
            this.idvoditelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idvoditelDataGridViewTextBoxColumn.DataPropertyName = "id_voditel";
            this.idvoditelDataGridViewTextBoxColumn.HeaderText = "ВОДИТЕЛЬ";
            this.idvoditelDataGridViewTextBoxColumn.Name = "idvoditelDataGridViewTextBoxColumn";
            this.idvoditelDataGridViewTextBoxColumn.Width = 93;
            // 
            // idautoDataGridViewTextBoxColumn
            // 
            this.idautoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idautoDataGridViewTextBoxColumn.DataPropertyName = "id_auto";
            this.idautoDataGridViewTextBoxColumn.HeaderText = "АВТО";
            this.idautoDataGridViewTextBoxColumn.Name = "idautoDataGridViewTextBoxColumn";
            this.idautoDataGridViewTextBoxColumn.Width = 61;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 43;
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
            // voditelBindingSource
            // 
            this.voditelBindingSource.DataMember = "voditel";
            this.voditelBindingSource.DataSource = this.aUTODataSet;
            // 
            // voditelTableAdapter
            // 
            this.voditelTableAdapter.ClearBeforeFill = true;
            // 
            // FormPutevka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormPutevka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Путевки";
            this.Load += new System.EventHandler(this.FormPutevka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putevkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voditelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AUTODataSet aUTODataSet;
        private System.Windows.Forms.BindingSource putevkaBindingSource;
        private AUTODataSetTableAdapters.putevkaTableAdapter putevkaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gruzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestooutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvoditelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idautoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private AUTODataSetTableAdapters.autoTableAdapter autoTableAdapter;
        private System.Windows.Forms.BindingSource voditelBindingSource;
        private AUTODataSetTableAdapters.voditelTableAdapter voditelTableAdapter;
    }
}